using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CodeMiner {

	public partial class Main: Form {

		public Main() {
			InitializeComponent();

			tbSave.Text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		}

		void fbClose_Click(object sender, EventArgs e) => Close();

		void fbAbout_Click(object sender, EventArgs e) => tablessControl.SelectedTab = tpAbout;

		void fbCest_Click(object sender, EventArgs e) => tablessControl.SelectedTab = tpCest;

		void fbMineCest_Click(object sender, EventArgs e) {
			if(string.IsNullOrWhiteSpace(tbSearch.Text)) {
				MessageBox.Show("O local de busca deve ser preenchido.");
				return;
			}
			if(string.IsNullOrWhiteSpace(tbSave.Text)) {
				MessageBox.Show("O local de salvamento deve ser preenchido.");
				return;
			}
			try {
				fbMineCest.Enabled = false;
				Uri uri = new Uri(tbSearch.Text);
				CestCollection cests = uri.GetWebContent().GetRows().GetCestCollection();
				cests.SaveToJson(tbSave.Text);
				MessageBox.Show($"Foram minerados { cests.Count } códigos CEST com sucesso!");
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
			finally {
				fbMineCest.Enabled = true;
			}
		}

	}

}
