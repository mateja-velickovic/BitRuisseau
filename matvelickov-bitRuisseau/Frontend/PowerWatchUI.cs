using Backend;
using Backend.Protocol;
using Frontend.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
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
    public partial class PowerWatchUI : Form
    {
        private ILogger _logger;
        private Agent _agent;


        public PowerWatchUI(string broker)
        {
            InitializeComponent();
            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug)
            );
            _logger = loggerFactory.CreateLogger<PowerWatchUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);
            _agent.Start();
        }

        private void OnMessageReceived(Envelope envelope)
        {
        }

        /// <summary>
        /// Reorganize (tile) the supervision forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanup_Click(object sender, EventArgs e)
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            int topoffset = screen.Top + 5;
            int leftoffset = screen.Left+ 5;
        }

        private void tmrUpdateView_Tick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Trash all display forms (they will respawn when statuses come in)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReset_Click(object sender, EventArgs e)
        {
        }
    }
}