using CodeMiner.Cest;
using CodeMiner.Cfop;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CodeMiner {

	public partial class Main: Form {

		public Main() {
			InitializeComponent();

			string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			tbCestSave.Text = location;
			tbCfopSave.Text = location;
		}

		void fbClose_Click(object sender, EventArgs e) => Close();

		void fbAbout_Click(object sender, EventArgs e) => tablessControl.SelectedTab = tpAbout;

		void fbCest_Click(object sender, EventArgs e) => tablessControl.SelectedTab = tpCest;

		void fbCfop_Click(object sender, EventArgs e) => tablessControl.SelectedTab = tpCfop;

		#region CEST

		void fbMineCest_Click(object sender, EventArgs e) {
			if(string.IsNullOrWhiteSpace(tbCestSearch.Text)) {
				MessageBox.Show("O local de busca deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if(string.IsNullOrWhiteSpace(tbCestSave.Text)) {
				MessageBox.Show("O local de salvamento deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try {
				fbMineCest.Enabled = false;
				Uri uri = new Uri(tbCestSearch.Text);
				CestCollection cests = uri.GetWebContent().GetRows().GetCestCollection();
				cests.SaveToJson(tbCestSave.Text);
				MessageBox.Show($"Foram minerados { cests.Count } códigos CEST.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				fbMineCest.Enabled = true;
			}
		}

		#endregion

		#region CFOP

		void fbMineCfop_Click(object sender, EventArgs e) {
			if(string.IsNullOrWhiteSpace(tbCfopSearch.Text)) {
				MessageBox.Show("O local da tabela deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if(string.IsNullOrWhiteSpace(tbCfopSave.Text)) {
				MessageBox.Show("O local de salvamento deve ser preenchido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try {
				fbMineCfop.Enabled = false;
				Log log = new Log();
				string filePath = tbCfopSearch.Text;
				CfopCollection cfops = filePath.GetFileContent().GetCfopCollection(log);
				cfops.SaveToJson(tbCfopSave.Text);
				StringBuilder stringBuilder = new StringBuilder($"Foram minerados { cfops.Count } códigos CFOP.{ Environment.NewLine }");
				foreach(string str in log)
					stringBuilder.AppendLine(str);
				MessageBox.Show(stringBuilder.ToString(), "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				fbMineCfop.Enabled = true;
			}
		}

		#endregion

	}

}
