using MbUnit.Framework;
using ninjectTemplage;
using ninjectTemplage.TemplateSteps;
using Rhino.Mocks;

namespace ninjectTemplate_Test
{
    [TestFixture]
    public class Presenter_Test
    {
        private MockRepository mockery = new MockRepository();
        private IView view;
        private IOne one;
        private ITwo two;
        private IThree three;

        private Presenter presenter;

        [SetUp]
        public void SetUp() {
            view = mockery.DynamicMock<IView>();
            one = mockery.DynamicMock<IOne>();
            two = mockery.DynamicMock<ITwo>();
            three = mockery.DynamicMock<IThree>();
            presenter = new Presenter(view, one, two, three);
        }

        [Test]
        public void Start__Calls_IOne_stageIt() {
            using (mockery.Record()) {
                one.stageIt();
            }

            using (mockery.Playback()) {
                presenter.Start();
            }

            mockery.VerifyAll();
        }

        [Test]
        public void Start__Calls_ITwo_doIt() {
            using (mockery.Record()) {
                two.doIt();
            }

            using (mockery.Playback()) {
                presenter.Start();
            }

            mockery.VerifyAll();
        }

        [Test]
        public void Start__Calls_IThree_cleanIt() {
            using (mockery.Record()) {
                three.cleanIt();
            }

            using (mockery.Playback()) {
                presenter.Start();
            }

            mockery.VerifyAll();
        }

    }
}
