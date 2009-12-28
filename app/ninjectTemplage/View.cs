﻿using System;
using System.Windows.Forms;
using Ninject.Core;

namespace ninjectTemplage
{
    public partial class View : Form, IView
    {
        private Presenter presenter;

        public View() {
            InitializeComponent();

            NinjectSetterUpper module = new NinjectSetterUpper();
            IKernel kernel = new StandardKernel(module);
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
