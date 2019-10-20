using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductivityTools.Patterns.MVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowView
    {
        private Presenter Presenter;

        public MainWindow()
        {
            InitializeComponent();
            this.Presenter = new Presenter(this);
        }

        public int A { get => int.Parse(this.AField.Text); set => this.AField.Text = value.ToString(); }
        public int B { get => int.Parse(this.BField.Text); set => this.BField.Text = value.ToString(); }
        public int Result { get => int.Parse(this.ResultField.Text); set => this.ResultField.Text = value.ToString(); }

        public event EventHandler Calculate;

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculate!=null)
            {
                this.Calculate.Invoke(sender, e);
            }
        }
    }
}
