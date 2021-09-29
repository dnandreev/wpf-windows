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
using System.Windows.Shapes;

namespace WindowOwnership
{
	/// <summary>
	/// Interaction logic for ExtraWindow.xaml
	/// </summary>
	public partial class ExtraWindow : Window
	{
		public ExtraWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			(Owner as MainWindow).Title = "Hello from child";
		}
	}
}