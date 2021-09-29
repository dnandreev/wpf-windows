using System;
using System.Windows;

namespace Variant1{
	public partial class AverageWindow : Window{
		public AverageWindow() => InitializeComponent();

		void carryOut(object sender, RoutedEventArgs e){
			string[] strings = numbers.Text.Split(',');
			long sum = 0;
			try{
				for(int i = 0; i < strings.Length; i++)
					sum += Convert.ToInt64(strings[i]);
				average.Text = Math.Round(sum * 1.0 / strings.Length, 2).ToString();
			}
			catch(Exception exception){
				average.Text = exception.Message;
			}
		}
	}
}