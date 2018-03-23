using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace LayoutExploration
{
    class LayoutExploration
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new LayoutExploration().run();
        }

        void run()
        {
            new Application().Run(new MainWindow());
        }
    }
}
