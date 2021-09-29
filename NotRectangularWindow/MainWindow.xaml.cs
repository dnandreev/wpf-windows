using System.Windows;
using System.Windows.Input;

namespace NotRectangularWindow{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();
		
		void buttonClose_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
		
		void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
	}
}