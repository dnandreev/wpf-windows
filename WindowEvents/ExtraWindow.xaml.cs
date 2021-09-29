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

namespace WindowEvents{
	public partial class ExtraWindow : Window{
		public ExtraWindow() => InitializeComponent();
		void yes(object sender, RoutedEventArgs e) => DialogResult = true;
		void no(object sender, RoutedEventArgs e) => DialogResult = false;
	}
}