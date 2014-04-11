using NUnit.Framework;

namespace XunitContrib.Runner.ReSharper.Tests.Runner
{
    public class When_capturing_output_from_fact : XunitTaskRunnerOutputTestBase
    {
        private const string TypeName = "Foo.CapturesOutput";

        protected override string GetTestName()
        {
            return "CapturesOutput";
        }

        [Test]
        public void Should_notify_output_for_successful_test()
        {
            AssertContainsOutput(ForTaskAndChildren(TypeName, "OutputFromSuccessfulTest"),
                "This is some output");
        }

        [Test]
        public void Should_notify_output_for_failing_test()
        {
            AssertContainsOutput(ForTaskAndChildren(TypeName, "OutputFromFailingTest"),
                "This is also some output");
        }

        [Test]
        public void Should_notify_output_between_start_and_end_of_method()
        {
            AssertMessageOrder(ForTaskAndChildren(TypeName, "OutputFromSuccessfulTest"),
                TaskAction.Start,
                    TaskAction.Output,
                    TaskAction.Duration,
                TaskAction.Finish);
        }
    }
}