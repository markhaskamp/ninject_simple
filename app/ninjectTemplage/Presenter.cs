using Ninject.Core;
using ninjectTemplage.TemplateSteps;

namespace ninjectTemplage
{
    public class Presenter
    {
        private IView view;
        private IOne one;
        private ITwo two;
        private IThree three;

        public Presenter(IOne one, ITwo two, IThree three) {
            this.one = one;
            this.two = two;
            this.three = three;
        }

        public void setView(IView view) {
            this.view = view;
        }

        public void Start() {
            one.stageIt();
            view.didOne("staged it");

            two.doIt();
            view.didTwo("did it");

            three.cleanIt();
            view.didThree("cleaned it");
        }
    }
}