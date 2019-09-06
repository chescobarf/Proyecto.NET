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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using CoreSevices;

namespace Login
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
			Contacto.IsOpen = true;
        }

		private void button_Click(object sender, RoutedEventArgs e)
		{
			OpenServices services = new OpenServices();
			string user = textBox.Text;
			string pass = passwordBox.Password.ToString();
			if (services.ValidarUsuario(user, pass))
			{
				var newForm = new Pages.Administrador.vAdmin();
				newForm.Show();
				Close();
			}
			else
			{
				
			}
		}
	}
}
