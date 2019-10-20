using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Patterns.MVP
{
    class Presenter
    {
        IMainWindowView MainWindowView;

        public Presenter(IMainWindowView mainWindowView)
        {
            this.MainWindowView = mainWindowView;
            WireupEvents();
        }

        private void WireupEvents()
        {
            MainWindowView.Calculate += MainWindowView_Calculate;
        }

        private void MainWindowView_Calculate(object sender, EventArgs e)
        {
            MainWindowView.Result = MainWindowView.A + MainWindowView.B;
        }
    }
}
