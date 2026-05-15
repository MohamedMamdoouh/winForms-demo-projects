using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestWinForms_22
{
    public partial class ctrlTrafficLights : UserControl
    {
        public ctrlTrafficLights()
        {
            InitializeComponent();
        }

        public enum enLight { Unknown = 0, Red = 1, Yellow = 2, Green = 3 };
        private enLight _CurrentLight = enLight.Red;

        private byte _RedLightDuration = 15;
        private byte _GreenLightDuration = 10;
        private byte _YellowLightDuration = 10;
        private byte _CurrentLightDuration = 10;
        private byte _CurrentTimerValue = 0;

        public class TrafficLightsEventArgs : EventArgs
        {
            public enLight CurrentLight { get; }
            public byte CurrentDuration { get; }

            public TrafficLightsEventArgs(enLight CurrentLight, byte CurrentDuration)
            {
                this.CurrentLight = CurrentLight;
                this.CurrentDuration = CurrentDuration;
            }
        }

        public event EventHandler<TrafficLightsEventArgs> RedOn;
        public void OnRedOn()
        {
            RedOn?.Invoke(this, new TrafficLightsEventArgs(enLight.Red, _RedLightDuration));
        }

        public event EventHandler<TrafficLightsEventArgs> YellowOn;
        public void OnYellowOn()
        {
            YellowOn?.Invoke(this, new TrafficLightsEventArgs(enLight.Yellow, _YellowLightDuration));
        }

        public event EventHandler<TrafficLightsEventArgs> GreenOn;
        public void OnGreenOn()
        {
            GreenOn?.Invoke(this, new TrafficLightsEventArgs(enLight.Green, _GreenLightDuration));
        }

        public byte RedLightDuration
        {
            get
            {
                return _RedLightDuration;
            }

            set
            {
                _RedLightDuration = value;
                _CurrentLightDuration = _RedLightDuration;
            }
        }

        public byte GreenLightDuration
        {
            get
            {
                return _GreenLightDuration;
            }

            set
            {
                _GreenLightDuration = value;
                _CurrentLightDuration = _GreenLightDuration;
            }
        }

        public byte YellowLightDuration
        {
            get
            {
                return _YellowLightDuration;
            }

            set
            {
                _YellowLightDuration = value;
                _CurrentLightDuration = _YellowLightDuration;
            }
        }

        private void _HandleTrafficLightChoiceOnTimer(enLight Light)
        {
            // Red → Green → Yellow → Red
            switch (Light)
            {
                case enLight.Red:
                    _CurrentLight = enLight.Green;
                    _CurrentLightDuration = _GreenLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Green;
                    lblLightCounter.ForeColor = Color.Green;
                    OnGreenOn();
                    break;

                case enLight.Green:
                    _CurrentLight = enLight.Yellow;
                    _CurrentLightDuration = _YellowLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Yellow;
                    lblLightCounter.ForeColor = Color.Orange;
                    OnYellowOn();
                    break;

                case enLight.Yellow:
                    _CurrentLight = enLight.Red;
                    _CurrentLightDuration = _RedLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Red;
                    lblLightCounter.ForeColor = Color.Red;
                    OnRedOn();
                    break;

                default:
                    _CurrentLight = enLight.Unknown;
                    _CurrentLightDuration = 0;
                    _CurrentTimerValue = 0;
                    pbLight.Image = null;
                    lblLightCounter.ForeColor = Color.Black;
                    break;
            }
        }

        private void _HandleTrafficLightChoiceOnDesign(enLight Light)
        {
            switch (Light)
            {
                case enLight.Red:
                    _CurrentLight = enLight.Red;
                    _CurrentLightDuration = _RedLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Red;
                    lblLightCounter.ForeColor = Color.Red;
                    OnRedOn();
                    break;

                case enLight.Green:
                    _CurrentLight = enLight.Green;
                    _CurrentLightDuration = _GreenLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Green;
                    lblLightCounter.ForeColor = Color.Green;
                    OnGreenOn();
                    break;

                case enLight.Yellow:
                    _CurrentLight = enLight.Yellow;
                    _CurrentLightDuration = _YellowLightDuration;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = Properties.Resources.Yellow;
                    lblLightCounter.ForeColor = Color.Orange;
                    OnYellowOn();
                    break;

                default:
                    _CurrentLight = enLight.Unknown;
                    _CurrentLightDuration = 0;
                    _CurrentTimerValue = _CurrentLightDuration;
                    pbLight.Image = null;
                    break;
            }

            lblLightCounter.Text = _CurrentTimerValue.ToString();
        }

        public enLight CurrentLight
        {
            get
            {
                return _CurrentLight;
            }

            set
            {
                _CurrentLight = value;
                _HandleTrafficLightChoiceOnDesign(_CurrentLight);
            }
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            if (_CurrentTimerValue == 0)
            {
                _HandleTrafficLightChoiceOnTimer(_CurrentLight);
            }

            else
            {
                _CurrentTimerValue--;
            }

            lblLightCounter.Text = _CurrentTimerValue.ToString();
        }

        private void ctrlTrafficLights_Load(object sender, EventArgs e)
        {
            LightTimer.Start();
        }

        public void MakeLightRed()
        {
            _HandleTrafficLightChoiceOnDesign(enLight.Red);
            LightTimer.Start();
        }

        public void MakeLightYellow()
        {
            _HandleTrafficLightChoiceOnDesign(enLight.Yellow);
            LightTimer.Start();
        }

        public void MakeLightGreen()
        {
            _HandleTrafficLightChoiceOnDesign(enLight.Green);
            LightTimer.Start();
        }
    }
}
