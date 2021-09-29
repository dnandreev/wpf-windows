using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace SaveOpenFileDialogs
{
	public partial class MainWindow : Window
	{
		OpenFileDialog _openDialog = new OpenFileDialog();
		SaveFileDialog _saveDialog = new SaveFileDialog();
		public MainWindow()
		{
			InitializeComponent();
		}
		private void buttonSave_Click(object sender, RoutedEventArgs e)
		{
			_saveDialog.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
			if (_saveDialog.ShowDialog() == true)
			{
				StreamWriter writer = new StreamWriter(_saveDialog.FileName);
				writer.WriteLine(textBoxContent.Text);
				writer.Close();
			}
		}
		private void buttonOpen_Click(object sender, RoutedEventArgs e)
		{
			_openDialog.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
			if (_openDialog.ShowDialog() == true)
			{
				StreamReader reader = new StreamReader(_openDialog.FileName);
				textBoxContent.Text = reader.ReadToEnd();
				reader.Close();
			}
		}
	}
}