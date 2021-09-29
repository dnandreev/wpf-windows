using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace Variant1{
	public partial class FileWindow : Window{
		OpenFileDialog opener = new OpenFileDialog();
		SaveFileDialog saver = new SaveFileDialog();

		public FileWindow() => InitializeComponent();

		void open(object sender, RoutedEventArgs e){
			opener.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
			if(opener.ShowDialog() == true){
				StreamReader reader = new StreamReader(opener.FileName);
				text.Text = reader.ReadToEnd();
				reader.Close();
			}
		}

		void save(object sender, RoutedEventArgs e){
			saver.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
			if(saver.ShowDialog() == true){
				StreamWriter writer = new StreamWriter(saver.FileName);
				writer.WriteLine(text.Text);
				writer.Close();
			}
		}
	}
}