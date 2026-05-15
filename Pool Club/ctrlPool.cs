using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Pool_Club
{
    public partial class ctrlPool : UserControl
    {
        public ctrlPool()
        {
            InitializeComponent();

        }

        private float _HourlyRate = 10;
        private string _TablePlayer = "Player";
        private string _TableTitle = "Table";
        private ushort _TotalSeconds = 0; 
        private float _TotalFees = 0;

        public class PlayCompletedEventArgs : EventArgs
        {
            public string TimeText { get; set; }
            public ushort TotalSeconds { get; set; }
            public float HourlyRate { get; set; }
            public float TotalFees { get; set; }

            public PlayCompletedEventArgs(string TimeText, ushort TotalSeconds, float HourlyRate, float TotalFees)
            {
                this.TimeText = TimeText;
                this.TotalSeconds = TotalSeconds;
                this.HourlyRate = HourlyRate;
                this.TotalFees = TotalFees;
            }
        }

        public event EventHandler<PlayCompletedEventArgs> PlayCompleted;

        public void OnPlayCompleted(string TimeText, ushort TotalSeconds, float HourlyRate, float TotalFees)
        {
            PlayCompleted?.Invoke(this, new PlayCompletedEventArgs(TimeText, TotalSeconds, HourlyRate, TotalFees));
        }

        [Category("Pool Configs"),
        Description("Hourly Rate")]

        public float HoulyRate
        {
            get
            {
                return _HourlyRate;
            }

            set
            {
                _HourlyRate = value;
            }
        }

        [Category("Pool Configs"),
        Description("Table Player")]

        public string TablePlayer
        {
            get
            {
                return _TablePlayer;
            }

            set
            {
                _TablePlayer = value;
                lblPlayer.Text = _TablePlayer;
            }
        }

        [Category("Pool Configs"),
        Description("Table Title")]

        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }

            set
            {
                _TableTitle = value;
                gbTable.Text = _TableTitle;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if(btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                PoolTimer.Start();
                gbTable.ForeColor = Color.Red;
            }

            else
            {
                btnStartStop.Text = "Start";
                PoolTimer.Stop();
                gbTable.ForeColor = Color.Yellow;
            }
        }

        private void PoolTimer_Tick(object sender, EventArgs e)
        {
            _TotalSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(_TotalSeconds);
            lblTime.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            PoolTimer.Stop();
            _TotalFees = ((float)_TotalSeconds / 60f / 60f) * _HourlyRate;
            OnPlayCompleted(lblTime.Text, _TotalSeconds, _HourlyRate, _TotalFees);
            gbTable.Text = _TableTitle;
            lblPlayer.Text = _TablePlayer;
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _TotalSeconds = 0;
            gbTable.ForeColor = Color.White;
        }

        private void ctrlPool_Load(object sender, EventArgs e)
        {
            lblTime.Text = "00:00:00";
            gbTable.Text = _TableTitle;
            lblPlayer.Text = _TablePlayer;
        }
    }
}