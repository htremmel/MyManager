using MyManager_WPF;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MyManager_Test.WPFTests
{
    [TestFixture]
    public class InterfaceTest
    {
        Window win = null;
        [Test]
        public void ShowMain_Test()
        {
            Assert.DoesNotThrow(new TestDelegate(ShowMainWindow));
        }

        void ShowMainWindow()
        {
            MainWindow window = null;

            // The dispatcher thread
            var t = new Thread(() =>
            {
                window = new MainWindow();

                // Initiates the dispatcher thread shutdown when the window closes
                window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();

                window.Show();

                // Makes the thread support message pumping
                System.Windows.Threading.Dispatcher.Run();
            });

            // Configure the thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
