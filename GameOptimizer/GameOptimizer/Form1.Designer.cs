namespace GameOptimizer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.picHome = new System.Windows.Forms.PictureBox();
			this.initial1 = new PCOptimizer.Initial();
			this.dados1 = new PCOptimizer.Dados();
			this.optimizer1 = new PCOptimizer.Optimizer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(838, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(348, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "PC Optimizer";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Aqua;
			this.panel5.Location = new System.Drawing.Point(-12, 444);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(888, 5);
			this.panel5.TabIndex = 22;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PCOptimizer.Properties.Resources.icons8_increase_96;
			this.pictureBox1.Location = new System.Drawing.Point(-7, 233);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::PCOptimizer.Properties.Resources.icons8_erase_filled_100;
			this.pictureBox4.Location = new System.Drawing.Point(-7, 277);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(65, 50);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 26;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// picHome
			// 
			this.picHome.Image = global::PCOptimizer.Properties.Resources.icons8_home_page_90;
			this.picHome.Location = new System.Drawing.Point(-9, 182);
			this.picHome.Name = "picHome";
			this.picHome.Size = new System.Drawing.Size(67, 50);
			this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picHome.TabIndex = 24;
			this.picHome.TabStop = false;
			this.picHome.Click += new System.EventHandler(this.picHome_Click);
			// 
			// initial1
			// 
			this.initial1.BackColor = System.Drawing.Color.White;
			this.initial1.ForeColor = System.Drawing.Color.Black;
			this.initial1.Location = new System.Drawing.Point(62, 56);
			this.initial1.Name = "initial1";
			this.initial1.Size = new System.Drawing.Size(750, 365);
			this.initial1.TabIndex = 23;
			// 
			// dados1
			// 
			this.dados1.BackColor = System.Drawing.Color.White;
			this.dados1.Location = new System.Drawing.Point(62, 65);
			this.dados1.Name = "dados1";
			this.dados1.Size = new System.Drawing.Size(750, 356);
			this.dados1.TabIndex = 21;
			this.dados1.Load += new System.EventHandler(this.dados1_Load);
			// 
			// optimizer1
			// 
			this.optimizer1.BackColor = System.Drawing.Color.White;
			this.optimizer1.Location = new System.Drawing.Point(63, 73);
			this.optimizer1.Name = "optimizer1";
			this.optimizer1.Size = new System.Drawing.Size(777, 348);
			this.optimizer1.TabIndex = 25;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(873, 469);
			this.ControlBox = false;
			this.Controls.Add(this.initial1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.picHome);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dados1);
			this.Controls.Add(this.optimizer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PC Optimizer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PCOptimizer.Dados dados1;
        private System.Windows.Forms.Panel panel5;
        private PCOptimizer.Initial initial1;
        private System.Windows.Forms.PictureBox picHome;
        private PCOptimizer.Optimizer optimizer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}

