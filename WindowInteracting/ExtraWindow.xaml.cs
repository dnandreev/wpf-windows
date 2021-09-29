using System.Windows;

namespace WindowInteracting{
	public partial class ExtraWindow : Window, IInteractiveWindow{
		public ExtraWindow() => InitializeComponent();

		#region IInteractiveWindow Members
		public void UpdateWindow(string message) => result.Content = message;
        #endregion
    }
}