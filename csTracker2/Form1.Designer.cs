namespace csTracker2
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
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibProcessed = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrPlay = new System.Windows.Forms.Button();
            this.txtXYRadius = new System.Windows.Forms.TextBox();
            this.tbMinH = new System.Windows.Forms.TrackBar();
            this.tbMinS = new System.Windows.Forms.TrackBar();
            this.tbMinV = new System.Windows.Forms.TrackBar();
            this.tbMaxH = new System.Windows.Forms.TrackBar();
            this.tbMaxS = new System.Windows.Forms.TrackBar();
            this.tbMaxV = new System.Windows.Forms.TrackBar();
            this.tbMinRadius = new System.Windows.Forms.TrackBar();
            this.tbMaxRadius = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblminH = new System.Windows.Forms.Label();
            this.lblminS = new System.Windows.Forms.Label();
            this.lblminV = new System.Windows.Forms.Label();
            this.lblmaxH = new System.Windows.Forms.Label();
            this.lblMaxS = new System.Windows.Forms.Label();
            this.lblMaxV = new System.Windows.Forms.Label();
            this.tbCanny = new System.Windows.Forms.TrackBar();
            this.lblCanny = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAccu = new System.Windows.Forms.TrackBar();
            this.lblAccum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPortNr = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCanny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccu)).BeginInit();
            this.SuspendLayout();
            // 
            // ibOriginal
            // 
            this.ibOriginal.Location = new System.Drawing.Point(0, 0);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(640, 480);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibProcessed
            // 
            this.ibProcessed.Location = new System.Drawing.Point(685, 0);
            this.ibProcessed.Name = "ibProcessed";
            this.ibProcessed.Size = new System.Drawing.Size(640, 480);
            this.ibProcessed.TabIndex = 2;
            this.ibProcessed.TabStop = false;
            // 
            // btnPauseOrPlay
            // 
            this.btnPauseOrPlay.Location = new System.Drawing.Point(12, 486);
            this.btnPauseOrPlay.Name = "btnPauseOrPlay";
            this.btnPauseOrPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPauseOrPlay.TabIndex = 3;
            this.btnPauseOrPlay.Text = "Pause";
            this.btnPauseOrPlay.UseVisualStyleBackColor = true;
            this.btnPauseOrPlay.Click += new System.EventHandler(this.btnPauseOrPlay_Click);
            // 
            // txtXYRadius
            // 
            this.txtXYRadius.Location = new System.Drawing.Point(447, 486);
            this.txtXYRadius.Multiline = true;
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.ReadOnly = true;
            this.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXYRadius.Size = new System.Drawing.Size(878, 57);
            this.txtXYRadius.TabIndex = 4;
            // 
            // tbMinH
            // 
            this.tbMinH.Location = new System.Drawing.Point(53, 549);
            this.tbMinH.Maximum = 256;
            this.tbMinH.Name = "tbMinH";
            this.tbMinH.Size = new System.Drawing.Size(506, 42);
            this.tbMinH.TabIndex = 5;
            this.tbMinH.Value = 36;
            this.tbMinH.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbMinS
            // 
            this.tbMinS.Location = new System.Drawing.Point(53, 585);
            this.tbMinS.Maximum = 256;
            this.tbMinS.Name = "tbMinS";
            this.tbMinS.Size = new System.Drawing.Size(506, 42);
            this.tbMinS.TabIndex = 6;
            this.tbMinS.Value = 35;
            this.tbMinS.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tbMinV
            // 
            this.tbMinV.Location = new System.Drawing.Point(55, 624);
            this.tbMinV.Maximum = 256;
            this.tbMinV.Name = "tbMinV";
            this.tbMinV.Size = new System.Drawing.Size(504, 42);
            this.tbMinV.TabIndex = 6;
            this.tbMinV.Value = 71;
            this.tbMinV.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // tbMaxH
            // 
            this.tbMaxH.Location = new System.Drawing.Point(659, 549);
            this.tbMaxH.Maximum = 180;
            this.tbMaxH.Name = "tbMaxH";
            this.tbMaxH.Size = new System.Drawing.Size(616, 42);
            this.tbMaxH.TabIndex = 5;
            this.tbMaxH.Value = 115;
            this.tbMaxH.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // tbMaxS
            // 
            this.tbMaxS.Location = new System.Drawing.Point(659, 585);
            this.tbMaxS.Maximum = 255;
            this.tbMaxS.Name = "tbMaxS";
            this.tbMaxS.Size = new System.Drawing.Size(616, 42);
            this.tbMaxS.TabIndex = 6;
            this.tbMaxS.Value = 255;
            this.tbMaxS.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // tbMaxV
            // 
            this.tbMaxV.Location = new System.Drawing.Point(659, 624);
            this.tbMaxV.Maximum = 255;
            this.tbMaxV.Name = "tbMaxV";
            this.tbMaxV.Size = new System.Drawing.Size(616, 42);
            this.tbMaxV.TabIndex = 6;
            this.tbMaxV.Value = 164;
            this.tbMaxV.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // tbMinRadius
            // 
            this.tbMinRadius.Location = new System.Drawing.Point(55, 668);
            this.tbMinRadius.Name = "tbMinRadius";
            this.tbMinRadius.Size = new System.Drawing.Size(504, 42);
            this.tbMinRadius.TabIndex = 7;
            this.tbMinRadius.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // tbMaxRadius
            // 
            this.tbMaxRadius.Location = new System.Drawing.Point(659, 668);
            this.tbMaxRadius.Maximum = 400;
            this.tbMaxRadius.Minimum = 1;
            this.tbMaxRadius.Name = "tbMaxRadius";
            this.tbMaxRadius.Size = new System.Drawing.Size(616, 42);
            this.tbMaxRadius.TabIndex = 8;
            this.tbMaxRadius.Value = 1;
            this.tbMaxRadius.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "H Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "S Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "V Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "H Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "S Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "V Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "min Radius";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "max Radius";
            // 
            // lblminH
            // 
            this.lblminH.AutoSize = true;
            this.lblminH.Location = new System.Drawing.Point(571, 558);
            this.lblminH.Name = "lblminH";
            this.lblminH.Size = new System.Drawing.Size(0, 13);
            this.lblminH.TabIndex = 9;
            // 
            // lblminS
            // 
            this.lblminS.AutoSize = true;
            this.lblminS.Location = new System.Drawing.Point(572, 594);
            this.lblminS.Name = "lblminS";
            this.lblminS.Size = new System.Drawing.Size(0, 13);
            this.lblminS.TabIndex = 9;
            // 
            // lblminV
            // 
            this.lblminV.AutoSize = true;
            this.lblminV.Location = new System.Drawing.Point(574, 630);
            this.lblminV.Name = "lblminV";
            this.lblminV.Size = new System.Drawing.Size(0, 13);
            this.lblminV.TabIndex = 9;
            // 
            // lblmaxH
            // 
            this.lblmaxH.AutoSize = true;
            this.lblmaxH.Location = new System.Drawing.Point(1281, 558);
            this.lblmaxH.Name = "lblmaxH";
            this.lblmaxH.Size = new System.Drawing.Size(0, 13);
            this.lblmaxH.TabIndex = 9;
            // 
            // lblMaxS
            // 
            this.lblMaxS.AutoSize = true;
            this.lblMaxS.Location = new System.Drawing.Point(1282, 594);
            this.lblMaxS.Name = "lblMaxS";
            this.lblMaxS.Size = new System.Drawing.Size(0, 13);
            this.lblMaxS.TabIndex = 9;
            // 
            // lblMaxV
            // 
            this.lblMaxV.AutoSize = true;
            this.lblMaxV.Location = new System.Drawing.Point(1284, 630);
            this.lblMaxV.Name = "lblMaxV";
            this.lblMaxV.Size = new System.Drawing.Size(0, 13);
            this.lblMaxV.TabIndex = 9;
            // 
            // tbCanny
            // 
            this.tbCanny.Location = new System.Drawing.Point(55, 716);
            this.tbCanny.Maximum = 256;
            this.tbCanny.Minimum = 1;
            this.tbCanny.Name = "tbCanny";
            this.tbCanny.Size = new System.Drawing.Size(504, 42);
            this.tbCanny.TabIndex = 6;
            this.tbCanny.Value = 50;
            this.tbCanny.Scroll += new System.EventHandler(this.tbCanny_Scroll);
            // 
            // lblCanny
            // 
            this.lblCanny.AutoSize = true;
            this.lblCanny.Location = new System.Drawing.Point(574, 722);
            this.lblCanny.Name = "lblCanny";
            this.lblCanny.Size = new System.Drawing.Size(0, 13);
            this.lblCanny.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 722);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Canny";
            // 
            // tbAccu
            // 
            this.tbAccu.Location = new System.Drawing.Point(670, 716);
            this.tbAccu.Maximum = 256;
            this.tbAccu.Minimum = 1;
            this.tbAccu.Name = "tbAccu";
            this.tbAccu.Size = new System.Drawing.Size(504, 42);
            this.tbAccu.TabIndex = 6;
            this.tbAccu.Value = 100;
            this.tbAccu.Scroll += new System.EventHandler(this.tbAccu_Scroll);
            // 
            // lblAccum
            // 
            this.lblAccum.AutoSize = true;
            this.lblAccum.Location = new System.Drawing.Point(1189, 722);
            this.lblAccum.Name = "lblAccum";
            this.lblAccum.Size = new System.Drawing.Size(0, 13);
            this.lblAccum.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(627, 722);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "accum";
            // 
            // txtPortNr
            // 
            this.txtPortNr.Location = new System.Drawing.Point(298, 488);
            this.txtPortNr.Name = "txtPortNr";
            this.txtPortNr.Size = new System.Drawing.Size(100, 20);
            this.txtPortNr.TabIndex = 10;
            this.txtPortNr.Text = "29129";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(135, 489);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 11;
            this.txtIp.Text = "127.0.0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ip : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "port nr";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(13, 516);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 745);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtPortNr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMaxV);
            this.Controls.Add(this.lblAccum);
            this.Controls.Add(this.lblCanny);
            this.Controls.Add(this.lblminV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaxS);
            this.Controls.Add(this.lblminS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmaxH);
            this.Controls.Add(this.lblminH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxRadius);
            this.Controls.Add(this.tbMinRadius);
            this.Controls.Add(this.tbMaxV);
            this.Controls.Add(this.tbAccu);
            this.Controls.Add(this.tbCanny);
            this.Controls.Add(this.tbMinV);
            this.Controls.Add(this.tbMaxS);
            this.Controls.Add(this.tbMinS);
            this.Controls.Add(this.tbMaxH);
            this.Controls.Add(this.tbMinH);
            this.Controls.Add(this.txtXYRadius);
            this.Controls.Add(this.btnPauseOrPlay);
            this.Controls.Add(this.ibProcessed);
            this.Controls.Add(this.ibOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCanny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibProcessed;
        private System.Windows.Forms.Button btnPauseOrPlay;
        private System.Windows.Forms.TextBox txtXYRadius;
        private System.Windows.Forms.TrackBar tbMinH;
        private System.Windows.Forms.TrackBar tbMinS;
        private System.Windows.Forms.TrackBar tbMinV;
        private System.Windows.Forms.TrackBar tbMaxH;
        private System.Windows.Forms.TrackBar tbMaxS;
        private System.Windows.Forms.TrackBar tbMaxV;
        private System.Windows.Forms.TrackBar tbMinRadius;
        private System.Windows.Forms.TrackBar tbMaxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblminH;
        private System.Windows.Forms.Label lblminS;
        private System.Windows.Forms.Label lblminV;
        private System.Windows.Forms.Label lblmaxH;
        private System.Windows.Forms.Label lblMaxS;
        private System.Windows.Forms.Label lblMaxV;
        private System.Windows.Forms.TrackBar tbCanny;
        private System.Windows.Forms.Label lblCanny;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbAccu;
        private System.Windows.Forms.Label lblAccum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPortNr;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSend;
    }
}

