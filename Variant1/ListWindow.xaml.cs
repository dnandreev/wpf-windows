using System.Windows;

namespace Variant1{
	public partial class ListWindow : Window{
		public ListWindow() => InitializeComponent();

		void add(object sender, RoutedEventArgs e){
			listOpenable.Items.Add(text.Text);
			text.Text = "";
			MessageBox.Show("Элемент успешно добавлен в список!");
		}
	}
}