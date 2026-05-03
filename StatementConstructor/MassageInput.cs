using static StatementConstructors.Program.NativeMethods;
using static StatementConstructors.StringExtensions;

namespace StatementConstructors {
   public partial class Program {
      private static bool MassageInputFailed(ref string pInput) {
#pragma warning disable CA1847
         if (StringContainsPhrase(pInput, "logical") || pInput.Contains("||") || pInput.Contains("!") ||
            pInput.Contains("==") || pInput.Contains("&&") || pInput.Contains("<=") || pInput.Contains(">="))
            gDoingLogical = true;
#pragma warning restore CA1847
         #region Mutually exclusive words
         if (pInput.Contains("public") && pInput.Contains("private")) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format("\"public\" and \"private\" are mutually exclusive. You said:{0}{1}", Environment.NewLine, pInput),
               "INPUT ERROR", mTimedMessageBoxFlags, 0, 3000);
            return true;
         }
         if (pInput.Contains("internal") && pInput.Contains("external")) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format("\"internal\" and \"extern\" (\"external\") are mutually exclusive. You said:{0}{1}", Environment.NewLine, pInput),
               "INPUT ERROR", mTimedMessageBoxFlags, 0, 3000);
            return true;
         }
         #endregion

         if (pInput.Contains("if phrases"))
            pInput = StringReplaceWord(pInput, "if phrases", "if strings");
         if (pInput.Contains("if the phrase"))
            pInput = StringReplaceWord(pInput, "if the phrases", "if strings");
         //if (pInput.Contains("if the string"))
         //   pInput = StringReplaceWord(pInput, "if the string", "if string");

         if (pInput == "if the strings are equal")
            pInput = "if strings are identical";
         if (pInput == "if strings are equal")
            pInput = "if strings are identical";
         if (pInput == "if strings are equal")
            pInput = "if strings are identical";
         if (pInput == "if string =")
            pInput = "if strings are identical";
         if (pInput == "if string are =")
            pInput = "if strings are identical";
         if (pInput == "if strings are =")
            pInput = "if strings are identical";
         if (pInput == "if strings are the same")
            pInput = "if strings are identical";
         if (pInput == "if string equals")
            pInput = "if strings are identical";
         if (pInput == "if string are equals")
            pInput = "if strings are identical";
         if (pInput == "if string are equal")
            pInput = "if strings are identical";
         if (pInput == "if string equality")
            pInput = "if strings are identical";
         if (pInput == "if equality string")
            pInput = "if strings are identical";
         if (pInput == "if equality strings")
            pInput = "if strings are identical";
         if (pInput == "if the quality string")
            pInput = "if strings are identical";
         if (pInput == "if the quality strings")
            pInput = "if strings are identical";
         if (pInput == "if stringy quality")
            pInput = "if strings are identical";
         if (pInput == "if string the quality")
            pInput = "if strings are identical";
         if (pInput == "if strings equality")
            pInput = "if strings are identical";
         if (pInput == "if strings the quality")
            pInput = "if strings are identical";

         if (pInput == "if string does not =")
            pInput = "if strings are not identical";
         if (pInput == "if strings are not the same")
            pInput = "if strings are not identical";
         if (pInput == "if string does not equal")
            pInput = "if strings are not identical";
         if (pInput == "if strings are not equal")
            pInput = "if strings are not identical";
         if (pInput == "if strings are not =")
            pInput = "if strings are not identical";
         if (pInput == "if strings are not equality")
            pInput = "if strings are not identical";
         if (pInput == "if strings are not the quality")
            pInput = "if strings are not identical";

         if ((pInput == "l") || (pInput == "elsa"))
            pInput = "else";
         if ((pInput == "else sift") || (pInput == "elsa sift"))
            pInput = "else if";
         if (pInput.Contains("sift"))
            pInput = StringReplaceWord(pInput, "sift", "if");
         if (pInput == "format line")
            pInput = "normalize line";

         if (StringContainsPhrase(pInput, "band"))
            pInput = StringReplaceWord(pInput, "band", "and");
         if (StringContainsPhrase(pInput, "banned"))
            pInput = StringReplaceWord(pInput, "banned", "and");
         if (StringContainsPhrase(pInput, "if this string is empty"))
            pInput = "ifStringIsEmpty";
         if (StringContainsPhrase(pInput, "is this string is not empty"))
            pInput = "ifStringIsNotEmpty";
         if (StringContainsPhrase(pInput, "if string contains"))
            pInput = "ifStringContains";
         if (StringContainsPhrase(pInput, "is string does not contain"))
            pInput = "ifStringDoesNotContain";
         if (StringContainsPhrase(pInput, "if this phrase is empty"))
            pInput = "ifStringIsEmpty";
         if (StringContainsPhrase(pInput, "is this phrase is not empty"))
            pInput = "ifStringIsNotEmpty";
         if (StringContainsPhrase(pInput, "if phrase contains"))
            pInput = "ifStringContains";
         if (StringContainsPhrase(pInput, "is phrase does not contain"))
            pInput = "ifStringDoesNotContain";
         if (StringContainsPhrase(pInput, "event handler method"))
            pInput = StringReplaceWord(pInput, "event handler method", "eventHandlerMethod");
         if (StringContainsPhrase(pInput, "event method handler"))
            pInput = StringReplaceWord(pInput, "event method handler", "eventHandlerMethod");
         if (StringContainsPhrase(pInput, "event handler"))
            pInput = StringReplaceWord(pInput, "event handler", "eventHandlerMethod");
         if (StringContainsPhrase(pInput, "event method"))
            pInput = StringReplaceWord(pInput, "event method", "eventHandlerMethod");
         if (StringContainsPhrase(pInput, "eventHandlerMethod this"))
            pInput = StringReplaceWord(pInput, "eventHandlerMethod this", "eventHandlerMethodThis");
