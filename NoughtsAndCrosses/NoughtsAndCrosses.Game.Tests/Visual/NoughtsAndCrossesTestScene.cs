using osu.Framework.Testing;

namespace NoughtsAndCrosses.Game.Tests.Visual
{
    public abstract partial class NoughtsAndCrossesTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new NoughtsAndCrossesTestSceneTestRunner();

        private partial class NoughtsAndCrossesTestSceneTestRunner : NoughtsAndCrossesGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}