using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows;

namespace GlassEffect
{
	class GlassEffectHelper
	{
		[DllImport("DwmApi.dll")] public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Margins pMarInset);
		[StructLayout(LayoutKind.Sequential)]
		public struct Margins
		{
			public int cxLeftWidth;
			public int cxRightWidth;
			public int cyTopHeight;
			public int cyBottomHeight;
		}
		public static Margins GetDpiAdjustedMargins(IntPtr windowHandle, int left, int right, int top, int bottom){
			System.Drawing.Graphics desktop = System.Drawing.Graphics.FromHwnd(windowHandle);
			float DesktopDpiX = desktop.DpiX, DesktopDpiY = desktop.DpiY;
			Margins margins = new Margins();
			margins.cxLeftWidth = Convert.ToInt32(left * (DesktopDpiX / 96));
			margins.cxRightWidth = Convert.ToInt32(right * (DesktopDpiX / 96));
			margins.cyTopHeight = Convert.ToInt32(top * (DesktopDpiY / 96));
			margins.cyBottomHeight = Convert.ToInt32(bottom * (DesktopDpiY / 96));
			return margins;
		}
		public static void ExtendGlass(Window win, int left, int right, int top, int bottom)
		{
			WindowInteropHelper windowInterop = new WindowInteropHelper(win);
			IntPtr windowHandle = windowInterop.Handle;
			HwndSource mainWindowSrc = HwndSource.FromHwnd(windowHandle);
			mainWindowSrc.CompositionTarget.BackgroundColor = System.Windows.Media.Colors.Transparent;
			Margins margins = GetDpiAdjustedMargins(windowHandle, left, right, top, bottom);
			int returnVal = DwmExtendFrameIntoClientArea(mainWindowSrc.Handle, ref margins);
			if(returnVal < 0)
				throw new NotSupportedException("Operation failed.");
		}
	}
}