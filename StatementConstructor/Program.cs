using System.Text;
using static StatementConstructors.Program.NativeMethods;
using static StatementConstructors.StringExtensions;

namespace StatementConstructors {
   public partial class Program {
      private static bool gSendFormatting = true,
#pragma warning disable CS0414 // The next three fields  'Program.gAddASpace' Etc. are assigned but their values are never used – This is spurious
         gAddASpace = false, gInjection = false, gDoingLogical = false;
#pragma warning restore CS0414
      private static string inputParameter = string.Empty;
#pragma warning disable CA2211
      public static IntPtr gTargetWindow = IntPtr.Zero;
#pragma warning restore CA2211
      private static readonly List<string> mBlackList = [
            "ApplicationFrameHost", "HxOutlook", "iexplorer", "SystemSettings", "explorer", "TextInputHost", "Dragon", "Calculator",
            "Music.UI", "ScriptedSandbox64", "MediaMonkey", "MediaMonkey (non-skinned)", "Windows Explorer", "XboxApp",
            "obkagent", "svchost",
            "Grid", "Hotkeys for Dragon", "HyperNote Box", "Search Correct", "SP Quick Panel", "SP Search", "Auto Box", "dictation box"
         ];
      private static readonly int SWITCH_DELAY = 30;

      [STAThread]
#pragma warning disable IDE1006
      static void Main(string[] args) {
#pragma warning restore IDE1006
         string windowTitle = string.Empty;
         SetProcessDPIAware();
         try {
            if (args.Length == 0) {
               _ = MessageBoxTimeout(IntPtr.Zero, "This application requires some commandline argument!", "ERROR",
                  mTimedMessageBoxFlags, 0, 3000);
               return;
            }
            int iterations = 0;
            Thread.Sleep(SWITCH_DELAY);
            gTargetWindow = GetForegroundWindow();
            while ((gTargetWindow == IntPtr.Zero) || !IsWindow(gTargetWindow) ||
               Blacklisted(GetWindowTitle(gTargetWindow))) {
               if (!SendAlternateEscape()) {
                  return;
               }
               gTargetWindow = GetForegroundWindow();
               if (iterations++ > 10) {
                  return;
               }
            }
            if (gTargetWindow == IntPtr.Zero) {
               _ = MessageBoxTimeout(IntPtr.Zero, "There is no active window into which to paste code.", "ERROR",
                  mTimedMessageBoxFlags, 0, 3000);
               return;
            }
            Thread.Sleep(100);
            windowTitle = GetWindowTitle(gTargetWindow).ToLower();
            //DEBUG efm5 2023 04 18 probably reinstate
            //if (windowTitle.Contains("visual studio") ||
            //  windowTitle.Contains("notepad") ||
            //  windowTitle.Contains("pspad"))
            //   ;
            //else {
            //   _ = MessageBoxTimeout(IntPtr.Zero, "Target must be one of: Visual Studio, Notepad or PSPad. It was: " +
            //       Environment.NewLine +
            //      windowTitle, "GetWindowTitle(gTargetWindow)",
            //      mTimedMessageBoxFlags, 0, 5000);
            //   return;
            //}

            inputParameter = string.Join(" ", args).Trim().ToLower();
            //_ = MessageBoxTimeout(IntPtr.Zero, GetWindowTitle(gTargetWindow), "GetWindowTitle(gTargetWindow)", mTimedMessageBoxFlags, 0, 3000);//DEBUG

            SendKeys.SendWait("{Escape}");
            Thread.Sleep(100);

            // handle the case of "what can I say" as a special case
            if (string.Equals(inputParameter, "what can i say", StringComparison.OrdinalIgnoreCase)) {
               DialogResult result = DialogResult.OK;
               do
                  result = WhatCanYouSay();
               while (result == DialogResult.Retry);
               return;
            }
            // handle the case of "normalize line" as a special case
            else if (string.Equals(inputParameter, "normalize line", StringComparison.OrdinalIgnoreCase)) {
               SendKeys.SendWait("{HOME}+{END}^c");
               if (Clipboard.ContainsText()) {
                  string temporary = CompressWhiteSpace(Clipboard.GetText());
                  if (!string.IsNullOrEmpty(temporary)) {
                     Clipboard.SetText(temporary);
                     SendKeys.SendWait("^v");//Take advantage of IntelliSense format-on-paste
                  }
               }
               return;
            }
            // handle "dictate <dictation>" as a special case
            else if (inputParameter.StartsWith("dictate", StringComparison.OrdinalIgnoreCase)) {
               SendKeys.SendWait(inputParameter.Substring(8));
               SendKeys.SendWait("{ESC}");
               return;
            }
            // handle the case of "exercise all the methods" as a special case
            // un-comment the next 4 lines of code to reestablish the "exercise all the methods" functionality
            //else if (string.Equals(inputParameter, "exercise all the methods", StringComparison.OrdinalIgnoreCase)) {
            //   SnippetMethods.PrintThemOut();
            //   return;
            //}
            // you will also need to un-comment the "PrintThemOut()" function in SnippetMethods.cs at or near line number 23            
            if (MassageInputFailed(ref inputParameter))
               return;
            _ = SetForegroundWindow(gTargetWindow);
            _ = SetActiveWindow(gTargetWindow);
            //SendKeys.SendWait("{ESC}");
            GetLeading();
            if (snippets.ContainsKey(inputParameter)) {
               if (snippets.TryGetValue(inputParameter, out string? value))
                  InvokeVoidMethod(value);
               return;
            }
            BuildAndSendVariables(inputParameter);
         }
         catch (Exception e) {
            _ = MessageBoxTimeout(IntPtr.Zero, e.ToString(), "Try/Catch ERROR", mTimedMessageBoxFlags, 0, 3000);
         }
      }

      private static DialogResult WhatCanYouSay() {
         WhatCanISay whatCanISay = new WhatCanISay();
         return whatCanISay.ShowDialog();
      }

      private static bool SendAlternateEscape() {
         int iterations = 0;
         IntPtr newWindowHandle = IntPtr.Zero;

         do {
            SendKeys.SendWait("%{ESC}");
            Thread.Sleep(SWITCH_DELAY);
            newWindowHandle = GetForegroundWindow();
            if (iterations++ == 10) {
               Console.Beep(500, 250);
               Console.Beep(2500, 250);
               return false;
            }
         }
         while (!IsWindow(newWindowHandle));
         if (IsIconic(newWindowHandle)) {
            WINDOWPLACEMENT winPlacement = new WINDOWPLACEMENT();
            GetWindowPlacement(newWindowHandle, ref winPlacement);
            if (winPlacement.flags.HasFlag(WINDOWPLACEMENT.Flags.WPF_RESTORETOMAXIMIZED))
               ShowWindow(newWindowHandle, ShowWindowEnum.ShowMaximized);
            else
               ShowWindow(newWindowHandle, ShowWindowEnum.Restore);
         }
         return true;
      }

      public static string GetWindowTitle(IntPtr pWindowHandle) {
         int length = GetWindowTextLength(pWindowHandle);
         StringBuilder stringBuilder = new StringBuilder(length + 1);
         _ = GetWindowText(pWindowHandle, stringBuilder, stringBuilder.Capacity);
         return stringBuilder.ToString();
      }

      private static bool Blacklisted(string pTitle) {
         if (string.IsNullOrEmpty(pTitle))
            return true;

         foreach (string phrase in mBlackList)
            if (string.Equals(phrase, pTitle, StringComparison.OrdinalIgnoreCase))
               return true;
         return false;
      }
   }
}
