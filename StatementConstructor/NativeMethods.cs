using System.Runtime.InteropServices;
using System.Text;

namespace StatementConstructors {
   public partial class Program {
      internal static class NativeMethods {
#pragma warning disable IDE1006 // Naming Styles - These are native methods, so we want to preserve the original names
#pragma warning disable SYSLIB1054
         [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
         public static extern int MessageBoxTimeout(IntPtr hWnd, String lpText, String lpCaption, uint uType, Int16 wLanguageId, Int32 dwMilliseconds);

         [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
         public static extern int GetWindowTextLength(IntPtr hWnd);

         [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
         public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

         [DllImport("user32.dll")]
         [return: MarshalAs(UnmanagedType.Bool)]
         public static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

         [DllImport("user32.dll", SetLastError = true)]
         public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

         [DllImport("user32.dll")]
         [return: MarshalAs(UnmanagedType.Bool)]
         public static extern bool IsIconic(IntPtr hWnd);

         [DllImport("user32.dll")]
         [return: MarshalAs(UnmanagedType.Bool)]
         public static extern bool IsWindow(IntPtr hWnd);

         [DllImport("User32.dll")]
         static public extern int SetForegroundWindow(IntPtr hwnd);

         [DllImport("user32.dll")]
         static public extern IntPtr GetForegroundWindow();

         [DllImport("user32.dll", SetLastError = true)]
         public static extern IntPtr SetActiveWindow(IntPtr hWnd);

         [DllImport("user32.dll")]
         public static extern bool SetProcessDPIAware();

         [StructLayout(LayoutKind.Sequential)]
         public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public readonly int Width() { return (Right - Left); }
            public readonly int Height() { return (Bottom - Top); }
         }

         [StructLayout(LayoutKind.Sequential)]
         public struct WINDOWPLACEMENT {
            [Flags]
            public enum Flags : uint {
               WPF_ASYNCWINDOWPLACEMENT = 0x0004,
               WPF_RESTORETOMAXIMIZED = 0x0002,
               WPF_SETMINPOSITION = 0x0001
            }
            public uint length;
            public Flags flags;//uint flags;
            public uint showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public RECT rcNormalPosition;
         }

         public enum ShowWindowEnum {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
#pragma warning disable CA1069
            Maximize = 3,
#pragma warning restore CA1069
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
         };
         public static uint mTimedMessageBoxFlags = /*MB_OK*/ 0x00000000 | /*MB_SETFOREGROUND*/  0x00010000 |
            /*MB_SYSTEMMODAL*/ 0x00001000 | (uint)MessageBoxIcon.Stop;
      }
#pragma warning restore SYSLIB1054
#pragma warning restore IDE1006
   }
}