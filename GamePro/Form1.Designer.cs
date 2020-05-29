namespace GamePro
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Object = new System.Windows.Forms.PictureBox();
            this.enemyObj4 = new System.Windows.Forms.PictureBox();
            this.enemyObj2 = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.enemyObj3 = new System.Windows.Forms.PictureBox();
            this.enemyObj1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(186, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox2.Location = new System.Drawing.Point(186, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 129);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox3.Location = new System.Drawing.Point(186, 313);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 129);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(369, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 429);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox5.Location = new System.Drawing.Point(1, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 430);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Object
            // 
            this.Object.Image = ((System.Drawing.Image)(resources.GetObject("Object.Image")));
            this.Object.Location = new System.Drawing.Point(218, 332);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(17, 34);
            this.Object.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Object.TabIndex = 5;
            this.Object.TabStop = false;
            // 
            // enemyObj4
            // 
            this.enemyObj4.Image = ((System.Drawing.Image)(resources.GetObject("enemyObj4.Image")));
            this.enemyObj4.Location = new System.Drawing.Point(36, 26);
            this.enemyObj4.Name = "enemyObj4";
            this.enemyObj4.Size = new System.Drawing.Size(25, 33);
            this.enemyObj4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyObj4.TabIndex = 7;
            this.enemyObj4.TabStop = false;
            // 
            // enemyObj2
            // 
            this.enemyObj2.Image = ((System.Drawing.Image)(resources.GetObject("enemyObj2.Image")));
            this.enemyObj2.Location = new System.Drawing.Point(317, 74);
            this.enemyObj2.Name = "enemyObj2";
            this.enemyObj2.Size = new System.Drawing.Size(19, 26);
            this.enemyObj2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyObj2.TabIndex = 8;
            this.enemyObj2.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(31, 145);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(305, 38);
            this.lblGameOver.TabIndex = 10;
            this.lblGameOver.Text = "BhaloBasha Starts";
            this.lblGameOver.Visible = false;
            // 
            // enemyObj3
            // 
            this.enemyObj3.Image = ((System.Drawing.Image)(resources.GetObject("enemyObj3.Image")));
            this.enemyObj3.Location = new System.Drawing.Point(246, 26);
            this.enemyObj3.Name = "enemyObj3";
            this.enemyObj3.Size = new System.Drawing.Size(25, 33);
            this.enemyObj3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyObj3.TabIndex = 9;
            this.enemyObj3.TabStop = false;
            // 
            // enemyObj1
            // 
            this.enemyObj1.Image = ((System.Drawing.Image)(resources.GetObject("enemyObj1.Image")));
            this.enemyObj1.Location = new System.Drawing.Point(134, 34);
            this.enemyObj1.Name = "enemyObj1";
            this.enemyObj1.Size = new System.Drawing.Size(24, 32);
            this.enemyObj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyObj1.TabIndex = 6;
            this.enemyObj1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.enemyObj3);
            this.Controls.Add(this.enemyObj2);
            this.Controls.Add(this.enemyObj4);
            this.Controls.Add(this.enemyObj1);
            this.Controls.Add(this.Object);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyObj1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Object;
        private System.Windows.Forms.PictureBox enemyObj4;
        private System.Windows.Forms.PictureBox enemyObj2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox enemyObj3;
        private System.Windows.Forms.PictureBox enemyObj1;
    }
}

