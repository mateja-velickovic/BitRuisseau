
using System.Text.Json;
using Backend;
using Backend.Protocol;
using DataModel;
using Frontend.Logging;
using Microsoft.Extensions.Logging;
using DataModel.Catalog;

namespace Frontend
{
    public partial class HouseUI_mvc : Form
    {
        private House _house;
        private Agent _agent;
        private readonly ILogger _logger;

        private List<string> bonus_id = new List<string>();
        private double balance;
        private string currentId = "any";

        private DateTime lastTime = new DateTime(2020, 01, 01);

        public EnergyManager EManager = new EnergyManager();

        // Consommateurs
        private Playstation5 ps5 = new Playstation5("MI295815201", "Ma console PS5");
        private BeerDispenser beerDispenser = new BeerDispenser("BO29510251", "Une bière bien fraîche");
        private MSW_Pompe_a_chaleur pompeChaleur = new MSW_Pompe_a_chaleur("PM85129012", "Poru se réchauffer durant l'hiver froid");

        // Producteurs
        private PanneauSolaireVoltima voltima = new PanneauSolaireVoltima("PW129587157", "Un bon panneau solaire");

        private double total_consommation = 0;
        private double total_production = 0;
        private double total_bilan = 0;
        private double bilan_kw = 0;

        private List<ConsumingAppliance> conList = new List<ConsumingAppliance>();
        private List<ProductiveAppliance> solarPanels = new List<ProductiveAppliance>();

        public HouseUI_mvc(string broker)
        {
            InitializeComponent();

            //Technical components
            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddProvider(new RichTextBoxLoggerProvider(txtConsole))
                    .SetMinimumLevel(LogLevel.Debug)
                );
            _logger = loggerFactory.CreateLogger<HouseUI_mvc>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);

            this.Text = $@"House {_agent.NodeId}";

            // TODO : Initiate UPS
            // TODO : Business components (house, wind)

            EManager.UPS.TurnOn(true);
            EManager.UPS.Put(200);

            _house = new House(_agent.NodeId, "Mateja", "La belle maison de mateja");

            conList.Add(ps5);
            conList.Add(beerDispenser);
            conList.Add(pompeChaleur);

            // Ajout des producteurs dans une liste (panneaux solaires)
            solarPanels.AddRange(Enumerable.Repeat(voltima, 30));

            _agent.Start();
        }

        private void OnMessageReceived(Envelope envelope)
        {
            //  _logger.LogInformation(envelope.ToString());
            switch (envelope.Type)
            {
                case MessageType.HELLO:

                    _logger.LogInformation(envelope.SenderId + "Said Hello");

                    break;

                case MessageType.HOUSE_STATUS_REQUEST:

                    _agent.Send(new Envelope("Maison de Mateja", MessageType.HOUSE_STATUS, JsonSerializer.Serialize(_house)));

                    break;

                case MessageType.TOWN_ENVIRONMENT:

                    ps5.TurnOn(playstation.Checked ? true : false);
                    beerDispenser.TurnOn(beer.Checked ? true : false);
                    pompeChaleur.TurnOn(pompe.Checked ? true : false);

                    TownEnvironment env = JsonSerializer.Deserialize<TownEnvironment>(envelope.Message)!;

                    if (lastTime != new DateTime(2020, 01, 01))
                    {
                        // Calcul de la période entre le dernier message reçu est l'instant actuel
                        int minutes = (int)(lastTime - env.DateTime).TotalMinutes;

                        // Consommation énergétique pour chaque appareil
                        double currentConsommation = conList.Where(c => c.IsActive).Sum(c => minutes * c.MaxPower);
                        total_consommation += currentConsommation * -1;

                        // Production énergétique pour chaque appareil (panneaux solaires) en tenant compte du % de soleil
                        double currentProduction = (solarPanels.Sum(p => minutes * p.MaxPower) * -1 / 100) * (env.SolarEnergy * 100);
                        total_production += currentProduction;

                        total_bilan = total_production - total_consommation;
                        bilan_kw = total_bilan / 1000;

                        double bilanQuotidien = currentConsommation + currentProduction;

                        if (bilanQuotidien < 0)
                            EManager.UPS.Take((bilanQuotidien / 1000) * -1);
                        else if (bilanQuotidien >= 0)
                            EManager.UPS.Put(bilanQuotidien / 1000);

                        ups_total.Invoke(new MethodInvoker(() => ups_total.Text = $"{EManager.UPS.Load.ToString("#.##")}Kw/{EManager.UPS.Capacity}Kw"));

                        // TODO invisible
                        // Bilan UPS %
                        // ups.Visible = (bilan_kw / EManager.UPS.Capacity * 100 < 0) ? false : true;
                        ups.Invoke(new MethodInvoker(() => ups.Text = (EManager.UPS.Load / EManager.UPS.Capacity * 100).ToString("###") + "%"));

                        // Bilan UPS Kw
                        bilan.ForeColor = (total_bilan <= 0) ? Color.Red : Color.Green;
                        bilan.Invoke(new MethodInvoker(() => bilan.Text = $"{(total_bilan / 1000).ToString("#.##")}Kw"));
                    }

                    lastTime = env.DateTime;

                    time.Invoke(new MethodInvoker(() =>
                    {
                        time.Text = env.DateTime.ToString("HH:mm");
                    }));

                    break;

                case MessageType.POWER:

                    // TODO : PUT
                    // TODO : TAKE

                    break;

                case MessageType.CASH:
                    CashTransaction cash = JsonSerializer.Deserialize<CashTransaction>(envelope.Message.ToString())!;

                    currentId = envelope.Id;

                    if (!bonus_id.Contains(currentId))
                    {
                        bonus_id.Add(currentId);
                        _logger.LogInformation($"\nBonus quotidien : {cash.Amount} powercoins\nId : {currentId}");
                        balance += cash.Amount;
                    }

                    wallet.Invoke(new MethodInvoker(() => wallet.Text = $"{balance} PwCs"));

                    break;
            }
        }

        private void HouseUI_Load(object sender, EventArgs e)
        {

        }
        private void diff_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public void playstation_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
