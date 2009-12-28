using System;
using ninjectTemplage.TemplateSteps;

namespace ninjectTemplage
{
    public class Presenter
    {
        private IView view;
        private IOne one;
        private ITwo two;
        private IThree three;

        public Presenter(IView view, IOne one, ITwo two, IThree three) {
            this.view = view;
            this.one = one;
            this.two = two;
            this.three = three;
        }

        public void Start() {
            one.stageIt();
            two.doIt();
            three.cleanIt();
        }
    }
}