#pragma warning disable CA1847
         if (pInput.Contains("#"))
            pInput = StringReplaceWord(pInput, "#", " pound ");
#pragma warning restore CA1847
         if (StringContainsPhrase(pInput, "and region")) {
            pInput = StringReplaceWord(pInput, "and region", "end region");
         }
         if (StringContainsPhrase(pInput, "terminate region")) {
            pInput = StringReplaceWord(pInput, "terminate region", "end region");
         }
         if (StringContainsPhrase(pInput, "pound and"))
            pInput = StringReplaceWord(pInput, "pound and", "end region");
         if (StringContainsPhrase(pInput, "pound end region"))
            pInput = StringReplaceWord(pInput, "pound end region", "end region");
         if (StringContainsPhrase(pInput, "pound end"))
            pInput = StringReplaceWord(pInput, "pound end", "end region");
         if (StringContainsPhrase(pInput, "found region"))
            pInput = StringReplaceWord(pInput, "found region", "pound region");
         if (StringContainsPhrase(pInput, "town region"))
            pInput = StringReplaceWord(pInput, "town region", "pound region");
         if (StringContainsPhrase(pInput, "bound region"))
            pInput = StringReplaceWord(pInput, "bound region", "pound region");
         if (StringContainsPhrase(pInput, "inject")) {
            pInput = StringReplaceWord(pInput, "inject", string.Empty);
            gInjection = true;
         }
         else if (StringContainsPhrase(pInput, "injection")) {
            pInput = StringReplaceWord(pInput, "injection", string.Empty);
            gInjection = true;
         }
         if (StringContainsPhrase(pInput, "send") && (StringContainsPhrase(pInput, "special"))) {
            pInput = StringReplaceWord(pInput, "special", string.Empty);
            gSendFormatting = false;
         }
         if (StringContainsPhrase(pInput, "exit application"))
            pInput = StringReplaceWord(pInput, "exit application", "exit statement");
         if (StringContainsPhrase(pInput, "application exit"))
            pInput = StringReplaceWord(pInput, "application exit", "exit statement");
         if (StringContainsPhrase(pInput, "math for"))
            pInput = StringReplaceWord(pInput, "math for", "math floor");
         if (StringContainsPhrase(pInput, "knot"))
            pInput = StringReplaceWord(pInput, "knot", "not");
         if (StringContainsPhrase(pInput, "truth"))
            pInput = StringReplaceWord(pInput, "truth", "true");
         if (StringContainsPhrase(pInput, "through"))
            pInput = StringReplaceWord(pInput, "through", "true");
         if (StringContainsPhrase(pInput, "spring"))
            pInput = StringReplaceWord(pInput, "spring", "string");
         if (StringContainsPhrase(pInput, "strain"))
            pInput = StringReplaceWord(pInput, "strain", "string");
         if (StringContainsPhrase(pInput, "deep"))
            pInput = StringReplaceWord(pInput, "deep", "beep");
         if (StringContainsPhrase(pInput, "beef"))
            pInput = StringReplaceWord(pInput, "beef", "beep");
         if (StringContainsPhrase(pInput, "beat"))
            pInput = StringReplaceWord(pInput, "beat", "beep");
         if (StringContainsPhrase(pInput, "sound off"))
            pInput = StringReplaceWord(pInput, "sound off", "beep");
         if (StringContainsPhrase(pInput, "be"))
            pInput = StringReplaceWord(pInput, "be", "beep");
         if (StringContainsPhrase(pInput, "hi"))
            pInput = StringReplaceWord(pInput, "hi", "high");
         if (StringContainsPhrase(pInput, "lo"))
            pInput = StringReplaceWord(pInput, "lo", "low");
         if (StringContainsPhrase(pInput, "thread sleep"))
            pInput = StringReplaceWord(pInput, "thread sleep", "sleep");
         if (StringContainsPhrase(pInput, "thread dot sleep"))
            pInput = StringReplaceWord(pInput, "thread dot sleep", "sleep");
         if (StringContainsPhrase(pInput, "thread.sleep"))
            pInput = StringReplaceWord(pInput, "thread.sleep", "sleep");
         if (StringContainsPhrase(pInput, "parts"))
            pInput = StringReplaceWord(pInput, "parts", "parse");
         if (StringContainsPhrase(pInput, "read-only"))
            pInput = StringReplaceWord(pInput, "read-only", "readonly");
         if (StringContainsPhrase(pInput, "can"))
            pInput = StringReplaceWord(pInput, "can", "constructor");
         if (StringContainsPhrase(pInput, "come pound"))
            pInput = StringReplaceWord(pInput, "come pound", "compound");
         if (StringContainsPhrase(pInput, "complex"))
            pInput = StringReplaceWord(pInput, "complex", "compound");
         if (StringContainsPhrase(pInput, "this compound"))
            pInput = StringReplaceWord(pInput, "this compound", "compound this");
         if (StringContainsPhrase(pInput, "this interrupted"))
            pInput = StringReplaceWord(pInput, "this interrupted", "interrupted this");
         if (StringContainsPhrase(pInput, "exclamation mark"))
            pInput = StringReplaceWord(pInput, "exclamation mark", "!");
         if (StringContainsPhrase(pInput, "newpoint"))
            pInput = StringReplaceWord(pInput, "newpoint", "new point");
         if (StringContainsPhrase(pInput, "send keys"))
            pInput = StringReplaceWord(pInput, "send keys", "sendkeys");
         if (StringContainsPhrase(pInput, "sendkeys weight"))
            pInput = StringReplaceWord(pInput, "sendkeys weight", "sendkeys wait");
         if (StringContainsPhrase(pInput, "through"))
            pInput = StringReplaceWord(pInput, "through", "true");
         if (StringContainsPhrase(pInput, "threw"))
            pInput = StringReplaceWord(pInput, "threw", "true");
         if (StringContainsPhrase(pInput, "directory"))
            pInput = StringReplaceWord(pInput, "directory", "folder");

         #region conditionals

         if (StringContainsPhrase(pInput, "l"))
            pInput = StringReplaceWord(pInput, "l", "else");
         if (StringContainsPhrase(pInput, "lc"))
            pInput = StringReplaceWord(pInput, "lc", "else");
         if (StringContainsPhrase(pInput, "elsie"))
            pInput = StringReplaceWord(pInput, "elsie", "else");
         if (StringContainsPhrase(pInput, "elsa"))
            pInput = StringReplaceWord(pInput, "elsa", "else if");
         if (StringContainsPhrase(pInput, "lcf"))
            pInput = StringReplaceWord(pInput, "lcf", "else if");
         if (StringContainsPhrase(pInput, "else is"))
            pInput = StringReplaceWord(pInput, "else is", "else if");
         if (StringContainsPhrase(pInput, "simple this"))
            pInput = StringReplaceWord(pInput, "simple this", "this simple");
         if (StringContainsPhrase(pInput, "if simple"))
            pInput = StringReplaceWord(pInput, "if simple", "if");
         if (StringContainsPhrase(pInput, "if not simple"))
            pInput = StringReplaceWord(pInput, "if not simple", "if not");
         if (StringContainsPhrase(pInput, "if this simple"))
            pInput = StringReplaceWord(pInput, "if this simple", "if this");
         if (StringContainsPhrase(pInput, "if simple this"))
            pInput = StringReplaceWord(pInput, "if simple this", "if this");
         if (StringContainsPhrase(pInput, "if not this simple"))
            pInput = StringReplaceWord(pInput, "if not this simple", "if not this");
         if (StringContainsPhrase(pInput, "if simple not this"))
            pInput = StringReplaceWord(pInput, "if simple not this", "if not this");
         if (StringContainsPhrase(pInput, "else simple"))
            pInput = StringReplaceWord(pInput, "else simple", "else");
         if (StringContainsPhrase(pInput, "simple if"))
            pInput = StringReplaceWord(pInput, "simple if", "if");
         if (StringContainsPhrase(pInput, "simple if else"))
            pInput = StringReplaceWord(pInput, "simple if else", "if else");
         if (StringContainsPhrase(pInput, "this simple"))
            pInput = StringReplaceWord(pInput, "this simple", "this");

         if (StringContainsPhrase(pInput, "in all"))
            pInput = StringReplaceWord(pInput, "in all", "null");
         if (StringContainsPhrase(pInput, "know"))
            pInput = StringReplaceWord(pInput, "know", "null");
         if (StringContainsPhrase(pInput, "noel"))
            pInput = StringReplaceWord(pInput, "noel", "null");
         if (StringContainsPhrase(pInput, "no"))
            pInput = StringReplaceWord(pInput, "no", "null");
         if (StringContainsPhrase(pInput, "noll"))
            pInput = StringReplaceWord(pInput, "noll", "null");
         if (StringContainsPhrase(pInput, "knoll"))
            pInput = StringReplaceWord(pInput, "knoll", "null");
         if (string.Equals(pInput, "is equal to null"))
            pInput = "isEqualToNull";
         if (string.Equals(pInput, "is not equal to null"))
            pInput = "isNotEqualToNull";
         if (StringContainsPhrase(pInput, "if this is equal to null"))
            pInput = StringReplaceWord(pInput, "if this is equal to null", "isEqualToNull this");
         if (StringContainsPhrase(pInput, "if this is null"))
            pInput = StringReplaceWord(pInput, "if this is null", "isEqualToNull this");
         if (StringContainsPhrase(pInput, "if this equals null"))
            pInput = StringReplaceWord(pInput, "if this equals null", "isEqualToNull this");
         if (StringContainsPhrase(pInput, "if this is not null"))
            pInput = StringReplaceWord(pInput, "if this is not null", "isNotEqualToNull this");
         if (StringContainsPhrase(pInput, "if this is not equal to null"))
            pInput = StringReplaceWord(pInput, "if this is not equal to null", "isNotEqualToNull this");
         if (StringContainsPhrase(pInput, "if this does not equal null"))
            pInput = StringReplaceWord(pInput, "if this does not equal null", "isNotEqualToNull this");
         #endregion

         if (StringContainsPhrase(pInput, "abbreviate rectangle"))
            pInput = StringReplaceWord(pInput, "abbreviate rectangle", "RECT");
         if (StringContainsPhrase(pInput, "abbreviate window handle"))
            pInput = StringReplaceWord(pInput, "abbreviate window handle", "HWINDOW");
         if (StringContainsPhrase(pInput, "abbreviate t char"))
            pInput = StringReplaceWord(pInput, "abbreviate t char", "TCHAR");
         if (StringContainsPhrase(pInput, "abbreviate tool strip menu item"))
            pInput = StringReplaceWord(pInput, "abbreviate tool strip menu item", "TSMI");
         if (StringContainsPhrase(pInput, "abbreviate"))
            pInput = StringReplaceWord(pInput, "abbreviate", string.Empty);
         if (StringContainsPhrase(pInput, "scroll bar"))
            pInput = StringReplaceWord(pInput, "scroll bar", "scrollbar");
         if (StringContainsPhrase(pInput, "^"))
            pInput = StringReplaceWord(pInput, "^", "caret");
         if (StringContainsPhrase(pInput, "carrot"))
            pInput = StringReplaceWord(pInput, "carrot", "caret");
         if (StringContainsPhrase(pInput, "bite"))
            pInput = StringReplaceWord(pInput, "bite", "byte");
         if (StringContainsPhrase(pInput, "short byte"))
            pInput = StringReplaceWord(pInput, "short byte", "shortbyte");
         if (StringContainsPhrase(pInput, "struct"))
            pInput = StringReplaceWord(pInput, "struct", "structure");
         if (StringContainsPhrase(pInput, "struck"))
            pInput = StringReplaceWord(pInput, "struck", "structure");
         if (StringContainsPhrase(pInput, "spring"))
            pInput = StringReplaceWord(pInput, "spring", "string");
         if (StringContainsPhrase(pInput, "method"))
            pInput = StringReplaceWord(pInput, "method", "function");
         if (StringContainsPhrase(pInput, "function event"))
            pInput = StringReplaceWord(pInput, "function event", "event function");
         if (StringContainsPhrase(pInput, "variable"))
            pInput = StringReplaceWord(pInput, "variable", "var");
         if (StringContainsPhrase(pInput, "integers"))
            pInput = StringReplaceWord(pInput, "integers", "integer");
         if (StringContainsPhrase(pInput, "you integer"))
            pInput = StringReplaceWord(pInput, "you integer", "unsigned integer");
         if (StringContainsPhrase(pInput, "cap"))
            pInput = StringReplaceWord(pInput, "cap", "caps");
         if (StringContainsPhrase(pInput, "buy"))
            pInput = StringReplaceWord(pInput, "buy", "by");
         if (StringContainsPhrase(pInput, "oar"))
            pInput = StringReplaceWord(pInput, "oar", "or");
         if (StringContainsPhrase(pInput, "ore"))
            pInput = StringReplaceWord(pInput, "ore", "or");
         if (StringContainsPhrase(pInput, "avoid"))
            pInput = StringReplaceWord(pInput, "avoid", "void");
         if (StringContainsPhrase(pInput, "lloyd"))
            pInput = StringReplaceWord(pInput, "lloyd", "void");
         if (StringContainsPhrase(pInput, "client size"))
            pInput = StringReplaceWord(pInput, "client size", "clientsize");
         if (StringContainsPhrase(pInput, "clientSize"))
            pInput = StringReplaceWord(pInput, "clientSize", "clientsize");
         if (StringContainsPhrase(pInput, "settings default"))
            pInput = StringReplaceWord(pInput, "settings default", "default settings");
         if (StringContainsPhrase(pInput, "save settings default"))
            pInput = StringReplaceWord(pInput, "save settings default", "save default settings");
         if (StringContainsPhrase(pInput, "save settings"))
            pInput = StringReplaceWord(pInput, "save settings", "save default settings");
         if (StringContainsPhrase(pInput, "knot"))
            pInput = StringReplaceWord(pInput, "knot", "not");
         if (StringContainsPhrase(pInput, "not while"))
            pInput = StringReplaceWord(pInput, "not while", "while not");
         if (StringContainsPhrase(pInput, "external"))
            pInput = StringReplaceWord(pInput, "external", "extern");
         if (StringContainsPhrase(pInput, "e numb"))
            pInput = StringReplaceWord(pInput, "e numb", "enumerate");
         if (StringContainsPhrase(pInput, "enum"))
            pInput = StringReplaceWord(pInput, "enum", "enumerate");
         if (StringContainsPhrase(pInput, "enumerator"))
            pInput = StringReplaceWord(pInput, "enumerator", "enumerate");
         if (StringContainsPhrase(pInput, "private protected"))
            pInput = StringReplaceWord(pInput, "private protected", "privateProtected");
         if (StringContainsPhrase(pInput, "protected internal"))
            pInput = StringReplaceWord(pInput, "protected internal", "protectedInternal");

         #region function keys
         if (StringContainsPhrase(pInput, "function key"))
            pInput = StringReplaceWord(pInput, "function key", "f");
         if (StringContainsPhrase(pInput, "f key"))
            pInput = StringReplaceWord(pInput, "f key", "f");
         if (StringContainsPhrase(pInput, "fkey"))
            pInput = StringReplaceWord(pInput, "fkey", "f");
         if (StringContainsPhrase(pInput, "f 1"))
            pInput = StringReplaceWord(pInput, "f 1", "fkey1");
         if (StringContainsPhrase(pInput, "f 2"))
            pInput = StringReplaceWord(pInput, "f 2", "fkey2");
         if (StringContainsPhrase(pInput, "f 3"))
            pInput = StringReplaceWord(pInput, "f 3", "fkey3");
         if (StringContainsPhrase(pInput, "f 4"))
            pInput = StringReplaceWord(pInput, "f 4", "fkey4");
         if (StringContainsPhrase(pInput, "f 5"))
            pInput = StringReplaceWord(pInput, "f 5", "fkey5");
         if (StringContainsPhrase(pInput, "f 6"))
            pInput = StringReplaceWord(pInput, "f 6", "fkey6");
         if (StringContainsPhrase(pInput, "f 7"))
            pInput = StringReplaceWord(pInput, "f 7", "fkey7");
         if (StringContainsPhrase(pInput, "f 8"))
            pInput = StringReplaceWord(pInput, "f 8", "fkey8");
         if (StringContainsPhrase(pInput, "f 9"))
            pInput = StringReplaceWord(pInput, "f 9", "fkey9");
         if (StringContainsPhrase(pInput, "f 10"))
            pInput = StringReplaceWord(pInput, "f 10", "fkey10");
         if (StringContainsPhrase(pInput, "f 11"))
            pInput = StringReplaceWord(pInput, "f 11", "fkey11");
         if (StringContainsPhrase(pInput, "f 12"))
            pInput = StringReplaceWord(pInput, "f 12", "fkey12");
         if (StringContainsPhrase(pInput, "f 13"))
            pInput = StringReplaceWord(pInput, "f 13", "fkey13");
         if (StringContainsPhrase(pInput, "f 14"))
            pInput = StringReplaceWord(pInput, "f 14", "fkey14");
         if (StringContainsPhrase(pInput, "f 15"))
            pInput = StringReplaceWord(pInput, "f 15", "fkey15");
         if (StringContainsPhrase(pInput, "f 16"))
            pInput = StringReplaceWord(pInput, "f 16", "fkey16");
         if (StringContainsPhrase(pInput, "f 17"))
            pInput = StringReplaceWord(pInput, "f 17", "fkey17");
         if (StringContainsPhrase(pInput, "f 18"))
            pInput = StringReplaceWord(pInput, "f 18", "fkey18");
         if (StringContainsPhrase(pInput, "f 19"))
            pInput = StringReplaceWord(pInput, "f 19", "fkey19");
         if (StringContainsPhrase(pInput, "f 20"))
            pInput = StringReplaceWord(pInput, "f 20", "fkey20");
         if (StringContainsPhrase(pInput, "f 21"))
            pInput = StringReplaceWord(pInput, "f 21", "fkey21");
         if (StringContainsPhrase(pInput, "f 22"))
            pInput = StringReplaceWord(pInput, "f 22", "fkey22");
         if (StringContainsPhrase(pInput, "f 23"))
            pInput = StringReplaceWord(pInput, "f 23", "fkey23");
         if (StringContainsPhrase(pInput, "f 24"))
            pInput = StringReplaceWord(pInput, "f 24", "fkey24");
         if (StringContainsPhrase(pInput, "f one"))
            pInput = StringReplaceWord(pInput, "f one", "fkey1");
         if (StringContainsPhrase(pInput, "f two"))
            pInput = StringReplaceWord(pInput, "f two", "fkey2");
         if (StringContainsPhrase(pInput, "f to"))
            pInput = StringReplaceWord(pInput, "f to", "fkey2");
         if (StringContainsPhrase(pInput, "f too"))
            pInput = StringReplaceWord(pInput, "f too", "fkey2");
         if (StringContainsPhrase(pInput, "f three"))
            pInput = StringReplaceWord(pInput, "f three", "fkey3");
         if (StringContainsPhrase(pInput, "f four"))
            pInput = StringReplaceWord(pInput, "f four", "fkey4");
         if (StringContainsPhrase(pInput, "f fore"))
            pInput = StringReplaceWord(pInput, "f fore", "fkey4");
         if (StringContainsPhrase(pInput, "f for"))
            pInput = StringReplaceWord(pInput, "f for", "fkey4");
         if (StringContainsPhrase(pInput, "f five"))
            pInput = StringReplaceWord(pInput, "f five", "fkey5");
         if (StringContainsPhrase(pInput, "f six"))
            pInput = StringReplaceWord(pInput, "f six", "fkey6");
         if (StringContainsPhrase(pInput, "f sax"))
            pInput = StringReplaceWord(pInput, "f sax", "fkey6");
         if (StringContainsPhrase(pInput, "f sex"))
            pInput = StringReplaceWord(pInput, "f sex", "fkey6");
         if (StringContainsPhrase(pInput, "f seven"))
            pInput = StringReplaceWord(pInput, "f seven", "fkey7");
         if (StringContainsPhrase(pInput, "f eight"))
            pInput = StringReplaceWord(pInput, "f eight", "fkey8");
         if (StringContainsPhrase(pInput, "f ate"))
            pInput = StringReplaceWord(pInput, "f ate", "fkey8");
         if (StringContainsPhrase(pInput, "f nine"))
            pInput = StringReplaceWord(pInput, "f nine", "fkey9");
         if (StringContainsPhrase(pInput, "f ten"))
            pInput = StringReplaceWord(pInput, "f ten", "fkey10");
         if (StringContainsPhrase(pInput, "f tin"))
            pInput = StringReplaceWord(pInput, "f tin", "fkey10");
         if (StringContainsPhrase(pInput, "f eleven"))
            pInput = StringReplaceWord(pInput, "f eleven", "fkey11");
         if (StringContainsPhrase(pInput, "f twelve"))
            pInput = StringReplaceWord(pInput, "f twelve", "fkey12");
         if (StringContainsPhrase(pInput, "f thirteen"))
            pInput = StringReplaceWord(pInput, "f thirteen", "fkey13");
         if (StringContainsPhrase(pInput, "f fourteen"))
            pInput = StringReplaceWord(pInput, "f fourteen", "fkey14");
         if (StringContainsPhrase(pInput, "f fifteen"))
            pInput = StringReplaceWord(pInput, "f fifteen", "fkey15");
         if (StringContainsPhrase(pInput, "f sixteen"))
            pInput = StringReplaceWord(pInput, "f sixteen", "fkey16");
         if (StringContainsPhrase(pInput, "f seventeen"))
            pInput = StringReplaceWord(pInput, "f seventeen", "fkey17");
         if (StringContainsPhrase(pInput, "f eighteen"))
            pInput = StringReplaceWord(pInput, "f eighteen", "fkey18");
         if (StringContainsPhrase(pInput, "f nineteen"))
            pInput = StringReplaceWord(pInput, "f nineteen", "fkey19");
         if (StringContainsPhrase(pInput, "f twenty"))
            pInput = StringReplaceWord(pInput, "f twenty", "fkey20");
         if (StringContainsPhrase(pInput, "f twenty-one"))
            pInput = StringReplaceWord(pInput, "f twenty-one", "fkey21");
         if (StringContainsPhrase(pInput, "f twenty-two"))
            pInput = StringReplaceWord(pInput, "f twenty-two", "fkey22");
         if (StringContainsPhrase(pInput, "f twenty-three"))
            pInput = StringReplaceWord(pInput, "f twenty-three", "fkey23");
         if (StringContainsPhrase(pInput, "f twenty-four"))
            pInput = StringReplaceWord(pInput, "f twenty-four", "fkey24");
         #endregion

         if (StringContainsPhrase(pInput, "weight"))
            pInput = StringReplaceWord(pInput, "weight", "wait");
         if (StringContainsPhrase(pInput, "found"))
            pInput = StringReplaceWord(pInput, "found", "pound");
         if (StringContainsPhrase(pInput, "TXT"))
            pInput = StringReplaceWord(pInput, "TXT", "txt");
         if (StringContainsPhrase(pInput, ".txt"))
            pInput = StringReplaceWord(pInput, ".txt", "dot text");
         if (StringContainsPhrase(pInput, "zero"))
            pInput = StringReplaceWord(pInput, "zero", "0");
         if (StringContainsPhrase(pInput, "2"))
            pInput = StringReplaceWord(pInput, "2", "to");
         if (StringContainsPhrase(pInput, "two"))
            pInput = StringReplaceWord(pInput, "two", "to");
         if (StringContainsPhrase(pInput, "too"))
            pInput = StringReplaceWord(pInput, "too", "to");
         if (StringContainsPhrase(pInput, "write"))
            pInput = StringReplaceWord(pInput, "write", "right");
         if (StringContainsPhrase(pInput, "wright"))
            pInput = StringReplaceWord(pInput, "wright", "right");
         if (StringContainsPhrase(pInput, "parens"))
            pInput = StringReplaceWord(pInput, "parens", "paren");
         if (StringContainsPhrase(pInput, "parentheses"))
            pInput = StringReplaceWord(pInput, "parentheses", "paren");
         if (StringContainsPhrase(pInput, "parents"))
            pInput = StringReplaceWord(pInput, "parents", "paren");
         if (StringContainsPhrase(pInput, "falls"))
            pInput = StringReplaceWord(pInput, "falls", "false");
         if (StringContainsPhrase(pInput, "fall"))
            pInput = StringReplaceWord(pInput, "fall", "false");
         if (StringContainsPhrase(pInput, "4"))
            pInput = StringReplaceWord(pInput, "4", "for");
         if (StringContainsPhrase(pInput, "four"))
            pInput = StringReplaceWord(pInput, "four", "for");
         if (StringContainsPhrase(pInput, "simple for"))
            pInput = StringReplaceWord(pInput, "simple for", "for simple");
         if (StringContainsPhrase(pInput, "simple integer for"))
            pInput = StringReplaceWord(pInput, "simple integer for", "for simple integer");
         if (StringContainsPhrase(pInput, "for integer simple"))
            pInput = StringReplaceWord(pInput, "for integer simple", "for simple integer");
         if (StringContainsPhrase(pInput, "you"))
            pInput = StringReplaceWord(pInput, "you", "unsigned");
         if (StringContainsPhrase(pInput, "u"))
            pInput = StringReplaceWord(pInput, "u", "unsigned");
         if (StringContainsPhrase(pInput, "int"))
            pInput = StringReplaceWord(pInput, "int", "integer");
         if (StringContainsPhrase(pInput, "uint"))
            pInput = StringReplaceWord(pInput, "uint", "unsigned integer");
         if (StringContainsPhrase(pInput, "integer sixteen"))
            pInput = StringReplaceWord(pInput, "integer sixteen", "int16");
         if (StringContainsPhrase(pInput, "integer 16"))
            pInput = StringReplaceWord(pInput, "integer 16", "int16");
         if (StringContainsPhrase(pInput, "integer 32"))
            pInput = StringReplaceWord(pInput, "integer 32", "int32");
         if (StringContainsPhrase(pInput, "integer thirty-two"))
            pInput = StringReplaceWord(pInput, "integer thirty-two", "int32");
         if (StringContainsPhrase(pInput, "integer thirty two"))
            pInput = StringReplaceWord(pInput, "integer thirty two", "int32");
         if (StringContainsPhrase(pInput, "integer thirty-to"))
            pInput = StringReplaceWord(pInput, "integer thirty-to", "int32");
         if (StringContainsPhrase(pInput, "integer 64"))
            pInput = StringReplaceWord(pInput, "integer 64", "int64");
         if (StringContainsPhrase(pInput, "integer sixty-four"))
            pInput = StringReplaceWord(pInput, "integer sixty-four", "int64");
         if (StringContainsPhrase(pInput, "integer sixty four"))
            pInput = StringReplaceWord(pInput, "integer sixty four", "int64");
         if (StringContainsPhrase(pInput, "integer sixty-for"))
            pInput = StringReplaceWord(pInput, "integer sixty-for", "int64");
         if (StringContainsPhrase(pInput, "unsigned integer 16"))
            pInput = StringReplaceWord(pInput, "unsigned integer 16", "uint16");
         if (StringContainsPhrase(pInput, "unsigned integer sixteen"))
            pInput = StringReplaceWord(pInput, "unsigned integer sixteen", "uint16");
         if (StringContainsPhrase(pInput, "unsigned integer 32"))
            pInput = StringReplaceWord(pInput, "unsigned integer 32", "uint32");
         if (StringContainsPhrase(pInput, "unsigned integer thirty-two"))
            pInput = StringReplaceWord(pInput, "unsigned integer thirty-two", "uint32");
         if (StringContainsPhrase(pInput, "unsigned integer thirty two"))
            pInput = StringReplaceWord(pInput, "unsigned integer thirty two", "uint32");
         if (StringContainsPhrase(pInput, "unsigned integer thirty-to"))
            pInput = StringReplaceWord(pInput, "unsigned integer thirty-to", "uint32");
         if (StringContainsPhrase(pInput, "unsigned integer 64"))
            pInput = StringReplaceWord(pInput, "unsigned integer 64", "uint64");
         if (StringContainsPhrase(pInput, "unsigned integer sixty-four"))
            pInput = StringReplaceWord(pInput, "unsigned integer sixty-four", "uint64");
         if (StringContainsPhrase(pInput, "unsigned integer sixty four"))
            pInput = StringReplaceWord(pInput, "unsigned integer sixty four", "uint64");
         if (StringContainsPhrase(pInput, "unsigned integer sixty-for"))
            pInput = StringReplaceWord(pInput, "unsigned integer sixty-for", "uint64");
         if (StringContainsPhrase(pInput, "unsigned long"))
            pInput = StringReplaceWord(pInput, "unsigned long", "ulong");
         if (StringContainsPhrase(pInput, "unsigned short"))
            pInput = StringReplaceWord(pInput, "unsigned short", "ushort");
         if (StringContainsPhrase(pInput, "due"))
            pInput = StringReplaceWord(pInput, "due", "do");
         if (StringContainsPhrase(pInput, "weight"))
            pInput = StringReplaceWord(pInput, "weight", "wait");
         if (StringContainsPhrase(pInput, "semicolon"))
            pInput = StringReplaceWord(pInput, "semicolon", ";");
         if (StringContainsPhrase(pInput, "boolean"))
            pInput = StringReplaceWord(pInput, "boolean", "bool");
         if (StringContainsPhrase(pInput, "bullying"))
            pInput = StringReplaceWord(pInput, "bullying", "bool");
         if (StringContainsPhrase(pInput, "unsigned"))
            pInput = StringReplaceWord(pInput, "u ", "unsigned ");
         if (StringContainsPhrase(pInput, "read-only"))
            pInput = StringReplaceWord(pInput, "read-only", "readonly");
         if (StringContainsPhrase(pInput, "constance"))
            pInput = StringReplaceWord(pInput, "constance", "constant");
         if (StringContainsPhrase(pInput, "const"))
            pInput = StringReplaceWord(pInput, "const", "constant");
         if (StringContainsPhrase(pInput, "ref "))
            pInput = StringReplaceWord(pInput, "ref ", "reference ");
         if (StringContainsPhrase(pInput, "formatted"))
            pInput = StringReplaceWord(pInput, "formatted", "format");
         if (StringContainsPhrase(pInput, "message box"))
            pInput = StringReplaceWord(pInput, "message box", "messagebox");
         if (pInput.Contains("maximum"))
            pInput = pInput.Replace("maximum", "max");
         if (pInput.Contains("minimum"))
            pInput = pInput.Replace("minimum", "min");
         if (pInput.Contains("<="))
            pInput = pInput.Replace("<=", "less than or equals to");
         if (pInput.Contains(">="))
            pInput = pInput.Replace(">=", "greater than or equals to");
         if (pInput.Contains("!="))
            pInput = pInput.Replace("!=", "not equals");
         if (pInput.Contains("+="))
            pInput = pInput.Replace("+=", "plus equals");
         if (pInput.Contains("-="))
            pInput = pInput.Replace("-=", "minus equals");
         if (pInput.Contains("*="))
            pInput = pInput.Replace("*=", "times equals");
         if (pInput.Contains("/="))
            pInput = pInput.Replace("/=", "divided by equals");
         if (pInput.Contains("=="))
            pInput = pInput.Replace("==", "logical equals");
