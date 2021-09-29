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

namespace DialogTypes
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		void button1_Click(object sender, RoutedEventArgs e){
			NewWindow window = new NewWindow("Модальное");
			window.ShowDialog();
		}
		void button2_Click(object sender, RoutedEventArgs e){
			NewWindow window = new NewWindow("Немодальное");
			window.Show();
		}
	}
}