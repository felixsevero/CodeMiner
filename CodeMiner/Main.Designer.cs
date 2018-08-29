namespace CodeMiner {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.pTop = new System.Windows.Forms.Panel();
			this.lTitle = new System.Windows.Forms.Label();
			this.fbCest = new CodeMiner.FlatButton();
			this.fbAbout = new CodeMiner.FlatButton();
			this.fbClose = new CodeMiner.FlatButton();
			this.pCenter = new System.Windows.Forms.Panel();
			this.tablessControl = new CodeMiner.TablessControl();
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.lAbout = new System.Windows.Forms.Label();
			this.lAbout2 = new System.Windows.Forms.Label();
			this.lAbout3 = new System.Windows.Forms.Label();
			this.lAbout1 = new System.Windows.Forms.Label();
			this.tpCest = new System.Windows.Forms.TabPage();
			this.lCest3 = new System.Windows.Forms.Label();
			this.lCest2 = new System.Windows.Forms.Label();
			this.lCest = new System.Windows.Forms.Label();
			this.lSave = new System.Windows.Forms.Label();
			this.tbSave = new System.Windows.Forms.TextBox();
			this.lSearch = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.fbMineCest = new CodeMiner.FlatButton();
			this.lCest1 = new System.Windows.Forms.Label();
			this.pTop.SuspendLayout();
			this.pCenter.SuspendLayout();
			this.tablessControl.SuspendLayout();
			this.tpAbout.SuspendLayout();
			this.tpCest.SuspendLayout();
			this.SuspendLayout();
			// 
			// pTop
			// 
			this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.pTop.Controls.Add(this.lTitle);
			this.pTop.Controls.Add(this.fbCest);
			this.pTop.Controls.Add(this.fbAbout);
			this.pTop.Controls.Add(this.fbClose);
			this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pTop.Location = new System.Drawing.Point(0, 0);
			this.pTop.Name = "pTop";
			this.pTop.Size = new System.Drawing.Size(800, 100);
			this.pTop.TabIndex = 0;
			// 
			// lTitle
			// 
			this.lTitle.AutoSize = true;
			this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.lTitle.Location = new System.Drawing.Point(338, 9);
			this.lTitle.Name = "lTitle";
			this.lTitle.Size = new System.Drawing.Size(124, 26);
			this.lTitle.TabIndex = 0;
			this.lTitle.Text = "Code Miner";
			// 
			// fbCest
			// 
			this.fbCest.BackColor = System.Drawing.Color.Gray;
			this.fbCest.FlatAppearance.BorderSize = 0;
			this.fbCest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbCest.ForeColor = System.Drawing.Color.White;
			this.fbCest.Location = new System.Drawing.Point(403, 54);
			this.fbCest.Name = "fbCest";
			this.fbCest.Size = new System.Drawing.Size(215, 40);
			this.fbCest.TabIndex = 3;
			this.fbCest.Text = "CEST";
			this.fbCest.UseVisualStyleBackColor = false;
			this.fbCest.Click += new System.EventHandler(this.fbCest_Click);
			// 
			// fbAbout
			// 
			this.fbAbout.BackColor = System.Drawing.Color.Gray;
			this.fbAbout.FlatAppearance.BorderSize = 0;
			this.fbAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbAbout.ForeColor = System.Drawing.Color.White;
			this.fbAbout.Location = new System.Drawing.Point(182, 54);
			this.fbAbout.Name = "fbAbout";
			this.fbAbout.Size = new System.Drawing.Size(215, 40);
			this.fbAbout.TabIndex = 2;
			this.fbAbout.Text = "Sobre";
			this.fbAbout.UseVisualStyleBackColor = false;
			this.fbAbout.Click += new System.EventHandler(this.fbAbout_Click);
			// 
			// fbClose
			// 
			this.fbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.fbClose.FlatAppearance.BorderSize = 0;
			this.fbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbClose.ForeColor = System.Drawing.Color.White;
			this.fbClose.Image = ((System.Drawing.Image)(resources.GetObject("fbClose.Image")));
			this.fbClose.Location = new System.Drawing.Point(748, 12);
			this.fbClose.Name = "fbClose";
			this.fbClose.Size = new System.Drawing.Size(40, 40);
			this.fbClose.TabIndex = 1;
			this.fbClose.UseVisualStyleBackColor = false;
			this.fbClose.Click += new System.EventHandler(this.fbClose_Click);
			// 
			// pCenter
			// 
			this.pCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.pCenter.Controls.Add(this.tablessControl);
			this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pCenter.Location = new System.Drawing.Point(0, 100);
			this.pCenter.Name = "pCenter";
			this.pCenter.Size = new System.Drawing.Size(800, 500);
			this.pCenter.TabIndex = 1;
			// 
			// tablessControl
			// 
			this.tablessControl.Controls.Add(this.tpAbout);
			this.tablessControl.Controls.Add(this.tpCest);
			this.tablessControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablessControl.Location = new System.Drawing.Point(0, 0);
			this.tablessControl.Name = "tablessControl";
			this.tablessControl.SelectedIndex = 0;
			this.tablessControl.Size = new System.Drawing.Size(800, 500);
			this.tablessControl.TabIndex = 0;
			// 
			// tpAbout
			// 
			this.tpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.tpAbout.Controls.Add(this.lAbout);
			this.tpAbout.Controls.Add(this.lAbout2);
			this.tpAbout.Controls.Add(this.lAbout3);
			this.tpAbout.Controls.Add(this.lAbout1);
			this.tpAbout.Location = new System.Drawing.Point(4, 29);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tpAbout.Size = new System.Drawing.Size(792, 467);
			this.tpAbout.TabIndex = 0;
			this.tpAbout.Text = "tpAbout";
			// 
			// lAbout
			// 
			this.lAbout.AutoSize = true;
			this.lAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lAbout.ForeColor = System.Drawing.Color.White;
			this.lAbout.Location = new System.Drawing.Point(8, 3);
			this.lAbout.Name = "lAbout";
			this.lAbout.Size = new System.Drawing.Size(102, 37);
			this.lAbout.TabIndex = 0;
			this.lAbout.Text = "Sobre";
			// 
			// lAbout2
			// 
			this.lAbout2.AutoSize = true;
			this.lAbout2.ForeColor = System.Drawing.Color.White;
			this.lAbout2.Location = new System.Drawing.Point(36, 223);
			this.lAbout2.Name = "lAbout2";
			this.lAbout2.Size = new System.Drawing.Size(721, 20);
			this.lAbout2.TabIndex = 2;
			this.lAbout2.Text = "Lembrando que não há garantias para o software e nem da completa exatidão dos dad" +
    "os minerados.";
			// 
			// lAbout3
			// 
			this.lAbout3.AutoSize = true;
			this.lAbout3.ForeColor = System.Drawing.Color.White;
			this.lAbout3.Location = new System.Drawing.Point(174, 248);
			this.lAbout3.Name = "lAbout3";
			this.lAbout3.Size = new System.Drawing.Size(444, 20);
			this.lAbout3.TabIndex = 3;
			this.lAbout3.Text = "Desenvolvido por Félix Severo como um projeto Open Source.";
			// 
			// lAbout1
			// 
			this.lAbout1.AutoSize = true;
			this.lAbout1.ForeColor = System.Drawing.Color.White;
			this.lAbout1.Location = new System.Drawing.Point(29, 198);
			this.lAbout1.Name = "lAbout1";
			this.lAbout1.Size = new System.Drawing.Size(735, 20);
			this.lAbout1.TabIndex = 1;
			this.lAbout1.Text = "Este software é destinado à mineração dos códigos comumente utilizados em notas f" +
    "iscais eletrônicas.";
			// 
			// tpCest
			// 
			this.tpCest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.tpCest.Controls.Add(this.lCest3);
			this.tpCest.Controls.Add(this.lCest2);
			this.tpCest.Controls.Add(this.lCest);
			this.tpCest.Controls.Add(this.lSave);
			this.tpCest.Controls.Add(this.tbSave);
			this.tpCest.Controls.Add(this.lSearch);
			this.tpCest.Controls.Add(this.tbSearch);
			this.tpCest.Controls.Add(this.fbMineCest);
			this.tpCest.Controls.Add(this.lCest1);
			this.tpCest.Location = new System.Drawing.Point(4, 29);
			this.tpCest.Name = "tpCest";
			this.tpCest.Padding = new System.Windows.Forms.Padding(3);
			this.tpCest.Size = new System.Drawing.Size(792, 467);
			this.tpCest.TabIndex = 1;
			this.tpCest.Text = "tpCest";
			// 
			// lCest3
			// 
			this.lCest3.AutoSize = true;
			this.lCest3.ForeColor = System.Drawing.Color.White;
			this.lCest3.Location = new System.Drawing.Point(46, 261);
			this.lCest3.Name = "lCest3";
			this.lCest3.Size = new System.Drawing.Size(701, 20);
			this.lCest3.TabIndex = 7;
			this.lCest3.Text = "Se notar algo errado, sinta-se à vontade para abrir uma Issue ou fazer um Pull Re" +
    "quest no Github.";
			// 
			// lCest2
			// 
			this.lCest2.AutoSize = true;
			this.lCest2.ForeColor = System.Drawing.Color.White;
			this.lCest2.Location = new System.Drawing.Point(147, 236);
			this.lCest2.Name = "lCest2";
			this.lCest2.Size = new System.Drawing.Size(498, 20);
			this.lCest2.TabIndex = 6;
			this.lCest2.Text = "Caso o endereço mude, é possível apenas modificar o local da busca.";
			// 
			// lCest
			// 
			this.lCest.AutoSize = true;
			this.lCest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCest.ForeColor = System.Drawing.Color.White;
			this.lCest.Location = new System.Drawing.Point(8, 3);
			this.lCest.Name = "lCest";
			this.lCest.Size = new System.Drawing.Size(102, 37);
			this.lCest.TabIndex = 0;
			this.lCest.Text = "CEST";
			// 
			// lSave
			// 
			this.lSave.AutoSize = true;
			this.lSave.ForeColor = System.Drawing.Color.White;
			this.lSave.Location = new System.Drawing.Point(44, 154);
			this.lSave.Name = "lSave";
			this.lSave.Size = new System.Drawing.Size(83, 20);
			this.lSave.TabIndex = 3;
			this.lSave.Text = "Salvar em:";
			// 
			// tbSave
			// 
			this.tbSave.BackColor = System.Drawing.Color.Gray;
			this.tbSave.ForeColor = System.Drawing.Color.White;
			this.tbSave.Location = new System.Drawing.Point(48, 177);
			this.tbSave.Name = "tbSave";
			this.tbSave.Size = new System.Drawing.Size(700, 26);
			this.tbSave.TabIndex = 4;
			// 
			// lSearch
			// 
			this.lSearch.AutoSize = true;
			this.lSearch.ForeColor = System.Drawing.Color.White;
			this.lSearch.Location = new System.Drawing.Point(44, 102);
			this.lSearch.Name = "lSearch";
			this.lSearch.Size = new System.Drawing.Size(120, 20);
			this.lSearch.TabIndex = 1;
			this.lSearch.Text = "Local da busca:";
			// 
			// tbSearch
			// 
			this.tbSearch.BackColor = System.Drawing.Color.Gray;
			this.tbSearch.ForeColor = System.Drawing.Color.White;
			this.tbSearch.Location = new System.Drawing.Point(48, 125);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(700, 26);
			this.tbSearch.TabIndex = 2;
			this.tbSearch.Text = "https://www.confaz.fazenda.gov.br/legislacao/convenios/2017/CV052_17";
			// 
			// fbMineCest
			// 
			this.fbMineCest.BackColor = System.Drawing.Color.Gray;
			this.fbMineCest.FlatAppearance.BorderSize = 0;
			this.fbMineCest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbMineCest.ForeColor = System.Drawing.Color.White;
			this.fbMineCest.Location = new System.Drawing.Point(296, 289);
			this.fbMineCest.Name = "fbMineCest";
			this.fbMineCest.Size = new System.Drawing.Size(200, 75);
			this.fbMineCest.TabIndex = 8;
			this.fbMineCest.Text = "Minerar!";
			this.fbMineCest.UseVisualStyleBackColor = false;
			this.fbMineCest.Click += new System.EventHandler(this.fbMineCest_Click);
			// 
			// lCest1
			// 
			this.lCest1.AutoSize = true;
			this.lCest1.ForeColor = System.Drawing.Color.White;
			this.lCest1.Location = new System.Drawing.Point(141, 211);
			this.lCest1.Name = "lCest1";
			this.lCest1.Size = new System.Drawing.Size(510, 20);
			this.lCest1.TabIndex = 5;
			this.lCest1.Text = "Os códigos CEST são minerados da página da Confaz, indicada acima.";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pCenter);
			this.Controls.Add(this.pTop);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Code Miner";
			this.pTop.ResumeLayout(false);
			this.pTop.PerformLayout();
			this.pCenter.ResumeLayout(false);
			this.tablessControl.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			this.tpAbout.PerformLayout();
			this.tpCest.ResumeLayout(false);
			this.tpCest.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pTop;
		private System.Windows.Forms.Panel pCenter;
		private CodeMiner.TablessControl tablessControl;
		private System.Windows.Forms.TabPage tpAbout;
		private System.Windows.Forms.TabPage tpCest;
		private FlatButton fbClose;
		private FlatButton fbCest;
		private FlatButton fbAbout;
		private System.Windows.Forms.Label lAbout3;
		private System.Windows.Forms.Label lAbout1;
		private System.Windows.Forms.Label lCest1;
		private FlatButton fbMineCest;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label lSave;
		private System.Windows.Forms.TextBox tbSave;
		private System.Windows.Forms.Label lSearch;
		private System.Windows.Forms.Label lAbout;
		private System.Windows.Forms.Label lAbout2;
		private System.Windows.Forms.Label lCest;
		private System.Windows.Forms.Label lTitle;
		private System.Windows.Forms.Label lCest3;
		private System.Windows.Forms.Label lCest2;
	}
}

