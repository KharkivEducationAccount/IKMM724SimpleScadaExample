namespace IKMM724aSimpleScadaExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            bValveTank1 = new Button();
            bValveTank2 = new Button();
            bReleaseTank1 = new Button();
            bReleaseTank2 = new Button();
            tClock1 = new System.Windows.Forms.Timer(components);
            tClock2 = new System.Windows.Forms.Timer(components);
            progressBar_Tank1 = new ProgressBar();
            progressBar_Tank2 = new ProgressBar();
            tank1_Value = new Label();
            label3 = new Label();
            label5 = new Label();
            tank2_Value = new Label();
            bToggle = new Button();
            bReset = new Button();
            bReleaseAll = new Button();
            bExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.tankox;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(279, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tankox;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(279, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 68);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.pipe1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(117, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 11);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.pipe1;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(117, 218);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(166, 11);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.pipe1;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(612, 99);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 11);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.pipe1;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(612, 218);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(72, 11);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.pipe2;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.ErrorImage = Properties.Resources.pipe2;
            pictureBox8.Location = new Point(680, 99);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(16, 209);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.pipe2;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.ErrorImage = Properties.Resources.pipe2;
            pictureBox9.Location = new Point(117, 99);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(16, 209);
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.pipe1;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(12, 293);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(672, 15);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // bValveTank1
            // 
            bValveTank1.BackgroundImage = Properties.Resources.closed;
            bValveTank1.BackgroundImageLayout = ImageLayout.Stretch;
            bValveTank1.Location = new Point(533, 75);
            bValveTank1.Name = "bValveTank1";
            bValveTank1.Size = new Size(83, 58);
            bValveTank1.TabIndex = 10;
            bValveTank1.UseVisualStyleBackColor = true;
            bValveTank1.Click += bValveTank1_Click;
            // 
            // bValveTank2
            // 
            bValveTank2.BackgroundImage = Properties.Resources.closed;
            bValveTank2.BackgroundImageLayout = ImageLayout.Stretch;
            bValveTank2.Location = new Point(533, 195);
            bValveTank2.Name = "bValveTank2";
            bValveTank2.Size = new Size(83, 58);
            bValveTank2.TabIndex = 11;
            bValveTank2.UseVisualStyleBackColor = true;
            // 
            // bReleaseTank1
            // 
            bReleaseTank1.BackgroundImage = Properties.Resources.arrow1;
            bReleaseTank1.BackgroundImageLayout = ImageLayout.Stretch;
            bReleaseTank1.Location = new Point(30, 73);
            bReleaseTank1.Name = "bReleaseTank1";
            bReleaseTank1.Size = new Size(69, 63);
            bReleaseTank1.TabIndex = 12;
            bReleaseTank1.UseVisualStyleBackColor = true;
            bReleaseTank1.Click += bReleaseTank1_Click;
            // 
            // bReleaseTank2
            // 
            bReleaseTank2.BackgroundImage = Properties.Resources.arrow1;
            bReleaseTank2.BackgroundImageLayout = ImageLayout.Stretch;
            bReleaseTank2.Location = new Point(30, 190);
            bReleaseTank2.Name = "bReleaseTank2";
            bReleaseTank2.Size = new Size(69, 63);
            bReleaseTank2.TabIndex = 13;
            bReleaseTank2.UseVisualStyleBackColor = true;
            // 
            // tClock1
            // 
            tClock1.Tick += tClock1_Tick;
            // 
            // progressBar_Tank1
            // 
            progressBar_Tank1.Location = new Point(279, 70);
            progressBar_Tank1.Name = "progressBar_Tank1";
            progressBar_Tank1.Size = new Size(182, 68);
            progressBar_Tank1.TabIndex = 14;
            // 
            // progressBar_Tank2
            // 
            progressBar_Tank2.Location = new Point(279, 189);
            progressBar_Tank2.Name = "progressBar_Tank2";
            progressBar_Tank2.Size = new Size(182, 68);
            progressBar_Tank2.TabIndex = 15;
            // 
            // tank1_Value
            // 
            tank1_Value.AutoSize = true;
            tank1_Value.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tank1_Value.ForeColor = Color.Red;
            tank1_Value.Location = new Point(363, 20);
            tank1_Value.Name = "tank1_Value";
            tank1_Value.Size = new Size(54, 32);
            tank1_Value.TabIndex = 16;
            tank1_Value.Text = "0 %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(470, 20);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 18;
            label3.Text = "Tank 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(470, 154);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 20;
            label5.Text = "Tank 2";
            // 
            // tank2_Value
            // 
            tank2_Value.AutoSize = true;
            tank2_Value.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tank2_Value.ForeColor = Color.Red;
            tank2_Value.Location = new Point(363, 154);
            tank2_Value.Name = "tank2_Value";
            tank2_Value.Size = new Size(54, 32);
            tank2_Value.TabIndex = 21;
            tank2_Value.Text = "0 %";
            // 
            // bToggle
            // 
            bToggle.BackgroundImage = Properties.Resources.offAll;
            bToggle.BackgroundImageLayout = ImageLayout.Stretch;
            bToggle.Location = new Point(117, 314);
            bToggle.Name = "bToggle";
            bToggle.Size = new Size(89, 63);
            bToggle.TabIndex = 22;
            bToggle.UseVisualStyleBackColor = true;
            bToggle.Click += bToggle_Click;
            // 
            // bReset
            // 
            bReset.BackgroundImage = Properties.Resources.reset;
            bReset.BackgroundImageLayout = ImageLayout.Stretch;
            bReset.Location = new Point(279, 314);
            bReset.Name = "bReset";
            bReset.Size = new Size(126, 63);
            bReset.TabIndex = 23;
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // bReleaseAll
            // 
            bReleaseAll.BackgroundImage = Properties.Resources.releaseall;
            bReleaseAll.BackgroundImageLayout = ImageLayout.Stretch;
            bReleaseAll.Location = new Point(470, 309);
            bReleaseAll.Name = "bReleaseAll";
            bReleaseAll.Size = new Size(68, 73);
            bReleaseAll.TabIndex = 24;
            bReleaseAll.UseVisualStyleBackColor = true;
            bReleaseAll.Click += bReleaseAll_Click;
            // 
            // bExit
            // 
            bExit.BackgroundImage = Properties.Resources.Exit;
            bExit.BackgroundImageLayout = ImageLayout.Stretch;
            bExit.Location = new Point(740, 309);
            bExit.Name = "bExit";
            bExit.Size = new Size(68, 73);
            bExit.TabIndex = 25;
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 389);
            Controls.Add(bExit);
            Controls.Add(bReleaseAll);
            Controls.Add(bReset);
            Controls.Add(bToggle);
            Controls.Add(tank2_Value);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(tank1_Value);
            Controls.Add(progressBar_Tank2);
            Controls.Add(progressBar_Tank1);
            Controls.Add(bReleaseTank2);
            Controls.Add(bReleaseTank1);
            Controls.Add(bValveTank2);
            Controls.Add(bValveTank1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private Button bValveTank1;
        private Button bValveTank2;
        private Button bReleaseTank1;
        private Button bReleaseTank2;
        private System.Windows.Forms.Timer tClock1;
        private System.Windows.Forms.Timer tClock2;
        private ProgressBar progressBar_Tank1;
        private ProgressBar progressBar_Tank2;
        private Label tank1_Value;
        private Label label3;
        private Label label5;
        private Label tank2_Value;
        private Button bToggle;
        private Button bReset;
        private Button bReleaseAll;
        private Button bExit;
    }
}
