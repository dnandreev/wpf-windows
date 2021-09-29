using System.Windows;

namespace Variant1{
	public partial class MainWindow : Window{
		AverageWindow averageWindow = new AverageWindow();
		SquareEquationWindow squareEquationWindow = new SquareEquationWindow();
		ListWindow listWindow = new ListWindow();
		FileWindow fileWindow = new FileWindow();

		public MainWindow() => InitializeComponent();

		void average(object sender, RoutedEventArgs e) => averageWindow.ShowDialog();

		void squareEquation(object sender, RoutedEventArgs e) => squareEquationWindow.ShowDialog();

		void list(object sender, RoutedEventArgs e) => listWindow.ShowDialog();

		void file(object sender, RoutedEventArgs e) => fileWindow.ShowDialog();

		void shutdown(object sender, System.ComponentModel.CancelEventArgs e) => App.Current.Shutdown();
	}
}