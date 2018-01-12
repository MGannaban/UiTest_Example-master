using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace mobileAuto
{
    [TestFixture(Platform.Android)]
    public class wall
    {
        IApp app;
        Platform platform;

        public wall(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
            //sample note
        {
            app = AppInitializer.StartApp(platform);
        }


    }
}
