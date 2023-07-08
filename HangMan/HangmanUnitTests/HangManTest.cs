using HangMan;
using System;
using System.Windows.Forms;

namespace HangmanUnitTests
{
    public class Tests
    {
        private HangManForm _form { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _form = new HangManForm();
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
    }
}