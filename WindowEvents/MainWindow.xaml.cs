using System;
using System.Windows;

namespace WindowEvents{
	public partial class MainWindow : Window{
		public MainWindow(){
			InitializeComponent();
			listBox.Items.Add("InitializeComponent");
		}

		void Window_ContentRendered(object sender, EventArgs e) => listBox.Items.Add("ContentRendered");

		void Window_Loaded(object sender, RoutedEventArgs e) => listBox.Items.Add("Loaded");

		void Window_Activated(object sender, EventArgs e) => listBox.Items.Add("Activated");
		
		void Window_Deactivated(object sender, EventArgs e) => listBox.Items.Add("Deactivated");
		
		void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) => e.Cancel = !(bool)new ExtraWindow().ShowDialog();

		void Window_Closed(object sender, EventArgs e) => MessageBox.Show("Closed");
	}
}