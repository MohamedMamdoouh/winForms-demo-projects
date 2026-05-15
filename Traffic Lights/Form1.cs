using System;
using System.Windows.Forms;

namespace TestWinForms_22
{
    public partial class frmTrafficLights : Form
    {
        public frmTrafficLights()
        {
            InitializeComponent();
        }

        private byte _CurrentPhaseTime = 0;
        private byte _Phase = 0;

        private void frmTrafficLights_Load(object sender, EventArgs e)
        {
            LightTimer.Start();
            SetPhase(0);
        }

        private void SetPhase(byte Phase)
        {
            switch (Phase)
            {
                case 0:    
                    ctrlTrafficLights1.MakeLightGreen();
                    ctrlTrafficLights3.MakeLightGreen();

                    ctrlTrafficLights2.MakeLightRed();
                    ctrlTrafficLights4.MakeLightRed();

                    _CurrentPhaseTime = ctrlTrafficLights1.GreenLightDuration;
                    break;

                case 1: 
                    ctrlTrafficLights1.MakeLightYellow();
                    ctrlTrafficLights3.MakeLightYellow();

                    ctrlTrafficLights2.MakeLightRed();
                    ctrlTrafficLights4.MakeLightRed();

                    _CurrentPhaseTime = ctrlTrafficLights1.YellowLightDuration;
                    break;

                case 2: 
                    ctrlTrafficLights1.MakeLightRed();
                    ctrlTrafficLights3.MakeLightRed();

                    ctrlTrafficLights2.MakeLightGreen();
                    ctrlTrafficLights4.MakeLightGreen();

                    _CurrentPhaseTime = ctrlTrafficLights2.GreenLightDuration;
                    break;

                case 3:
                    ctrlTrafficLights1.MakeLightRed();
                    ctrlTrafficLights3.MakeLightRed();

                    ctrlTrafficLights2.MakeLightYellow();
                    ctrlTrafficLights4.MakeLightYellow();

                    _CurrentPhaseTime = ctrlTrafficLights2.YellowLightDuration;
                    break;
            }
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            _CurrentPhaseTime--;

            if (_CurrentPhaseTime <= 0)
            {
                _Phase = (byte)((_Phase + 1) % 4);
                SetPhase(_Phase);
            }
        }
    }
}
