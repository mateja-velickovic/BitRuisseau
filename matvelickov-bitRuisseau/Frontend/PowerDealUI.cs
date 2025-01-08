using Backend;
using Backend.Protocol;
using Frontend.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Frontend
{
    public partial class PowerDealUI : Form
    {
        private ILogger _logger;
        private Agent _agent;
        private Envelope? _priceBroadcast = null;

        public PowerDealUI(string broker)
        {
            InitializeComponent();
            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug)
            );
            _logger = loggerFactory.CreateLogger<PowerWatchUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived, idPrefix:"PD-");
            _agent.Start();
            nudKwhPrice_ValueChanged(new Object(),new EventArgs());
        }

        private void OnMessageReceived(Envelope envelope)
        {
            if (envelope.SenderId == _agent.NodeId) return; // Ignore my own messages

        }

        private void tmrSpendCash_Tick(object sender, EventArgs e)
        {
            _agent.Send(_priceBroadcast);
        }

        private void nudKwhPrice_ValueChanged(object sender, EventArgs e)
        {
            // regenerate the price offer envelope with new Id
        }
    }
}
