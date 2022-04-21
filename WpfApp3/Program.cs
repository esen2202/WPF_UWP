using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3
{
    class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new App1.App())
            {
                var app = new WpfApp3.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
