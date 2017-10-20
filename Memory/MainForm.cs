using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory.Views;

namespace Memory {
	public partial class MainForm : Form {
		private static Dictionary<string, Form> views = new Dictionary<string, Form>();
		private static Panel _viewPanel;
		public MainForm() {
			InitializeComponent();
			_viewPanel = viewPanel;
			LoadViews();
			LoadView("hoofdscherm");
		}

		private static void LoadViews() {
			views.Add("hoofdscherm", new Hoofdscherm());
			views.Add("spelscherm", new Spelscherm());
			views.Add("eindscherm", new Eindscherm());
            views.Add("laadscherm", new Laadscherm());
            views.Add("localmultiplayer", new LocalMultiplayer());
            views.Add("onlinemultiplayer", new OnlineMultiplayer());
            views.Add("choosetheme", new ChooseTheme());
            views.Add("gethelp", new GetHelp());

			foreach (KeyValuePair<string, Form> rawView in views) {
				Form view = rawView.Value;
				view.TopLevel = false;
				view.Visible = true;
				view.FormBorderStyle = FormBorderStyle.None;
				view.Dock = DockStyle.Fill;
				_viewPanel.Controls.Add(view);
			}

		}

		public static void LoadView(string view) {
			foreach(KeyValuePair<string, Form> rawView in views) {
				rawView.Value.Hide();
			}

			if (views.ContainsKey(view)) {
				Form loadedView = views[view];
				loadedView.Show();
			}
		}

        private void viewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
