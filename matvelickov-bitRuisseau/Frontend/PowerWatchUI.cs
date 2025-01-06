using Backend;
using Backend.Protocol;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Text.Json;

namespace Frontend
{
    public partial class PowerWatchUI : Form
    {
        private ILogger _logger;
        private Agent _agent;
        private readonly bool _encrypt;


        public PowerWatchUI(string broker)
        {
            InitializeComponent();
            var loggerFactory = LoggerFactory.Create(
                builder => builder
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
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cleaning up house");
            }
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