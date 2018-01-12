using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace mobileAuto
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
        //[Test]
        //public void ReplTC()
        //{
        //    app.Repl();
        //}
        [Test]
        public void testcase1()
        {
            app.Tap("Calculator");
            app.EnterText("num1", "9");
            app.EnterText("num2", "5");
            app.Tap("add");

            var result = app.Query("result").First();
            Assert.AreEqual("14", result.Text);

        }
        [Test]
        public void testcase2()
        {
            app.Tap("Calculator");
            app.EnterText("num1", "9");
            app.EnterText("num2", "5");
            app.Tap("minus");

            var result = app.Query("result").First();
            Assert.AreEqual("4", result.Text);

        }
        [Test]
        public void testcase3()
        {
            app.Tap("Calculator");
            app.EnterText("num1", "9");
            app.EnterText("num2", "5");
            app.Tap("divide");

            var result = app.Query("result").First();
            Assert.AreEqual("2.8", result.Text);

        }
        [Test]
        public void testcase4()
        {
            app.Tap("Calculator");
            app.EnterText("num1", "9");
            app.EnterText("num2", "5");
            app.Tap("times");

            var result = app.Query("result").First();
            Assert.AreEqual("45", result.Text);

        }
    }
}

