using NETFLiX_PRO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NETFLiX_PRO
{
    public class AutoExit : Form
    {
        private static Timer _timer;
        public static Timer Timer
        {
            get
            {
                return _timer;
            }
            set
            {
                if (_timer != null)
                {
                    _timer.Tick -= Timer_Tick;
                }
                _timer = value;
                if (_timer != null)
                {
                    _timer.Tick += Timer_Tick;
                }
            }
        }
        public event EventHandler UserActivity;

        public AutoExit()
        {
            KeyPreview = true;
            FormClosed += ObservedForm_FormClosed;
            MouseMove += ObservedForm_MouseMove;
            KeyDown += ObservedForm_KeyDown;
        }
        
        protected virtual void OnUserActivity(EventArgs e)
        {
            UserActivity?.Invoke(this, e);
        }

        public void SetTimeOut()
        {  
            _timer = new Timer
            {
                Interval = (5 * 60 * 1000)
            };
            Application.Idle += Application_Idle;
            _timer.Tick += new EventHandler(Timer_Tick);
        }

        private void ObservedForm_KeyDown(object sender, KeyEventArgs e)
        {
            OnUserActivity(e);
        }

        private void ObservedForm_MouseMove(object sender, MouseEventArgs e)
        {
            OnUserActivity(e);
        }

        private void ObservedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed -= ObservedForm_FormClosed;
            MouseMove -= ObservedForm_MouseMove;
            KeyDown -= ObservedForm_KeyDown;
        }

        private static void Application_Idle(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Start();
        }


        private static void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            Application.Idle -= Application_Idle;
            MessageBox.Show("Tétlenség miatt a program kilép");
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AutoExit
            // 
            this.ClientSize = new System.Drawing.Size(634, 446);
            this.Name = "AutoExit";
            this.ResumeLayout(false);

        }
    }
}
