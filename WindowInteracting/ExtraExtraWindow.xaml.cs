using System.Windows;

namespace WindowInteracting{
	public partial class ExtraExtraWindow : Window, IInteractiveWindow{
		public ExtraExtraWindow() => InitializeComponent();

		#region IInteractiveWindow Members
		public void UpdateWindow(string message) => result.Content = message;
        #endregion
    }
}