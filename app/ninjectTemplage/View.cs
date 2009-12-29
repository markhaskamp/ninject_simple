using System;
using System.Windows.Forms;
using Ninject.Core;

namespace ninjectTemplage
{
    public partial class View : Form, IView
    {
        private readonly Presenter presenter;

        public View(IKernel kernel) {
            InitializeComponent();

            presenter = kernel.Get<Presenter>();
            presenter.setView(this);
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
