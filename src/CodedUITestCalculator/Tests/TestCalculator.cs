using System;
using System.IO;
using CodedUITestCalculator.Utils;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace CodedUITestCalculator.Tests
{
    /// <summary>
    /// Summary description for TestCalculator
    /// </summary>
    [CodedUITest]
    public class TestCalculator
    {
        public ApplicationUnderTest Process { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            Process = ApplicationUnderTest.Launch(Path.Combine(Environment.SystemDirectory, "calc1.exe"));
        }

        [TestCleanup]
        public void TearDown()
        {
            Process.Process.Kill();
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Resources\\data.csv", "data#csv",
             DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        [TestMethod]
        public void TestCalculatorCalculationResult()
        {
            int num1 = Convert.ToInt32(TestContext.DataRow["Num1"]);
            int num2 = Convert.ToInt32(TestContext.DataRow["Num2"]);
            string operation = TestContext.DataRow["Operation"].ToString();

            Mouse.Click(UIMap.GetButtonByName(num1.ToString()));
            Mouse.Click(UIMap.GetButtonByName(operation));
            Mouse.Click(UIMap.GetButtonByName(num2.ToString()));
            Mouse.Click(UIMap.GetButtonByName("Equals"));
            Playback.Wait(2000);

            double expected = CalculatorHelper.DoOperation(num1, num2, operation);
            double actual = Convert.ToDouble(UIMap.GetTextBoxTextByName("ResultBox"));

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        private UIMap map;
        public UIMap UIMap => map ?? (map = new UIMap());
    }
}
