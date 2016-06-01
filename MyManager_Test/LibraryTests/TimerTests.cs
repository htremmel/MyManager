using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.Diagnostics;

namespace MyManager_Test.LibraryTests
{
    [TestFixture]
    public class TimerTests
    {
        public event Action<string> Display;

        public 
        [SetUp]
        void Setup()
        {
            Display += PrintToConsole;

        }

        [Test]
        public void StartTest()
        {
            
        }

        [Test]
        public void StopTest()
        {

        }

        [Test]
        public void CreateTimersTest()
        {

        }

        [Test]
        public void TimeAsyncTest()
        {

        }

        string GetTestHeader()
        {
            StringBuilder sb = new StringBuilder();            
            string testName = new StackFrame().GetMethod().Name;
            sb.Append("Test: " + testName);
            return sb.ToString();

        }

        void PrintToConsole(string msg)
        {
            Console.WriteLine(GetTestHeader());
            Console.WriteLine(msg);
        }

    }
}
