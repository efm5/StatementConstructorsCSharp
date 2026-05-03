using static StatementConstructors.Program.NativeMethods;
using static StatementConstructors.StringExtensions;

namespace StatementConstructors {
   public partial class Program {
      private static void BuildAndSendVariables(string pInput) {
         string normalizedString = string.Empty, trailingName = pInput, variableType = string.Empty, customTypeCommas = string.Empty,
            customTypePlacement = string.Empty;
         int accessibles = 0, variables = 0, modifier = 0, lengthOfType = 0, construction = 0, capitalize = 0, prefixes = 0;
         bool doEscape = true, definingCustomType = false, casting = false, creatingNew = false,
            //Variable types:
            bytes = false, sbytes = false, objects = false, vars = false, voids = false,
            bools = false, characters = false, decimals = false, doubles = false, floats = false,
            integers = false, int16s = false, int32s = false, int64s = false, unsigneds = false,
            uints = false, uint16s = false, uint32s = false, uint64s = false, longs = false,
            ulongs = false, shorts = false, ushorts = false, integerPointers = false,
            unsignedIntegerPointers = false,
            //Construction:
            lists = false, strings = false, enumerators = false, functions = false, structures = false, classes = false, partials = false,
            equalsNews = false, semicolons = false, forEach = false, paste = false,
            //Accessibility types:
            virtuals = false, overrides = false, constants = false, statics = false, privates = false, publics = false, protecteds = false,
            internals = false, protectedInternals = false, privateProtecteds = false, externals = false, readOnlys = false,
            abstracts = false, asyncs = false, events = false, sealeds = false, unsafes = false, volatiles = false,
            //Case modifiers:
            cases = false, camelCase = false, snakeCase = false, pascalSnakeCase = false, upperCase = false,
            snakes = false, uppers = false, camels = true,//camels is the default
            upperSnakeCase = false,
            //Parameter modifiers:
            references = false, outs = false, ins = false, arrays = false, members = false, globals = false, parameters = false;

         #region contains
         if (StringContainsPhrase(pInput, "internal") && (StringContainsPhrase(pInput, "private") || StringContainsPhrase(pInput, "public"))) {
            _ = _ = _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain both \"internal\" and either of \"private\" or \"public\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         else if (pInput.StartsWith("pound region")) {
            string remains = StringReplaceWord(pInput, "pound region", string.Empty);
            remains = StringExtensions.NormalizeSpacing(remains);
            SendKeys.SendWait("#region{ESC}");
            if (!string.IsNullOrEmpty(remains))
               SendKeys.SendWait(string.Format(" {0}", remains));
            return;
         }
         else if (pInput.StartsWith("clientsize")) {
            SendKeys.SendWait("ClientSize = new Size{(}," + Environment.NewLine + "{)};{UP}{END}{LEFT}");
            return;
         }
         if (pInput.StartsWith("define")) {
            if (!KnownCustomType(pInput, ref variableType, ref customTypeCommas, ref customTypePlacement)) {
               _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "The custom type to define is not recognized. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
               return;
            }
            definingCustomType = true;
         }
         else if (pInput.StartsWith("create new")) {
            creatingNew = true;
            camels = true;
         }
         else if (pInput.StartsWith("for each")) {
            forEach = true;
            camels = false;
         }
         else if (pInput.StartsWith("camel case")) {
            cases = true;
            camelCase = true;
         }
         else if ((pInput.StartsWith("class case")) || (pInput.StartsWith("pascal case"))) {
            cases = true;
            camels = false;
         }
         else if (pInput.StartsWith("snake case")) {
            cases = true;
            snakeCase = true;
         }
         else if ((pInput.StartsWith("pascal snake case")) || (pInput.StartsWith("snake pascal case"))) {
            cases = true;
            pascalSnakeCase = true;
            camels = false;
         }
         else if ((pInput.StartsWith("upper case")) || (pInput.StartsWith("uppercase"))) {
            cases = true;
            upperCase = true;
            camels = false;
         }
         else if ((pInput.StartsWith("upper snake case")) || (pInput.StartsWith("snake upper case"))) {
            cases = true;
            upperSnakeCase = true;
            camels = false;
         }
         else if (pInput.Equals("cast as this", StringComparison.OrdinalIgnoreCase)) {
            SendKeys.SendWait("{(}^v{ESC}{)}");
            return;
         }
         else if (pInput.StartsWith("cast as"))
            casting = true;
         if (StringContainsPhrase(pInput, ";")) {
            semicolons = true;
         }
         if (StringContainsPhrase(pInput, "this")) {
            paste = true;
         }
         if (StringContainsPhrase(pInput, "equalsnew")) {
            equalsNews = true;
         }
         if (StringContainsPhrase(pInput, "partial")) {
            partials = true;
            construction++;
         }
         if (StringContainsPhrase(pInput, "function")) {
            functions = true;
            construction++;
         }
         if (StringContainsPhrase(pInput, "structure")) {
            structures = true;
            construction++;
         }
         if (StringContainsPhrase(pInput, "class")) {
            classes = true;
            construction++;
         }
         if (StringContainsPhrase(pInput, "object")) {
            objects = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "IntPtr")) {
            integerPointers = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "UIntPtr")) {
            unsignedIntegerPointers = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "var")) {
            vars = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "void")) {
            voids = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "byte")) {
            bytes = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "shortbyte")) {
            sbytes = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "bool")) {
            bools = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "char")) {
            characters = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "decimal")) {
            decimals = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "double")) {
            doubles = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "float")) {
            floats = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "integer")) {
            integers = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "int16")) {
            int16s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "int32")) {
            int32s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "int64")) {
            int64s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "unsigned")) {
            unsigneds = true;
         }
         if (StringContainsPhrase(pInput, "uint16")) {
            uint16s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "uint32")) {
            uint32s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "uint64")) {
            uint64s = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "long")) {
            longs = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "ulong")) {
            longs = true;
            unsigneds = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "short")) {
            shorts = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "ushort")) {
            shorts = true;
            unsigneds = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "list")) {
            lists = true;
         }
         if (StringContainsPhrase(pInput, "enumerate")) {
            enumerators = true;
         }
         if (StringContainsPhrase(pInput, "string")) {
            strings = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "override")) {
            overrides = true;
         }
         if (StringContainsPhrase(pInput, "virtual")) {
            virtuals = true;
         }
         if (StringContainsPhrase(pInput, "constant")) {
            constants = true;
         }
         if (StringContainsPhrase(pInput, "static")) {
            statics = true;
         }
         if (StringContainsPhrase(pInput, "private")) {
            privates = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "public")) {
            publics = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "protected")) {
            protecteds = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "internal")) {
            internals = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "protectedInternal")) {
            protectedInternals = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "privateProtected")) {
            privateProtecteds = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "extern")) {
            externals = true;
            accessibles++;
         }
         if (StringContainsPhrase(pInput, "readonly")) {
            readOnlys = true;
         }
         if (StringContainsPhrase(pInput, "abstract")) {
            abstracts = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "async")) {
            asyncs = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "event")) {
            events = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "sealed")) {
            sealeds = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "unsafe")) {
            unsafes = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "volatile")) {
            volatiles = true;
            variables++;
         }
         if (StringContainsPhrase(pInput, "reference")) {
            references = true;
            modifier++;
         }
         if (StringContainsPhrase(pInput, "out")) {
            outs = true;
            modifier++;
         }
         if (StringContainsPhrase(pInput, "in")) {
            ins = true;
            modifier++;
         }
         if (StringContainsPhrase(pInput, "array"))
            arrays = true;
         if (StringContainsPhrase(pInput, "member")) {
            members = true;
            prefixes++;
         }
         if (StringContainsPhrase(pInput, "global")) {
            globals = true;
            prefixes++;
         }
         if ((StringContainsPhrase(pInput, "parameter")) && !cases) {
            parameters = true;
            prefixes++;
         }
         if ((StringContainsPhrase(pInput, "pascal")) && !cases) {
            capitalize++;
            camels = false;
         }
         if ((StringContainsPhrase(pInput, "snake")) && !cases)
            snakes = true;
         if ((StringContainsPhrase(pInput, "upper")) && !cases) {
            uppers = true;
            capitalize++;
            camels = false;
         }
         if ((StringContainsPhrase(pInput, "camel")) && !cases) {
            capitalize++;
         }
         #endregion

         #region error checking
         if (casting && ((variables > 1) || (modifier > 1) || equalsNews || (construction > 0) ||
            (accessibles > 0) || arrays || structures || lists || enumerators)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not start with casting{0}" +
               "AND have multiple variable types, modifiers, accessibility restrictions," +
               "or the words \"list\", \" array\", \"structure\" nor \"struct\", and \"enumerator\" nor \"enum\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (StringContainsPhrase(pInput, "partial") && !classes) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain \"partial\" unless it also contains \"class\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (cases && ((variables > 0) || (modifier > 0) || equalsNews || (construction > 1) ||
            (accessibles > 1) ||
            arrays || structures || lists || enumerators)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not start with:{0}" +
               "\"camel\", \"class\", \"upper\", \"snake\", \"pascal\",{0}" +
               "\"pascal snake\" or snake pascal\", and \"upper snake\" or snake upper\"{0}" +
               "followed by \"case\" AND have variable types, modifiers, accessibility restrictions," +
               "or the words \"list\", \" array\", \"structure\" nor \"struct\", and \"enumerator\" nor \"enum\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (classes && (variables > 0)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain \"class\" and any type of variable. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (classes && (modifier > 0)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain \"class\" and any modifier. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (classes && equalsNews) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain \"class\" and \"equal(s) new\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (variables > 1) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one variable type unless one of those is of type list. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (capitalize > 1) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one of \"Pascal\", \"upper\" or \"camel\". You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if ((construction > 1) && !(classes && partials)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one construction type. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (accessibles > 1) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one accessibility type. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (modifier > 1) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one modifier type. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (prefixes > 1) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain more than one prefix. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if ((accessibles > 0) && (modifier > 0)) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format("Your utterance may not contain both accessibility specifiers" +
               " (const, static, private, public, readonly) and parameter specifiers (ref, out, in). You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (vars && arrays) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain both var and array. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (vars && structures) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain both var and struct. You said:{0}{1}",
               Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (equalsNews && !lists) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Your utterance may not contain both \"equals new\" and anything other than \"List\"" +
               " (with or without a list type). You said:{0}{1}", Environment.NewLine, pInput.Replace("equalsnew", "equals new")),
               "ERROR", mTimedMessageBoxFlags, 0, 3000);
            return;
         }
         if (enumerators && (variables > 0)) {
            if (!bytes && !sbytes && !shorts && !ushorts && !integers && !uints && !longs && !ulongs) {
               _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
                  "Enums (enumerators) may may only be of types:{0}" +
                  "byte, sbyte, short, ushort, int, uint, long or ulong{0}" +
                  "You said:{0}{1}",
                  Environment.NewLine, pInput), "ERROR", mTimedMessageBoxFlags, 0, 3000);
               return;
            }
         }
         #endregion

         string prefix = string.Empty;
         if (members)
            prefix = "m";
         if (globals)
            prefix = "g";
         if (parameters)
            prefix = "p";
         if (casting) {
            string[] types = [ "byte", "sbyte", "object", "var", "void", "bool", "char", "decimal", "double", "float",
               "integer", "int", "int16", "int32", "int64", "unsigned integer", "unsigned int", "uint", "uint16", "uint32", "uint64",
               "long", "ulong", "short", "ushort", "IntPtr", "UIntPtr",  "string", "ToolStripMenuItem", "Button", "Label", "Panel",
               "CheckBox", "RadioButton", "TextBox", "RichTextBox", "ContextMenuStrip", "ComboBox", "NumericUpDown", "DataGridView",
               "DataGridViewColumn", "DataGridViewRow", "GroupBox", "PictureBox", "Image", "Bitmap", "TableLayoutPanel", "TabPage",
               "TabControl", "TrackBar", "TreeView", "TreeNode"];
            string castAs = pInput.Replace("cast as", string.Empty);
            castAs = castAs.Trim();
            if (string.IsNullOrEmpty(castAs))
               SendKeys.SendWait("{(}{)}{LEFT}");
            else {
               foreach (string phrase in types) {
                  if (phrase == castAs) {
                     castAs = castAs.Replace("unsigned integer", "uint");
                     castAs = castAs.Replace("integer", "int");
                     SendKeys.SendWait("{(}");
                     SendKeys.SendWait(castAs);
                     SendKeys.SendWait("{ESC}{)}");
                     break;
                  }
               }
            }
            return;
         }
         if (creatingNew && !lists) {
            string[] types = [ "byte", "sbyte", "object", "var", "void", "bool", "char", "decimal", "double", "float",
               "integer", "int", "int16", "int32", "int64", "unsigned integer", "unsigned int", "uint", "uint16", "uint32", "uint64",
               "long", "ulong", "short", "ushort", "IntPtr", "UIntPtr",  "string", "ToolStripMenuItem", "Button", "Label", "Panel",
               "CheckBox", "RadioButton", "TextBox", "RichTextBox", "ContextMenuStrip", "ComboBox", "NumericUpDown", "DataGridView",
               "DataGridViewColumn", "DataGridViewRow", "GroupBox", "PictureBox", "Image", "Bitmap", "TableLayoutPanel", "TabPage",
               "TabControl", "TrackBar", "TreeView", "TreeNode" ];
            string create = pInput.Replace("create new ", string.Empty), kind = string.Empty;
            create = create.Trim();
            foreach (string phrase in types) {
               if (create.Contains(phrase)) {
                  kind = phrase;
                  break;
               }
            }
            if (kind == "character")
               kind = "char";
            if (string.IsNullOrEmpty(kind)) {
               _ = MessageBoxTimeout(IntPtr.Zero, string.Format("The variable type is not recognized. you said:{0}{1}", Environment.NewLine,
                  pInput), "Recognition Error", mTimedMessageBoxFlags, 0, 3000);
               return;
            }
            create = create.Replace(kind, string.Empty);
            kind = kind.Replace("integer", "int");
            if (!string.IsNullOrEmpty(create)) {
               create = create.Replace("member", string.Empty);
               create = create.Replace("global", string.Empty);
               create = create.Replace("parameter", string.Empty);
               create = CapitalizeAllWords(create);
               create = create.Replace(" ", string.Empty);
            }
            create = kind + " " + prefix + create + " = ;{LEFT}";
            SendKeys.SendWait(create);
            return;
         }

         #region preliminary string
         if (objects)
            normalizedString += " object{ESC} ";
         if (privateProtecteds)
            normalizedString += " private{ESC} protected{ESC} ";
         if (protectedInternals)
            normalizedString += " protected{ESC} internal{ESC} ";
         if (externals)
            normalizedString += " extern{ESC} ";
         if (internals)
            normalizedString += " internal{ESC} ";
         if (overrides)
            normalizedString += " override{ESC} ";
         if (virtuals)
            normalizedString += " virtual{ESC} ";
         if (protecteds)
            normalizedString += " protected{ESC} ";
         if (privates)
            normalizedString += " private{ESC} ";
         if (publics)
            normalizedString += " public{ESC} ";
         if (statics)
            normalizedString += " static{ESC} ";
         if (constants)
            normalizedString += " const{ESC} ";
         if (references)
            normalizedString += " ref{ESC} ";
         if (outs)
            normalizedString += " out{ESC} ";
         if (ins)
            normalizedString += " in{ESC} ";
         if (readOnlys)
            normalizedString += " readonly{ESC} ";
         if (abstracts)
            normalizedString += " abstract{ESC} ";
         if (asyncs)
            normalizedString += " async{ESC} ";
         if (events)
            normalizedString += " event{ESC} ";
         if (sealeds)
            normalizedString += " sealed{ESC} ";
         if (unsafes)
            normalizedString += " unsafe{ESC} ";
         if (volatiles)
            normalizedString += " volatiles{ESC} ";
         if (vars)
            variableType = "var{ESC}";
         else if (bytes)
            variableType = "byte{ESC}";
         else if (sbytes)
            variableType = "sbyte{ESC}";
         else if (bools)
            variableType = "bool{ESC}";
         else if (characters)
            variableType = "char{ESC}";
         else if (decimals)
            variableType = "decimal{ESC}";
         else if (doubles)
            variableType = "double{ESC}";
         else if (floats)
            variableType = "float{ESC}";
         else if (strings)
            variableType = "string{ESC}";
         else if (unsigneds && integers)
            variableType = "uint{ESC}";
         else if (unsigneds && longs)
            variableType = "ulong{ESC}";
         else if (unsigneds && shorts)
            variableType = "ushort{ESC}";
         else if (!unsigneds && integers)
            variableType = "int{ESC}";
         else if (!unsigneds && longs)
            variableType = "long{ESC}";
         else if (!unsigneds && shorts)
            variableType = "short{ESC}";
         else if (int16s)
            variableType = "int16{ESC}";// int## are not legal for enume type
         else if (int32s)
            variableType = "int32{ESC}";
         else if (int64s)
            variableType = "int64{ESC}";
         else if (uint16s)
            variableType = "uint16{ESC}";// uint## are not legal for enume type
         else if (uint32s)
            variableType = "uint32{ESC}";
         else if (uint64s)
            variableType = "uint64{ESC}";
         else if (voids)
            variableType = "void{ESC}";
         else if (integerPointers)
            variableType = "IntPtr{ESC}";
         else if (unsignedIntegerPointers)
            variableType = "UIntPtr{ESC}";
         if (unsigneds)
            uints = true;
         #endregion

         #region Constructors
         if (lists) {
            normalizedString += " List{ESC}<" + variableType + "> ";
            if (creatingNew)
               normalizedString += " = new{ESC} List{ESC}<" + variableType + ">{(}{)};{LEFT 22}";
            if (!string.IsNullOrEmpty(normalizedString) && !string.IsNullOrWhiteSpace(normalizedString) && !forEach) {
               ForceLeadingSpace();
               SendKeys.SendWait(normalizedString);
               if (paste && Clipboard.ContainsText())
                  SendKeys.SendWait("^v");
               else {
                  variableType = variableType.Replace("{ESC}", string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
                  string input = pInput.Replace("create", string.Empty, StringComparison.OrdinalIgnoreCase)
                     .Replace("new", string.Empty, StringComparison.OrdinalIgnoreCase)
                     .Replace("list", string.Empty, StringComparison.OrdinalIgnoreCase)
                     .Replace(variableType, string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
                  string[] words = input.Split(" ");
                  if (words.Length > 0) {
                     string combined = words[0].FirstCharToLower();

                     for (int i = 1; i < words.Length; i++)
                        combined += words[i].FirstCharToUpper();
                     SendKeys.SendWait(combined + "{END}");
                  }
               }
            }
            return;
         }
         else if (enumerators) {
            if (variables > 0) {
               lengthOfType = variableType.Length;
               normalizedString += "enum{ESC} XX{ESC} : " + variableType + " {{}{ENTER}XX{ESC} = 0,{ENTER}XXX{ESC}1 = 1{ENTER}{}}";
            }
            else
               normalizedString += "enum{ESC} XX{ESC} {{}{ENTER}XX{ESC} = 0,{ENTER}XXX{ESC}1 = 1{ENTER}{}}";
         }
         else if (equalsNews && !lists) {
            normalizedString += " = new{ESC} {ESC}{(}{)};{LEFT 4}";
         }
         else if (definingCustomType) {
            normalizedString = variableType;
         }
         else {//Variables
            normalizedString += variableType;
            if (arrays)
               normalizedString += "[] ";
            else
               normalizedString += " ";
         }
         if ((construction > 0) && !cases) {
            if (functions)
               normalizedString += " {(}{)} {{}{ENTER}{}}{ENTER}{UP 2}{END}{LEFT 4}";
            else if (structures)
               normalizedString += " struct{ESC} {{}{ENTER}{}}{UP}{END}{LEFT 2} ";
            else if (classes) {
               if (partials)
                  normalizedString += " partial{ESC} class{ESC}  {{}{ENTER}{}}{UP}{END}{LEFT} {LEFT}";
               else
                  normalizedString += " class{ESC}  {{}{ENTER}{}}{UP}{END}{LEFT} {LEFT}";
            }
         }
         normalizedString = StringExtensions.NormalizeSpacing(normalizedString, false);
         if (!string.IsNullOrEmpty(normalizedString) && !string.IsNullOrWhiteSpace(normalizedString) && !forEach) {
            ForceLeadingSpace();
            SendKeys.SendWait(normalizedString);
         }
         #endregion

         #region Trailing name
         List<string> usedWords = [";", "array", "bool", "byte", "camel case",
            "camel", "case", "char", "class case", "class", "constant", "define", "decimal",
            "double", "enumerate", "equalsnew", "extern", "float", "for each", "function",
            "global", "in", "integer", "internal", "list", "long", "member", "out", "override",
            "parameter", "pascal case", "pascal snake case", "partial", "int16", "int32","int64",
            "pascal", "private", "privateProtected", "protected", "protectedInternal", "public",
            "readonly", "reference", "short", "shortbyte", "snake case", "snake pascal case",
            "snake upper case", "snake", "static", "string", "structure", "uint16", "uint32",
            "uint64", "ulong", "unsigned", "upper case", "upper snake case", "upper", "uppercase",
            "ushort", "var", "virtual", "void", "IntPtr", "UIntPtr"];
         if (definingCustomType) {
            trailingName = StringReplaceWord(trailingName, "define", String.Empty);
            trailingName = StringReplaceWord(trailingName, StringExtensions.FirstCharToLower(variableType),
               String.Empty);
         }
         else
            foreach (string usedWord in usedWords)
               trailingName = StringReplaceWord(trailingName, usedWord, String.Empty);
         trailingName = StringExtensions.NormalizeSpacing(trailingName);
         if (!string.IsNullOrEmpty(trailingName) && !string.IsNullOrWhiteSpace(trailingName) || forEach) {
            //modifiers: camel (the default), pascal/capitals, snake, upper
            if (uppers || upperCase || upperSnakeCase)
               trailingName = trailingName.ToUpper();
            else if (forEach) {
               if (variables == 0)
                  trailingName = CapitalizeAllWords(trailingName);
               if (strings)
                  trailingName = "string";
            }
            else if (!snakeCase)
               trailingName = CapitalizeAllWords(trailingName);
            if (snakes || snakeCase || pascalSnakeCase || upperSnakeCase)
               trailingName = trailingName.Replace(" ", "_");
            if (camels || camelCase)
               if (!members && !globals && !parameters)
                  trailingName = StringExtensions.FirstCharToLower(trailingName);
            trailingName = trailingName.Replace(" ", string.Empty);
            string originalTrailingName = trailingName;
            if (classes || enumerators || functions || structures)
               trailingName = StringExtensions.FirstCharToUpper(trailingName);
            if (forEach) {
               SendKeys.SendWait("foreach {(} in{ESC} whatList{ESC}.OfType<>{(}{)}{)} {{}{ENTER}{}}{UP}{HOME}{Right 9}");
               if (variables > 0)
                  SendKeys.SendWait(variableType);
               else
                  SendKeys.SendWait(trailingName);
               if (strings)
                  trailingName = "phrase ";
               else if (variables > 0)
                  trailingName = "number ";
               else
                  trailingName = StringExtensions.FirstCharToLower(trailingName) + " ";
               SendKeys.SendWait("{RIGHT}");
               SendKeys.SendWait(trailingName);
               SendKeys.SendWait("{END}");
               SendKeys.SendWait("{LEFT 6}");
               SendKeys.SendWait(originalTrailingName);
               SendKeys.SendWait("{END}");
               SendKeys.SendWait("^{LEFT 6}^+{RIGHT}");
               doEscape = false;
            }
            else if (enumerators && !cases) {
               SendKeys.SendWait("{UP 3}{HOME}{RIGHT 5}{DELETE 2}");
               SendKeys.SendWait(prefix + trailingName);
            }
            else if (lists && !cases) {
               if (variables > 0) {
                  SendKeys.SendWait("{END}");
                  SendKeys.SendWait(prefix + trailingName);
               }
            }
            else if (definingCustomType) {
               SendKeys.SendWait(" ");
               SendKeys.SendWait(trailingName);
               SendKeys.SendWait(" = new ");
               SendKeys.SendWait("{TAB}");
               SendKeys.SendWait("{(}");
               SendKeys.SendWait(customTypeCommas);
               SendKeys.SendWait("{)};");
               SendKeys.SendWait(customTypePlacement);
            }
            else if (!equalsNews)
               SendKeys.SendWait(prefix + trailingName);
            if (doEscape)
               SendKeys.SendWait("{ESC}");
            if (semicolons)
               SendKeys.SendWait(";");
         }
         else if (definingCustomType) {
            SendKeys.SendWait(" ");
            string defaultName = StringExtensions.FirstCharToLower(variableType);
            SendKeys.SendWait(defaultName);
            SendKeys.SendWait(" = new ");
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{(}");
            SendKeys.SendWait(customTypeCommas);
            SendKeys.SendWait("{)};");
            SendKeys.SendWait(customTypePlacement);
         }
         #endregion
      }

      private static bool KnownCustomType(string pInput, ref string pVariableType, ref string pCustomTypeCommas,
         ref string pCustomTypePlacement) {
         if (StringContainsPhrase(pInput, "button")) {
            pVariableType = "Button";
            pCustomTypeCommas = string.Empty;
            pCustomTypePlacement = "{LEFT 2}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "point")) {
            pVariableType = "Point";
            pCustomTypeCommas = ", ";
            pCustomTypePlacement = "{LEFT 4}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "size")) {
            pVariableType = "Size";
            pCustomTypeCommas = ", ";
            pCustomTypePlacement = "{LEFT 4}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "label")) {
            pVariableType = "Label";
            pCustomTypeCommas = string.Empty;
            pCustomTypePlacement = "{LEFT 2}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "rectangle")) {
            pVariableType = "Rectangle";
            pCustomTypeCommas = ", , , ";
            pCustomTypePlacement = "{LEFT 8}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "string")) {
            pVariableType = "string";
            pCustomTypeCommas = string.Empty;
            pCustomTypePlacement = "{LEFT 2}";
            return true;
         }
         else if ((StringContainsPhrase(pInput, "textbox")) || (StringContainsPhrase(pInput, "text box"))) {
            pVariableType = "TextBox";
            pCustomTypeCommas = string.Empty;
            pCustomTypePlacement = "{LEFT 2}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "stringbuilder")) {
            pVariableType = "StringBuilder";
            pCustomTypeCommas = string.Empty;
            pCustomTypePlacement = "{LEFT 2}";
            return true;
         }
         else if (StringContainsPhrase(pInput, "font")) {
            pVariableType = "Font";
            pCustomTypeCommas = "\"\", , FontStyle.Regular";
            pCustomTypePlacement = "{LEFT 24}";
            return true;
         }
         else
            return false;
      }
   }
}