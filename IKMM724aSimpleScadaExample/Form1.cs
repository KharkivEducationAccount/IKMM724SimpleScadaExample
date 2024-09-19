using IKMM724aSimpleScadaExample.Entities;

namespace IKMM724aSimpleScadaExample
{
    public partial class Form1 : Form
    {
        Tank tank1, tank2;
        bool runAll, releaseAll;

        public Form1()
        {
            InitializeComponent();
            tank1 = new Tank(progressBar_Tank1, tank1_Value, bValveTank1, tClock1);
            tank2 = new Tank(progressBar_Tank2, tank2_Value, bValveTank2, tClock2);
        }

        private void Form1_Load()
        {
            InitializeTanks();
            tank1 = new Tank(progressBar_Tank1, tank1_Value, bValveTank1, tClock1);
            tank2 = new Tank(progressBar_Tank2, tank2_Value, bValveTank2, tClock2);
        }


        private void InitializeTanks()
        {
            progressBar_Tank1.Value = 0;
            progressBar_Tank2.Value = 0;

            tank1_Value.Text = "0%";
            tank2_Value.Text = "0%";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PlaySound(string soundFile)
        {
            var simpleSound = new System.Media.SoundPlayer(Environment.CurrentDirectory + soundFile);
            simpleSound.Play();
        }

        private void bReleaseAll_Click(object sender, EventArgs e)
        {
            releaseAll = !releaseAll;

            bReleaseAll.BackgroundImage = Properties.Resources.releaseall;
            bToggle.BackgroundImage = Properties.Resources.offAll;
            bReleaseTank1.PerformClick();
            bValveTank1.BackgroundImage = Properties.Resources.closed;
            bReleaseTank2.PerformClick();
            bValveTank2.BackgroundImage = Properties.Resources.closed;

        }

        private void bToggle_Click(object sender, EventArgs e)
        {
            runAll = !runAll;

            if (runAll)
            {
                bToggle.BackgroundImage = Properties.Resources.onAll;
                bValveTank1.PerformClick();
                bValveTank2.PerformClick();
            }
            else
            {
                bToggle.BackgroundImage = Properties.Resources.offAll;

                tClock1.Stop();
                bValveTank1.BackgroundImage = Properties.Resources.closed;

                tClock2.Stop();
                bValveTank2.BackgroundImage = Properties.Resources.closed;
            }
        }

        private void bReleaseTank1_Click(object sender, EventArgs e)
        {
            if (!tank1.IsValveClosed)
            {
                tank1.CloseValve();
            }

            if (tank1.Capacity > 0)
            {
                tClock1.Start();
            }
        }

        private void bValveTank1_Click(object sender, EventArgs e)
        {
            tank1.ToggleValve();
        }

        private void tClock1_Tick(object sender, EventArgs e)
        {
            if (!tank1.IsValveClosed)
            {
                tank1.FillTank();
            }
            else
            {
                tank1.DrainTank();

                if (tank1.Capacity == 0)
                {
                    tClock1.Stop();
                    PlaySound(SoundConstants.SoundFilePath);
                }
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Form1_Load();
            bToggle.BackgroundImage = Properties.Resources.offAll;
            bValveTank1.BackgroundImage = Properties.Resources.closed;
            bValveTank2.BackgroundImage = Properties.Resources.closed;
        }

        private void bValveTank2_Click(object sender, EventArgs e)
        {
            tank2.ToggleValve();
        }

        private void tClock2_Tick(object sender, EventArgs e)
        {
            if (!tank2.IsValveClosed)
            {
                tank2.FillTank();
            }
            else
            {
                tank2.DrainTank();

                if (tank2.Capacity == 0)
                {
                    tClock2.Stop();
                    PlaySound(SoundConstants.SoundFilePath);
                }
            }
        }

        private void bReleaseTank2_Click(object sender, EventArgs e)
        {
            if (!tank2.IsValveClosed)
            {
                tank2.CloseValve();
            }

            if (tank2.Capacity > 0)
            {
                tClock2.Start();
            }
        }
    }
}
