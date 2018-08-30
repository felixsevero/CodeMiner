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
			this.pCenter = new System.Windows.Forms.Panel();
			this.pbIco = new System.Windows.Forms.PictureBox();
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
			this.lCestSave = new System.Windows.Forms.Label();
			this.tbCestSave = new System.Windows.Forms.TextBox();
			this.lCestSearch = new System.Windows.Forms.Label();
			this.tbCestSearch = new System.Windows.Forms.TextBox();
			this.fbMineCest = new CodeMiner.FlatButton();
			this.lCest1 = new System.Windows.Forms.Label();
			this.tpCfop = new System.Windows.Forms.TabPage();
			this.lCfop3 = new System.Windows.Forms.Label();
			this.lCfop2 = new System.Windows.Forms.Label();
			this.lCfop = new System.Windows.Forms.Label();
			this.lCfopSave = new System.Windows.Forms.Label();
			this.tbCfopSave = new System.Windows.Forms.TextBox();
			this.lCfopSearch = new System.Windows.Forms.Label();
			this.tbCfopSearch = new System.Windows.Forms.TextBox();
			this.fbMineCfop = new CodeMiner.FlatButton();
			this.lCfop1 = new System.Windows.Forms.Label();
			this.fbCfop = new CodeMiner.FlatButton();
			this.fbCest = new CodeMiner.FlatButton();
			this.fbAbout = new CodeMiner.FlatButton();
			this.fbClose = new CodeMiner.FlatButton();
			this.pTop.SuspendLayout();
			this.pCenter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbIco)).BeginInit();
			this.tablessControl.SuspendLayout();
			this.tpAbout.SuspendLayout();
			this.tpCest.SuspendLayout();
			this.tpCfop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pTop
			// 
			this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.pTop.Controls.Add(this.pbIco);
			this.pTop.Controls.Add(this.fbCfop);
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
			// pbIco
			// 
			this.pbIco.Image = ((System.Drawing.Image)(resources.GetObject("pbIco.Image")));
			this.pbIco.Location = new System.Drawing.Point(306, 9);
			this.pbIco.Name = "pbIco";
			this.pbIco.Size = new System.Drawing.Size(26, 26);
			this.pbIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIco.TabIndex = 5;
			this.pbIco.TabStop = false;
			// 
			// tablessControl
			// 
			this.tablessControl.Controls.Add(this.tpAbout);
			this.tablessControl.Controls.Add(this.tpCest);
			this.tablessControl.Controls.Add(this.tpCfop);
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
			this.tpCest.Controls.Add(this.lCestSave);
			this.tpCest.Controls.Add(this.tbCestSave);
			this.tpCest.Controls.Add(this.lCestSearch);
			this.tpCest.Controls.Add(this.tbCestSearch);
			this.tpCest.Controls.Add(this.fbMineCest);
			this.tpCest.Controls.Add(this.lCest1);
			this.tpCest.Location = new System.Drawing.Point(4, 22);
			this.tpCest.Name = "tpCest";
			this.tpCest.Padding = new System.Windows.Forms.Padding(3);
			this.tpCest.Size = new System.Drawing.Size(792, 474);
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
			// lCestSave
			// 
			this.lCestSave.AutoSize = true;
			this.lCestSave.ForeColor = System.Drawing.Color.White;
			this.lCestSave.Location = new System.Drawing.Point(44, 154);
			this.lCestSave.Name = "lCestSave";
			this.lCestSave.Size = new System.Drawing.Size(83, 20);
			this.lCestSave.TabIndex = 3;
			this.lCestSave.Text = "Salvar em:";
			// 
			// tbCestSave
			// 
			this.tbCestSave.BackColor = System.Drawing.Color.Gray;
			this.tbCestSave.ForeColor = System.Drawing.Color.White;
			this.tbCestSave.Location = new System.Drawing.Point(48, 177);
			this.tbCestSave.Name = "tbCestSave";
			this.tbCestSave.Size = new System.Drawing.Size(700, 26);
			this.tbCestSave.TabIndex = 4;
			// 
			// lCestSearch
			// 
			this.lCestSearch.AutoSize = true;
			this.lCestSearch.ForeColor = System.Drawing.Color.White;
			this.lCestSearch.Location = new System.Drawing.Point(44, 102);
			this.lCestSearch.Name = "lCestSearch";
			this.lCestSearch.Size = new System.Drawing.Size(120, 20);
			this.lCestSearch.TabIndex = 1;
			this.lCestSearch.Text = "Local da busca:";
			// 
			// tbCestSearch
			// 
			this.tbCestSearch.BackColor = System.Drawing.Color.Gray;
			this.tbCestSearch.ForeColor = System.Drawing.Color.White;
			this.tbCestSearch.Location = new System.Drawing.Point(48, 125);
			this.tbCestSearch.Name = "tbCestSearch";
			this.tbCestSearch.Size = new System.Drawing.Size(700, 26);
			this.tbCestSearch.TabIndex = 2;
			this.tbCestSearch.Text = "https://www.confaz.fazenda.gov.br/legislacao/convenios/2017/CV052_17";
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
			// tpCfop
			// 
			this.tpCfop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.tpCfop.Controls.Add(this.lCfop3);
			this.tpCfop.Controls.Add(this.lCfop2);
			this.tpCfop.Controls.Add(this.lCfop);
			this.tpCfop.Controls.Add(this.lCfopSave);
			this.tpCfop.Controls.Add(this.tbCfopSave);
			this.tpCfop.Controls.Add(this.lCfopSearch);
			this.tpCfop.Controls.Add(this.tbCfopSearch);
			this.tpCfop.Controls.Add(this.fbMineCfop);
			this.tpCfop.Controls.Add(this.lCfop1);
			this.tpCfop.Location = new System.Drawing.Point(4, 22);
			this.tpCfop.Name = "tpCfop";
			this.tpCfop.Padding = new System.Windows.Forms.Padding(3);
			this.tpCfop.Size = new System.Drawing.Size(792, 474);
			this.tpCfop.TabIndex = 2;
			this.tpCfop.Text = "tpCfop";
			// 
			// lCfop3
			// 
			this.lCfop3.AutoSize = true;
			this.lCfop3.ForeColor = System.Drawing.Color.White;
			this.lCfop3.Location = new System.Drawing.Point(46, 261);
			this.lCfop3.Name = "lCfop3";
			this.lCfop3.Size = new System.Drawing.Size(701, 20);
			this.lCfop3.TabIndex = 16;
			this.lCfop3.Text = "Se notar algo errado, sinta-se à vontade para abrir uma Issue ou fazer um Pull Re" +
    "quest no Github.";
			// 
			// lCfop2
			// 
			this.lCfop2.AutoSize = true;
			this.lCfop2.ForeColor = System.Drawing.Color.White;
			this.lCfop2.Location = new System.Drawing.Point(167, 236);
			this.lCfop2.Name = "lCfop2";
			this.lCfop2.Size = new System.Drawing.Size(459, 20);
			this.lCfop2.TabIndex = 15;
			this.lCfop2.Text = "O arquivo texto pode ser obtido na página de Tabelas do SPED.";
			// 
			// lCfop
			// 
			this.lCfop.AutoSize = true;
			this.lCfop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lCfop.ForeColor = System.Drawing.Color.White;
			this.lCfop.Location = new System.Drawing.Point(8, 3);
			this.lCfop.Name = "lCfop";
			this.lCfop.Size = new System.Drawing.Size(106, 37);
			this.lCfop.TabIndex = 0;
			this.lCfop.Text = "CFOP";
			// 
			// lCfopSave
			// 
			this.lCfopSave.AutoSize = true;
			this.lCfopSave.ForeColor = System.Drawing.Color.White;
			this.lCfopSave.Location = new System.Drawing.Point(44, 154);
			this.lCfopSave.Name = "lCfopSave";
			this.lCfopSave.Size = new System.Drawing.Size(83, 20);
			this.lCfopSave.TabIndex = 12;
			this.lCfopSave.Text = "Salvar em:";
			// 
			// tbCfopSave
			// 
			this.tbCfopSave.BackColor = System.Drawing.Color.Gray;
			this.tbCfopSave.ForeColor = System.Drawing.Color.White;
			this.tbCfopSave.Location = new System.Drawing.Point(48, 177);
			this.tbCfopSave.Name = "tbCfopSave";
			this.tbCfopSave.Size = new System.Drawing.Size(700, 26);
			this.tbCfopSave.TabIndex = 13;
			// 
			// lCfopSearch
			// 
			this.lCfopSearch.AutoSize = true;
			this.lCfopSearch.ForeColor = System.Drawing.Color.White;
			this.lCfopSearch.Location = new System.Drawing.Point(44, 102);
			this.lCfopSearch.Name = "lCfopSearch";
			this.lCfopSearch.Size = new System.Drawing.Size(121, 20);
			this.lCfopSearch.TabIndex = 10;
			this.lCfopSearch.Text = "Local da tabela:";
			// 
			// tbCfopSearch
			// 
			this.tbCfopSearch.BackColor = System.Drawing.Color.Gray;
			this.tbCfopSearch.ForeColor = System.Drawing.Color.White;
			this.tbCfopSearch.Location = new System.Drawing.Point(48, 125);
			this.tbCfopSearch.Name = "tbCfopSearch";
			this.tbCfopSearch.Size = new System.Drawing.Size(700, 26);
			this.tbCfopSearch.TabIndex = 11;
			// 
			// fbMineCfop
			// 
			this.fbMineCfop.BackColor = System.Drawing.Color.Gray;
			this.fbMineCfop.FlatAppearance.BorderSize = 0;
			this.fbMineCfop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbMineCfop.ForeColor = System.Drawing.Color.White;
			this.fbMineCfop.Location = new System.Drawing.Point(296, 289);
			this.fbMineCfop.Name = "fbMineCfop";
			this.fbMineCfop.Size = new System.Drawing.Size(200, 75);
			this.fbMineCfop.TabIndex = 17;
			this.fbMineCfop.Text = "Minerar!";
			this.fbMineCfop.UseVisualStyleBackColor = false;
			this.fbMineCfop.Click += new System.EventHandler(this.fbMineCfop_Click);
			// 
			// lCfop1
			// 
			this.lCfop1.AutoSize = true;
			this.lCfop1.ForeColor = System.Drawing.Color.White;
			this.lCfop1.Location = new System.Drawing.Point(202, 211);
			this.lCfop1.Name = "lCfop1";
			this.lCfop1.Size = new System.Drawing.Size(389, 20);
			this.lCfop1.TabIndex = 14;
			this.lCfop1.Text = "Os códigos CFOP são minerados de um arquivo texto.";
			// 
			// fbCfop
			// 
			this.fbCfop.BackColor = System.Drawing.Color.Gray;
			this.fbCfop.FlatAppearance.BorderSize = 0;
			this.fbCfop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbCfop.ForeColor = System.Drawing.Color.White;
			this.fbCfop.Location = new System.Drawing.Point(514, 54);
			this.fbCfop.Name = "fbCfop";
			this.fbCfop.Size = new System.Drawing.Size(215, 40);
			this.fbCfop.TabIndex = 4;
			this.fbCfop.Text = "CFOP";
			this.fbCfop.UseVisualStyleBackColor = false;
			this.fbCfop.Click += new System.EventHandler(this.fbCfop_Click);
			// 
			// fbCest
			// 
			this.fbCest.BackColor = System.Drawing.Color.Gray;
			this.fbCest.FlatAppearance.BorderSize = 0;
			this.fbCest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fbCest.ForeColor = System.Drawing.Color.White;
			this.fbCest.Location = new System.Drawing.Point(293, 54);
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
			this.fbAbout.Location = new System.Drawing.Point(72, 54);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Code Miner";
			this.pTop.ResumeLayout(false);
			this.pTop.PerformLayout();
			this.pCenter.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbIco)).EndInit();
			this.tablessControl.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			this.tpAbout.PerformLayout();
			this.tpCest.ResumeLayout(false);
			this.tpCest.PerformLayout();
			this.tpCfop.ResumeLayout(false);
			this.tpCfop.PerformLayout();
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
		private System.Windows.Forms.TextBox tbCestSearch;
		private System.Windows.Forms.Label lCestSave;
		private System.Windows.Forms.TextBox tbCestSave;
		private System.Windows.Forms.Label lCestSearch;
		private System.Windows.Forms.Label lAbout;
		private System.Windows.Forms.Label lAbout2;
		private System.Windows.Forms.Label lCest;
		private System.Windows.Forms.Label lTitle;
		private System.Windows.Forms.Label lCest3;
		private System.Windows.Forms.Label lCest2;
		private FlatButton fbCfop;
		private System.Windows.Forms.TabPage tpCfop;
		private System.Windows.Forms.Label lCfop3;
		private System.Windows.Forms.Label lCfop2;
		private System.Windows.Forms.Label lCfop;
		private System.Windows.Forms.Label lCfopSave;
		private System.Windows.Forms.TextBox tbCfopSave;
		private System.Windows.Forms.Label lCfopSearch;
		private System.Windows.Forms.TextBox tbCfopSearch;
		private FlatButton fbMineCfop;
		private System.Windows.Forms.Label lCfop1;
		private System.Windows.Forms.PictureBox pbIco;
	}
}

