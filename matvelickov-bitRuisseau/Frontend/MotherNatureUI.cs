using System.Diagnostics.CodeAnalysis;
using Backend;
using Backend.Protocol;
using Frontend.Logging;
using Microsoft.Extensions.Logging;

namespace Frontend;

public partial class MotherNatureUI : Form
{
    private const int MAX_WIND_SPEED = 120;

    private ILogger logger;
    private Agent agent;
    private DateTime? simutime = null;
    private TimeSpan delta;
    private double cloudCover = 0.5;
    private int windSpeed = 10;

    private Random random = new Random();

    public MotherNatureUI(string broker)
    {
        InitializeComponent();

        var loggerFactory = LoggerFactory.Create(
            builder => builder
                .AddConsole()
                .SetMinimumLevel(LogLevel.Debug)
        );
        logger = loggerFactory.CreateLogger<MotherNatureUI>();
        agent = new Agent(loggerFactory, broker, isMotherNature: true);

        this.Text = $@"MotherNature {agent.NodeId}";
    }

    private void tmrPulse_Tick(object sender, EventArgs e)
    {
        // Change weather conditions
        cloudCover = Math.Max(0,Math.Min(1.0, cloudCover + random.Next(-1,2)/1000.0));
        if (random.Next(5) == 0) windSpeed = Math.Max(0, Math.Min(MAX_WIND_SPEED, windSpeed + random.Next(-1,2)));
        lblCloudCover.Text = cloudCover.ToString("P1");
        lblWindSpeed.Text = windSpeed.ToString() + " Km/h";
    }

    private void cmdStart_Click(object sender, EventArgs e)
    {
        tmrPulse.Interval = (int)(nudSimuTick.Value * 1000);
        tmrPulse.Enabled = true;
        simutime = datStart.Value;
        delta = new TimeSpan(0, (int)nudSiminterval.Value, 0); // capture value of interval once
        grpSimu.Visible = false;
    }

}