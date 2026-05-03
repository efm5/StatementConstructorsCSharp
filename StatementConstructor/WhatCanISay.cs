using System.Diagnostics;
using System.Text;
using StatementConstructors.Properties;
using static StatementConstructors.Program.NativeMethods;

namespace StatementConstructors {
   public partial class WhatCanISay : Form {
      private List<string> mValues = [];

      public WhatCanISay() {
         InitializeComponent();
         if (Settings.Default.FirstDisplay)
            AdjustForResolution();
         Location = Settings.Default.Location;
         Size = Settings.Default.Size;
      }

      private void LayoutForm() {
         primaryPanel.AutoScrollMinSize = ClientSize;
         foreach (TextBox textbox in primaryPanel.Controls)
            if (textbox != directionsTextBox)
               textbox.Dispose();
         directionsTextBox.Font = Settings.Default.Font;
         try {
            directionsTextBox.Text = File.ReadAllText(Application.StartupPath + "\\WhatYouCanSay.txt");
         }
         catch (Exception pException) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format("A problem occurred trying to read the file:{0}{1}{0}{2}", Environment.NewLine,
               Application.StartupPath + "\\WhatYouCanSay.txt", pException.ToString()),
               "File.ReadAllText ERROR", mTimedMessageBoxFlags, 0, 3000);
            directionsTextBox.Text = string.Format("A problem occurred trying to read the file:{0}{1}", Environment.NewLine,
               Application.StartupPath + "\\WhatYouCanSay.txt");
         }
         directionsTextBox.BackColor = Color.White;
         directionsTextBox.Select(0, 0);
         directionsTextBox.Width = ClientSize.Width - 2;
         try {
            List<string> values = [
               "normalize line",
               "inject or injection",
               "variable or var",
               "character or char",
               "int or integer",
               "u or unsigned",
               "bool or boolean",
               "byte and short byte",
               "double and float",
               "short and long",
               "u long or unsigned long",
               "u short or unsigned short",
               "int 16, int 32 and int 64",
               "u int 16, u int 32",
               "and u int 64",
               "(or unsigned integer […])",
               "[type] array (e.g. int array)",
               "list or [typed] list",
               "(e.g. string list)",
               "structure or struct",
               "function or method and class",
               "virtual and override",
               "constant or const and static",
               "private or public",
               "(but not both at once)",
               "internal and extern (or external)",
               "(but not both at once)",
               "protected and private protected",
               "protected internal",
               "abstract and async",
               "event and sealed",
               "unsafe and volatile",
               "enumerate or enum",
               "void and read-only",
               "ref or reference",
               "out and in",
               "(but not both at once)",
               "messagebox or message box",
               "for each",
               "for each [variable type]",
               "equals new (after type and name)",
               "pound region or",
               "pound region <dictation>",
               "end region",
               "string empty, string.empty",
               "or string dot empty",
               "thread sleep, thread.sleep",
               "or thread dot sleep",
               "compound or complex",
               "(in \"if…\" constructs)",
               "define [special types]",
               "(special types: button",
               "point, size, label,",
               "rectangle, string, TextBox",
               "StringBuilder and Font",
               "cast as <variable type>",
               "cast as this",
               " "//Insert a blank line
           ];
            mValues = values;
            using Graphics graphics = primaryPanel.CreateGraphics();
            SizeF wantedSizeF = new SizeF(50f, 15f), stringSize = new SizeF();

            foreach (string utterance in values) {
               stringSize = graphics.MeasureString(utterance, Settings.Default.Font);
               if (stringSize.Width > wantedSizeF.Width)
                  wantedSizeF.Width = stringSize.Width;
            }
            foreach (string utterance in Program.snippets.Keys) {
               string massaged = string.Empty;
               if (!utterance.Contains("fkey")) {
                  massaged = utterance;
#pragma warning disable CA1847
                  if (massaged.Contains(";"))
                     massaged = massaged.Replace(";", " semicolon");
#pragma warning restore CA1847
                  if (massaged.Contains("equals"))
                     massaged = massaged.Replace("equals", " equal");
                  values.Add(massaged);
                  stringSize = graphics.MeasureString(massaged, Settings.Default.Font);
                  if (stringSize.Width > wantedSizeF.Width)
                     wantedSizeF.Width = stringSize.Width;
               }
            }
            wantedSizeF.Width *= 1.05f;
            Screen foregroundScreen = Screen.FromHandle(Program.gTargetWindow);
            Rectangle workArea = foregroundScreen.WorkingArea; // excludes scrollbars, etc
            int useableWidth = (int)(workArea.Width * 0.9f) - SystemInformation.VerticalScrollBarWidth,
               useableHeight = (int)(workArea.Height * 0.9f) - SystemInformation.HorizontalScrollBarHeight,
               columnWidth = (int)wantedSizeF.Width,
               columnCount = (useableWidth / columnWidth) + 1,
               linesPerColumn = values.Count / columnCount,
               leftoverLines = values.Count % columnCount;
            directionsTextBox.Width = useableWidth - SystemInformation.VerticalScrollBarWidth - 10;
            try {
               TextBox[] textBoxes = new TextBox[columnCount];
               for (int i = 0; i < columnCount; i++) {
                  textBoxes[i] = new TextBox() {
                     Top = directionsTextBox.Bottom + 10,
                     Left = (i * columnWidth) + 5,
                     Width = columnWidth,
                     Height = useableHeight - directionsTextBox.Height - SystemInformation.HorizontalScrollBarHeight - 20,
                     ReadOnly = true,
                     BackColor = Color.White,
                     Font = Settings.Default.Font,
                     Multiline = true,
                     TabIndex = i + 1,
                     ScrollBars = ScrollBars.Vertical,
                     WordWrap = false
                  };
                  primaryPanel.Controls.Add(textBoxes[i]);
               }
               for (int i = 0; i < columnCount; i += 2)
                  textBoxes[i].BackColor = Color.GhostWhite;
               int index = 0;
               foreach (TextBox textbox in textBoxes) {
                  StringBuilder stringBuilder = new StringBuilder();
                  for (int i = 0; i < linesPerColumn; i++)
                     if (!string.IsNullOrEmpty(values[index]))
                        stringBuilder.AppendLine(values[index++]);
                  textbox.Text = stringBuilder.ToString();
               }
               if (leftoverLines != 0) {
                  StringBuilder stringBuilder = new StringBuilder(textBoxes[columnCount - 1].Text);
                  for (int i = 0; i < leftoverLines; i++)
                     stringBuilder.AppendLine(values[index++]);
                  textBoxes[columnCount - 1].Text = stringBuilder.ToString();
               }
            }
            catch (Exception pException) {
               _ = MessageBoxTimeout(IntPtr.Zero, string.Format("MESSAGE: {0}", pException.ToString()),
                  "ERROR", mTimedMessageBoxFlags, 0, 3000);
            }
         }
         catch (Exception pException) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format("MESSAGE: {0}", pException.ToString()), "using Graphics",
               mTimedMessageBoxFlags, 0, 3000);
         }
      }

      private void WhatCanISay_Shown(object pSender, EventArgs pE) {
         Hide();
         LayoutForm();
         Show();
      }

      public static Point CenterFormOnScreen(Form pForm) {
         Screen formScreen = Screen.FromPoint(pForm.Location);
         Rectangle screenRectangle = formScreen.WorkingArea;

         return CenterRectangle(screenRectangle, pForm.Size);
      }

      private static Point CenterRectangle(Rectangle pOuter, Size pInner) {
         return new Point((pOuter.Width - pInner.Width) / 2, (pOuter.Height - pInner.Height) / 2);
      }

      private static void AdjustForResolution() {
         Screen screen = Screen.FromPoint(new Point(100, 100));
         Settings.Default.Size = new Size((int)(screen.WorkingArea.Width * 0.9f), (int)(screen.WorkingArea.Height * 0.9f));
         Settings.Default.Location = CenterRectangle(screen.WorkingArea, Settings.Default.Size);
         if (screen.WorkingArea.Height < 1000)
            Settings.Default.Font = new Font("Consolas", 10, FontStyle.Regular);
         else if (screen.WorkingArea.Height < 2000)
            Settings.Default.Font = new Font("Consolas", 14, FontStyle.Regular);
         else if (screen.WorkingArea.Height < 4000)
            Settings.Default.Font = new Font("Consolas", 22, FontStyle.Regular);
         else
            Settings.Default.Font = new Font("Consolas", 36, FontStyle.Regular);
         Settings.Default.FirstDisplay = false;
         Settings.Default.Save();
      }

      private void WhatCanISay_FormClosing(object pSender, FormClosingEventArgs pE) {
         Settings.Default.Location = Location;
         Settings.Default.Size = Size;
         Settings.Default.Save();
      }

      private void PrimaryPanel_Resize(object pSender, EventArgs pE) {
         directionsTextBox.Width = primaryPanel.Width - SystemInformation.VerticalScrollBarWidth - 10;
      }

      private void ReadTheseDirectionsInATextFileToolStripMenuItem_Click(object pSender, EventArgs pE) {
         string textFile = Application.StartupPath + "\\WhatYouCanSay.txt";
         if (File.Exists(textFile))
            Process.Start(textFile);
         else {
            _ = MessageBoxTimeout(IntPtr.Zero, "File: \"WhatYouCanSay.txt\" could not be found!", "ERROR",
               mTimedMessageBoxFlags, 0, 3000);
         }
      }

      private void CopyAllOfThePossibleUtterancesToTheClipboardToolStripMenuItem_Click(object pSender, EventArgs pE) {
         string forClipboard = "These are some of the things you can say:";
         foreach (string value in mValues)
            forClipboard += Environment.NewLine + value;
         Clipboard.SetText(forClipboard);
      }

      private void FontSelectorToolStripMenuItem_Click(object pSender, EventArgs pE) {
         fontDialog.Font = Settings.Default.Font;
         if ((fontDialog.ShowDialog() != DialogResult.Cancel) && (Settings.Default.Font != fontDialog.Font)) {
            Settings.Default.Font = fontDialog.Font;
            DialogResult = DialogResult.Retry;
         }
      }
   }
}