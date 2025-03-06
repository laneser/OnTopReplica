using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace OnTopReplica {
    /// <summary>
    /// Provides methods to capture window contents for color keying
    /// </summary>
    internal static class WindowPrinting {
        /// <summary>
        /// Captures the window into the provided device context
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);
    }
}