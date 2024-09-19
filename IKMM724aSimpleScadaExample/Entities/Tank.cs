using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMM724aSimpleScadaExample.Entities
{
    public class Tank
    {
        public int Capacity { get; set; }
        public bool IsValveClosed { get; set; }

        private ProgressBar progressBar;
        private Label valueLabel;
        private Button valveButton;
        private System.Windows.Forms.Timer tankTimer;

        public Tank(ProgressBar progressBar,
            Label valueLabel,
            Button valveButton,
            System.Windows.Forms.Timer tankTimer)
        {
            this.progressBar = progressBar;
            this.valueLabel = valueLabel;
            this.valveButton = valveButton;
            this.tankTimer = tankTimer;
            Capacity = 0;
            IsValveClosed = true;
        }

        public void OpenValve()
        {
            if (IsValveClosed)
            {
                IsValveClosed = false;
                valveButton.BackgroundImage = Properties.Resources.open;
                tankTimer.Start();
            }
        }

        public void CloseValve()
        {
            if (!IsValveClosed)
            {
                IsValveClosed = true;
                valveButton.BackgroundImage = Properties.Resources.closed;
                tankTimer.Stop();
            }
        }

        public void ToggleValve()
        {
            if (IsValveClosed)
            {
                OpenValve();
            }
            else
            {
                CloseValve();
            }
        }

        public void FillTank()
        {
            if (Capacity < 100)
            {
                Capacity += 10;
                progressBar.Value = Capacity;
                valueLabel.Text = Capacity.ToString() + "%";
                valueLabel.Refresh();
            }
            else
            {
                StopFilling();
            }
        }
        public void DrainTank()
        {
            if (Capacity > 0)
            {
                Capacity -= 10;
                progressBar.Value = Capacity;
                valueLabel.Text = Capacity.ToString() + "%";
                valueLabel.Refresh();
            }
            else
            {
                StopDraining();
            }

        }

        private void StopDraining()
        {
            valveButton.BackgroundImage = Properties.Resources.closed;
            if (Capacity == 0)
            {
                tankTimer.Stop();
            }
        }

        private void StopFilling()
        {
            valveButton.BackgroundImage = Properties.Resources.closed;
            tankTimer.Stop();
        }
    }
}