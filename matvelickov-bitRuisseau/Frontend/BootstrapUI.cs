//Auteur : JMY
//Date   : 28.10.2024 
//Lieu   : ETML
//Descr. : Bootstrap pour powercher
using Backend;
using Microsoft.Extensions.Logging;

namespace Frontend;

public partial class BootstrapUI : Form
{
    MotherNatureUI motherNature;
    ILoggerFactory loggerFactory;
    public BootstrapUI(ILoggerFactory loggerFactory)
    {
        this.loggerFactory = loggerFactory;
        InitializeComponent();
        dpdBroker.SelectedText = "localhost";
    }

    private void btnMotherNature_Click(object sender, EventArgs e)
    {
        if (motherNature == null || motherNature.IsDisposed)
        {
            motherNature = new MotherNatureUI(dpdBroker.Text);
        }
        motherNature.Show();
    }

    private void btnBroadcastAgent_Click(object sender, EventArgs e)
    {
        HouseUI houseUI = new HouseUI(dpdBroker.Text);
        houseUI.Show();
    }

    private void btnPowerWatch_Click(object sender, EventArgs e)
    {
        PowerWatchUI powerWatchUI = new PowerWatchUI(dpdBroker.Text);
        powerWatchUI.Show();
    }
    private void btnPowerDeal_Click(object sender, EventArgs e)
    {
        PowerDealUI powerDealUI = new PowerDealUI(dpdBroker.Text);
        powerDealUI.Show();
    }
}