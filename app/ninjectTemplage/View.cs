using System;
using System.Windows.Forms;
using ninjectTemplage.TemplateSteps;

namespace ninjectTemplage
{
    public partial class View : Form, IView
    {
        private Presenter presenter;

        public View() {
            InitializeComponent();

            presenter = new Presenter(this, new One(), new Two(), new Three());
        }

        private void btnStart_Click(object sender, EventArgs e) {
            presenter.Start();
        }

        public void didOne(string s) {
            lblDidOne.Text = s;
        }

        public void didTwo(string s) {
            lblDidTwo.Text = s;
        }

        public void didThree(string s) {
            lblDidThree.Text = s;
        }
    }

}
