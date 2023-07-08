using HangMan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HangManTests
{
    [TestClass]
    public class HangmanForm_UnitTests
    {
        System.Random random = new System.Random();

        private static HangManForm _form { get; set; } = new HangManForm();
        private PrivateObject _privateObject = new PrivateObject(_form);
        private object[] arguments;

        // AddButtons
        [TestMethod]
        public void AddButton_EqualTest()
        {
            int value = 5;
            arguments = new object[] { value };
            List<Button> retVal = (List<Button>)_privateObject.Invoke("AddButtons", arguments);
            Assert.AreEqual(value, retVal.Count);
        }

        [TestMethod]
        public void AddButton_NotEqualTest()
        {
            int value = -1;
            arguments = new object[] { value };
            List<Button> retVal = (List<Button>)_privateObject.Invoke("AddButtons", arguments);
            Assert.AreNotEqual(value, retVal.Count);
        }

        [TestMethod]
        public void AddButton_EqualContentTest()
        {
            int value = random.Next(10, 50);
            arguments = new object[] { value };
            List<Button> retVal = (List<Button>)_privateObject.Invoke("AddButtons", arguments);
            int searchIndex = random.Next(0,value);
            string expectedValue = "___";
            Assert.AreEqual(expectedValue, retVal[searchIndex].Text);
        }

    }

}
