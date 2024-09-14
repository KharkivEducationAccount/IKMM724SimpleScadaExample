namespace IKMM724aSimpleScadaExample
{
    public partial class Form1 : Form
    {
        int Capacity1, Capacity2;
        bool valve1closed, valve2closed;
        bool valve1released, valve2released;
        bool runAll, releaseAll;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load()
        {
            valve1closed = false;
            valve2closed = false;

            valve1released = false;
            valve2released = false;

            progressBar_Tank1.Value = 0;
            progressBar_Tank2.Value = 0;

            Capacity1 = 0;
            Capacity2 = 0;

            tank1_Value.Text = "0%";
            tank2_Value.Text = "0%";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void playSound()
        {
            var simpleSound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\wavlibrary.wav");
            simpleSound.Play();
        }

        private void playSoundFull()
        {
            var simpleSound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\full.wav");
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
                valve1closed = false;
                valve2closed = false;

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
            valve1closed = false;
            bValveTank1.BackgroundImage = Properties.Resources.closed;

            valve1released = !valve1released;

            if (!valve1released)
            {
                tClock1.Stop();
                playSound();
            }
            else
            {
                tClock1.Start();
            }
        }

        private void bValveTank1_Click(object sender, EventArgs e)
        {
            valve1released = false;

            valve1closed = !valve1closed;

            if (valve1closed)
            {
                bValveTank1.BackgroundImage = Properties.Resources.open;
                tClock1.Start();
            }
            else
            {
                bValveTank1.BackgroundImage = Properties.Resources.closed;
                tClock1.Stop();
            }

        }

        private void tClock1_Tick(object sender, EventArgs e)
        {
            if (valve1closed)
            {
                if (Capacity1 < 100)
                {
                    progressBar_Tank1.Increment(10);
                    tank1_Value.Text = (Capacity1 + 10).ToString() + "%";
                    tank1_Value.Refresh();

                    Capacity1 += 10;
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    tClock1.Stop();
                }
            }
            else
            {
                if (Capacity1 <= 100)
                {
                    if (progressBar_Tank1.Value == 0)
                    {
                        progressBar_Tank1.Value = 0;
                    }
                    else
                    {
                        progressBar_Tank1.Value -= 10;

                        tank1_Value.Text = (Capacity1 - 10).ToString() + "%";
                        tank1_Value.Refresh();
                        Capacity1 -= 10;
                        System.Threading.Thread.Sleep(0);
                    }
                }
                if (Capacity1 == 0)
                {
                    progressBar_Tank1.Value = 0;

                    tClock1.Stop();
                    bValveTank1.BackgroundImage = Properties.Resources.closed;
                    playSound();
                }
            }

            if (progressBar_Tank1.Value > 99)
            {
                bValveTank1.BackgroundImage = Properties.Resources.open;
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Form1_Load();
            bToggle.BackgroundImage = Properties.Resources.offAll;
            bValveTank1.BackgroundImage = Properties.Resources.closed;
            bValveTank2.BackgroundImage = Properties.Resources.closed;
        }
    }
}
