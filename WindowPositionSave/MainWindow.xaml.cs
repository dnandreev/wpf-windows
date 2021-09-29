using System.Windows;

namespace WindowPositionSave{
	public partial class MainWindow : Window{
		public MainWindow(){
			InitializeComponent();
			Closing += new System.ComponentModel.CancelEventHandler(Window_Closing);
			Left = Properties.Settings.Default.WindowPosition.Left;
			Top = Properties.Settings.Default.WindowPosition.Top;
			Width = Properties.Settings.Default.WindowPosition.Width;
			Height = Properties.Settings.Default.WindowPosition.Height;
			Title = Properties.Settings.Default.Title;

		}

		void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e){
			Properties.Settings.Default.WindowPosition = RestoreBounds;
			Properties.Settings.Default.Save();
		}
	}
}