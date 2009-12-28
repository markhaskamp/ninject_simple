using Ninject.Core;
using ninjectTemplage.TemplateSteps;

namespace ninjectTemplage
{
    class NinjectSetterUpper : StandardModule
    {
        public override void Load() {
//            Bind<IView>().To<View>();
            Bind<IOne>().To<One>();
            Bind<ITwo>().To<Two>();
            Bind<IThree>().To<Three>();
        }
    }
}
