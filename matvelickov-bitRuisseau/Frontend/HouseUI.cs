
using System.Text.Json;
using Backend;
using Backend.Protocol;
using Frontend.Logging;
using Microsoft.Extensions.Logging;

namespace Frontend
{
    public partial class HouseUI : Form
    {
        private Agent _agent;
        private readonly ILogger _logger;

        public HouseUI(string broker)
        {
            InitializeComponent();
            
            //Technical components
            var loggerFactory=LoggerFactory.Create(
                builder => builder
                    .AddProvider(new RichTextBoxLoggerProvider(txtConsole))
                    .SetMinimumLevel(LogLevel.Debug)
                );
            _logger = loggerFactory.CreateLogger<HouseUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);

            this.Text = $@"House {_agent.NodeId}";
            
            //Business components
        }
        
        // Avoid race condition on txtConsole
        public new void Show()
        {
            base.Show();
            _agent.Start();
        }

        

        private void OnMessageReceived(Envelope envelope)
        {
            _logger.LogInformation(envelope.ToString());
            
            switch (envelope.Type)
            {
                case MessageType.HELLO:
                    _logger.LogInformation(envelope.SenderId + "Said Hello");
                    break;
                case MessageType.HOUSE_STATUS_REQUEST:
                    break;
            }
        }


        private void HouseUI_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}