#pragma warning disable CA1847
         if (pInput.Contains("="))
            pInput = pInput.Replace("=", "equals");
#pragma warning restore CA1847
         if (StringContainsPhrase(pInput, "equal"))
            pInput = StringReplaceWord(pInput, "equal", "equals");
         if (StringContainsPhrase(pInput, "is equal to"))
            pInput = StringReplaceWord(pInput, "is equal to", "equals");
         if (StringContainsPhrase(pInput, "if string is equals to"))
            pInput = StringReplaceWord(pInput, "if string is equals to", "if string equals");
         if (StringContainsPhrase(pInput, "if string is not equals to"))
            pInput = StringReplaceWord(pInput, "if string is not equals to", "if not string equals");
         if (StringContainsPhrase(pInput, "if string does not equals"))
            pInput = StringReplaceWord(pInput, "if string does not equals", "if not string equals");
         if (StringContainsPhrase(pInput, "character"))
            pInput = StringReplaceWord(pInput, "character", "char");
         if (StringContainsPhrase(pInput, "equals new"))
            pInput = StringReplaceWord(pInput, "equals new", "equalsnew");
         if (StringContainsPhrase(pInput, "unsigned integer pointer"))
            pInput = StringReplaceWord(pInput, "unsigned integer pointer", "unsignedintegerpointer");
         if (StringContainsPhrase(pInput, "integer pointer"))
            pInput = StringReplaceWord(pInput, "integer pointer", "integerpointer");
         if (StringContainsPhrase(pInput, "environmental"))
            pInput = StringReplaceWord(pInput, "environmental", "environment");
         if (StringContainsPhrase(pInput, "environment lie new"))
            pInput = StringReplaceWord(pInput, "lie new", "line new");
         if (StringContainsPhrase(pInput, "shall execute"))
            pInput = StringReplaceWord(pInput, "shall execute", "shell execute");
         if (StringContainsPhrase(pInput, "capitals"))
            pInput = StringReplaceWord(pInput, "capitals", "pascal");
         if (StringContainsPhrase(pInput, "capital"))
            pInput = StringReplaceWord(pInput, "capital", "pascal");
         if (StringContainsPhrase(pInput, "with as size"))
            pInput = StringReplaceWord(pInput, "with as size", "width");
         if (StringContainsPhrase(pInput, "vertical scrollbar with"))
            pInput = StringReplaceWord(pInput, "vertical scrollbar with", "vertical scrollbar width");
         if (StringContainsPhrase(pInput, "scrollbar with"))
            pInput = StringReplaceWord(pInput, "scrollbar with", "scrollbar width");
         if (StringContainsPhrase(pInput, ".with as size"))
            pInput = StringReplaceWord(pInput, ".with as size", "dot width");
         if (StringContainsPhrase(pInput, ".with"))
            pInput = StringReplaceWord(pInput, ".with", "dot width");
         if (StringContainsPhrase(pInput, "dot with as size"))
            pInput = StringReplaceWord(pInput, "dot with as size", "dot width");
         if (StringContainsPhrase(pInput, "dot with"))
            pInput = StringReplaceWord(pInput, "dot with", "dot width");
         if (StringContainsPhrase(pInput, "is not equals to"))
            pInput = StringReplaceWord(pInput, "is not equals to", "is not");
         if (StringContainsPhrase(pInput, "Fred sleep"))
            pInput = StringReplaceWord(pInput, "Fred sleep", "thread sleep");
         if (StringContainsPhrase(pInput, "thread.sleep"))
            pInput = StringReplaceWord(pInput, "thread.sleep", "thread sleep");
         if (StringContainsPhrase(pInput, "thread dot sleep"))
            pInput = StringReplaceWord(pInput, "thread dot sleep", "thread sleep");
         if (StringContainsPhrase(pInput, "integerpointer"))
            pInput = StringReplaceWord(pInput, "integerpointer", "IntPtr");
         if (StringContainsPhrase(pInput, "unsignedintegerpointer"))
            pInput = StringReplaceWord(pInput, "unsignedintegerpointer", "UIntPtr");
         if (StringContainsPhrase(pInput, "tool strip menu item"))
            pInput = StringReplaceWord(pInput, "tool strip menu item", "ToolStripMenuItem");
         if (StringContainsPhrase(pInput, "dry"))
            pInput = StringReplaceWord(pInput, "dry", "try");
         if (StringContainsPhrase(pInput, "double try parse"))
            pInput = StringReplaceWord(pInput, "double try parse", "try parse double");
         if (StringContainsPhrase(pInput, "float try parse"))
            pInput = StringReplaceWord(pInput, "float try parse", "try parse float");
         if (StringContainsPhrase(pInput, "integer try parse"))
            pInput = StringReplaceWord(pInput, "integer try parse", "try parse integer");
         if (StringContainsPhrase(pInput, "catch interrupted"))
            pInput = StringReplaceWord(pInput, "catch interrupted", "catchpartial");
         if (StringContainsPhrase(pInput, "if interrupted"))
            pInput = StringReplaceWord(pInput, "if interrupted", "ifpartial");
         if (StringContainsPhrase(pInput, "else interrupted"))
            pInput = StringReplaceWord(pInput, "else interrupted", "elsepartial");
         if (StringContainsPhrase(pInput, "else ifpartial"))
            pInput = StringReplaceWord(pInput, "else ifpartial", "elseifpartial");
         if (StringContainsPhrase(pInput, "else if interrupted"))
            pInput = StringReplaceWord(pInput, "else if interrupted", "elseifpartial");
         if (StringContainsPhrase(pInput, "try interrupted"))
            pInput = StringReplaceWord(pInput, "try interrupted", "trypartial");

         pInput = StringReplaceWord(pInput, "check box", "CheckBox");
         pInput = StringReplaceWord(pInput, "text box", "TextBox");
         pInput = StringReplaceWord(pInput, "rich text box", "RichTextBox");
         pInput = StringReplaceWord(pInput, "radio button", "RadioButton");
         pInput = StringReplaceWord(pInput, "checkbox", "CheckBox");
         pInput = StringReplaceWord(pInput, "textbox", "TextBox");
         pInput = StringReplaceWord(pInput, "richtextbox", "RichTextBox");
         pInput = StringReplaceWord(pInput, "radiobutton", "RadioButton");

         pInput = CompressWhiteSpace(pInput);
         pInput = pInput.Replace("\t", " ");
         //_ = MessageBoxTimeout(IntPtr.Zero, pInput, "pInput finally", mTimedMessageBoxFlags, 0, 3000);
         return false;
      }

      private static void ForceLeadingSpace() {
         //if (gAddASpace && !gInjection)
         SendKeys.SendWait(" ");
      }

      private static void GetLeading() {
         //string firstLeading = string.Empty, holdClipboard = string.Empty;
         //try {
         //   if (Clipboard.ContainsText())
         //      holdClipboard = Clipboard.GetText();
         //   Clipboard.Clear();
         //   SendKeys.SendWait("+{LEFT}");
         //   SendKeys.SendWait("^c");
         //   SendKeys.SendWait("{RIGHT}");
         //   firstLeading = Clipboard.GetText();
         //   if (string.IsNullOrEmpty(firstLeading) || firstLeading.Contains(Environment.NewLine)) {
         //      if (!string.IsNullOrEmpty(holdClipboard))
         //         Clipboard.SetText(holdClipboard);
         //      gAddASpace = false;
         //      return;//accept the defaults - at the very beginning of a line
         //  }
         //   if ((firstLeading == "\"") || (firstLeading == "(") || (firstLeading == "["))
         //      gAddASpace = false;
         //   else if ((firstLeading == "{") || (firstLeading == "}") || (firstLeading == ";") || ((firstLeading == ")") && !gDoingLogical)) {
         //      gAddASpace = true;//Add a space after the statement termination
         //      SendKeys.SendWait("{END}");
         //      if (!gInjection) {
         //         gAddASpace = false;//Override the previous true
         //         SendKeys.SendWait("{ENTER}");
         //     }
         //  }
         //   else
         gAddASpace = true;
         //    if (!String.IsNullOrEmpty(holdClipboard))
         //       Clipboard.SetText(holdClipboard);
         //}
         // catch (Exception pException) {
         //    _ = MessageBoxTimeout(IntPtr.Zero, string.Format("GetLeading Clipboard exception - MESSAGE: {0}", pException.ToString()), 
         //       "ERROR",  mTimedMessageBoxFlags, 0, 3000);
         //}
      }
   }
}
