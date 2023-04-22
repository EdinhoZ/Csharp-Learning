
namespace Misturador_de_Cores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRGB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelb = new System.Windows.Forms.Label();
            this.trackBarb = new System.Windows.Forms.TrackBar();
            this.labelg = new System.Windows.Forms.Label();
            this.trackBarg = new System.Windows.Forms.TrackBar();
            this.labelr = new System.Windows.Forms.Label();
            this.trackBarr = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelcorhexa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRGB.Location = new System.Drawing.Point(42, 16);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(20, 24);
            this.labelRGB.TabIndex = 4;
            this.labelRGB.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelb);
            this.groupBox1.Controls.Add(this.trackBarb);
            this.groupBox1.Controls.Add(this.labelg);
            this.groupBox1.Controls.Add(this.trackBarg);
            this.groupBox1.Controls.Add(this.labelr);
            this.groupBox1.Controls.Add(this.trackBarr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha a cor:";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelb.Location = new System.Drawing.Point(362, 150);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(0, 24);
            this.labelb.TabIndex = 11;
            // 
            // trackBarb
            // 
            this.trackBarb.Location = new System.Drawing.Point(163, 150);
            this.trackBarb.Maximum = 255;
            this.trackBarb.Name = "trackBarb";
            this.trackBarb.Size = new System.Drawing.Size(167, 45);
            this.trackBarb.TabIndex = 2;
            this.trackBarb.Scroll += new System.EventHandler(this.trackBarb_Scroll);
            // 
            // labelg
            // 
            this.labelg.AutoSize = true;
            this.labelg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelg.Location = new System.Drawing.Point(362, 91);
            this.labelg.Name = "labelg";
            this.labelg.Size = new System.Drawing.Size(0, 24);
            this.labelg.TabIndex = 10;
            // 
            // trackBarg
            // 
            this.trackBarg.Location = new System.Drawing.Point(163, 91);
            this.trackBarg.Maximum = 255;
            this.trackBarg.Name = "trackBarg";
            this.trackBarg.Size = new System.Drawing.Size(167, 45);
            this.trackBarg.TabIndex = 1;
            this.trackBarg.Scroll += new System.EventHandler(this.trackBarg_Scroll);
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelr.Location = new System.Drawing.Point(362, 29);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(0, 24);
            this.labelr.TabIndex = 9;
            // 
            // trackBarr
            // 
            this.trackBarr.Location = new System.Drawing.Point(163, 29);
            this.trackBarr.Maximum = 255;
            this.trackBarr.Name = "trackBarr";
            this.trackBarr.Size = new System.Drawing.Size(167, 45);
            this.trackBarr.TabIndex = 0;
            this.trackBarr.Scroll += new System.EventHandler(this.trackBarr_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelcorhexa);
            this.groupBox2.Controls.Add(this.labelRGB);
            this.groupBox2.Location = new System.Drawing.Point(19, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // labelcorhexa
            // 
            this.labelcorhexa.AutoSize = true;
            this.labelcorhexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelcorhexa.Location = new System.Drawing.Point(310, 16);
            this.labelcorhexa.Name = "labelcorhexa";
            this.labelcorhexa.Size = new System.Drawing.Size(20, 24);
            this.labelcorhexa.TabIndex = 5;
            this.labelcorhexa.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(483, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 378);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(298, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MisturadorCores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarb;
        private System.Windows.Forms.TrackBar trackBarg;
        private System.Windows.Forms.TrackBar trackBarr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Label labelg;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labelcorhexa;
    }
}

