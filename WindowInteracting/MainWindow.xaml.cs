using System.Windows;

namespace WindowInteracting{
	public partial class MainWindow : Window{
		public MainWindow(){
			InitializeComponent();
			ExtraWindow x1Window = new ExtraWindow();
			ExtraExtraWindow x2Window = new ExtraExtraWindow();
			x1Window.Show();
			x2Window.Show();
		}

		void updateWindows(object sender, RoutedEventArgs e){
			for(int i = 0; i < Application.Current.Windows.Count; i++){
				Window t = Application.Current.Windows[i];
				if(t is IInteractiveWindow)
					(t as IInteractiveWindow).UpdateWindow("Hello, World!");
			}
		}
	}
}