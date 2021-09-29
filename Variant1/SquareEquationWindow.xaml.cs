using System;
using System.Windows;

namespace Variant1{
	public partial class SquareEquationWindow : Window{
		public SquareEquationWindow() => InitializeComponent();

		void carryOut(object sender, RoutedEventArgs e){
			try{
				double a = Convert.ToDouble(x2.Text), b = Convert.ToDouble(x1.Text), c = Convert.ToDouble(x0.Text), d = b * b - 4 * a * c;
				if(d < 0)
					result.Text = "Корней нет";
				else{
					result.Text = string.Format("Первый корень уравнения: {0}.", Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2));
					if(d > 0)
						result.Text += string.Format(" Второй корень уравнения: {0}.", Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2));
				}
			}
			catch(Exception exception){
				result.Text = exception.Message;
			}
		}
	}
}