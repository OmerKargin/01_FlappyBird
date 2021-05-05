
namespace _01_FlappyBird
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.altkolon = new System.Windows.Forms.PictureBox();
            this.ustkolon = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altkolon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustkolon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "SKOR : 0";
            // 
            // flappy
            // 
            this.flappy.Image = global::_01_FlappyBird.Properties.Resources.bird;
            this.flappy.Location = new System.Drawing.Point(157, 171);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(70, 48);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 3;
            this.flappy.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::_01_FlappyBird.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-1, 455);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(980, 62);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 2;
            this.zemin.TabStop = false;
            // 
            // altkolon
            // 
            this.altkolon.Image = global::_01_FlappyBird.Properties.Resources.pipe;
            this.altkolon.Location = new System.Drawing.Point(522, 282);
            this.altkolon.Name = "altkolon";
            this.altkolon.Size = new System.Drawing.Size(92, 178);
            this.altkolon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altkolon.TabIndex = 1;
            this.altkolon.TabStop = false;
            // 
            // ustkolon
            // 
            this.ustkolon.Image = global::_01_FlappyBird.Properties.Resources.pipedown;
            this.ustkolon.Location = new System.Drawing.Point(613, -1);
            this.ustkolon.Name = "ustkolon";
            this.ustkolon.Size = new System.Drawing.Size(93, 142);
            this.ustkolon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustkolon.TabIndex = 0;
            this.ustkolon.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(978, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.altkolon);
            this.Controls.Add(this.ustkolon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altkolon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustkolon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ustkolon;
        private System.Windows.Forms.PictureBox altkolon;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}

