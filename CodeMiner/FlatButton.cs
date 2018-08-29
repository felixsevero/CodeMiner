using System.Drawing;
using System.Windows.Forms;

namespace CodeMiner {

	class FlatButton: Button {

		public FlatButton() {
			BackColor = Color.Gray;
			FlatAppearance.BorderSize = 0;
			FlatStyle = FlatStyle.Flat;
			ForeColor = Color.White;
		}

	}

}
