using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChromiumEmbeddedAndMvvm.Models
{
    /// <summary>
    /// This class can expose services to the CEF view that drives your core business logic. This can be a normal .NET class
    /// making PInvoke calls or doing anything just like you would in a WPF app
    /// </summary>
    internal class AppModelAndServices
    {
        public string GetHostOsVersion()
        {
            return Environment.OSVersion.VersionString;
        }

        public void DisplayCallStack()
        {
            MessageBox.Show(new StackFrame().ToString());
        }

        public void BreakIntoDebugger()
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
            else
            {
                MessageBox.Show("Attach the VS debugger to see this break");
            }
        }
    }
}
