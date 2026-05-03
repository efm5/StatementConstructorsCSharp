using System.Reflection;
using static StatementConstructors.Program.NativeMethods;

namespace StatementConstructors {
   public partial class Program {
      private static void InvokeVoidMethod(string pValue) {
         if (pValue == null)
            return;
         try {
            Type type = typeof(SnippetMethods);
            //SnippetMethods snippetFunctions = (SnippetMethods)Activator.{ESC}CreateInstance(type);
            MethodInfo? method = type.GetMethod(pValue);
            method?.Invoke(null, null);
            //method.{ESC}Invoke(snippetFunctions, null);
            //Since all of the possible methods are "static" the two commented-out lines are unnecessary
         }
         catch (Exception pException) {
            _ = MessageBoxTimeout(IntPtr.Zero, string.Format(
               "Value is _{0}_{1}MESSAGE: {2}", pValue, Environment.NewLine, pException.ToString()),
               "ERROR", mTimedMessageBoxFlags, 0, 3000);
         }
      }

      public class SnippetMethods {
         // un-comment the following method to re-establish the "exercise all the methods" functionality
         // you will also need to un-comment the appropriate section of code in Program.{ESC}cs at or near line #50
         //public static void PrintThemOut() {
         //   Clipboard.{ESC}SetText("something on the clipboard");
         //   SendKeys.SendWait("AbbreviateHResult {ENTER}"); AbbreviateHResult(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("AbbreviateRectangle {ENTER}"); AbbreviateRectangle(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("AbbreviateTCHAR {ENTER}"); AbbreviateTCHAR(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("AbbreviateTSMI {ENTER}"); AbbreviateTSMI(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("AbbreviateWindowHandle {ENTER}"); AbbreviateWindowHandle(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Ampersand {ENTER}"); Ampersand(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Asterisk {ENTER}"); Asterisk(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("BackSlash {ENTER}"); BackSlash(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Beep {ENTER}"); Beep(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Bottom {ENTER}"); Bottom(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("BreakOnly {ENTER}"); BreakOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("CaseOnly {ENTER}"); CaseOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("CaseThis {ENTER}"); CaseThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("CatchOnly {ENTER}"); CatchOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ClientSize {ENTER}"); ClientSize(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ContinueOnly {ENTER}"); ContinueOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("CurlyBraces {ENTER}"); CurlyBraces(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotBottom {ENTER}"); DotBottom(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotClientSize {ENTER}"); DotClientSize(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotEnabled {ENTER}"); DotEnabled(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotEnabledTrue {ENTER}"); DotEnabledTrue(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotEnabledFalse {ENTER}"); DotEnabledFalse(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotFont {ENTER}"); DotFont(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotHeight {ENTER}"); DotHeight(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotLeft {ENTER}"); DotLeft(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotLocation {ENTER}"); DotLocation(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotPoint {ENTER}"); DotPoint(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotRight {ENTER}"); DotRight(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotSize {ENTER}"); DotSize(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotText {ENTER}"); DotText(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotTop {ENTER}"); DotTop(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DotWidth {ENTER}"); DotWidth(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DoWhile {ENTER}"); DoWhile(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DoWhileSimple {ENTER}"); DoWhileSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DoWhileNot {ENTER}"); DoWhileNot(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DoWhileNotThis {ENTER}"); DoWhileNotThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("DoWhileThis {ENTER}"); DoWhileThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseSimple {ENTER}"); ElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseCompound {ENTER}"); ElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElsePartial {ENTER}"); ElsePartial(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfPartial {ENTER}"); ElseIfPartial(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfCompound {ENTER}"); ElseIfCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfCompoundThis {ENTER}"); ElseIfCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotCompound {ENTER}"); ElseIfNotCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotCompoundThis {ENTER}"); ElseIfNotCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotSimple {ENTER}"); ElseIfNotSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotThisSimple {ENTER}"); ElseIfNotThisSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfSimple {ENTER}"); ElseIfSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfSimpleElseSimple {ENTER}"); ElseIfSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfSimpleElseSimple {ENTER}"); ElseIfSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}"); 
         //   SendKeys.SendWait("ElseIfCompoundElseSimple {ENTER}"); ElseIfCompoundElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfCompoundElseCompound {ENTER}"); ElseIfCompoundElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfThisSimpleElseSimple {ENTER}"); ElseIfThisSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfCompoundThisElseSimple {ENTER}"); ElseIfCompoundThisElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfCompoundThisElseCompound {ENTER}"); ElseIfCompoundThisElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotSimpleElseSimple {ENTER}"); ElseIfNotSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotCompoundElseSimple {ENTER}"); ElseIfNotCompoundElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotThisSimpleElseSimple {ENTER}"); ElseIfNotThisSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotCompoundThisElseSimple {ENTER}"); ElseIfNotCompoundThisElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ElseIfNotCompoundThisElseCompound {ENTER}"); ElseIfNotCompoundThisElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EmptyCurlyBraces {ENTER}"); EmptyCurlyBraces(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EmptyParens {ENTER}"); EmptyParens(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EmptyParensSemicolon {ENTER}"); EmptyParensSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EmptyQuotes {ENTER}"); EmptyQuotes(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EmptyString {ENTER}"); EmptyString(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EndRegion {ENTER}"); EndRegion(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EndRegion {ENTER}"); EnvironmentNewLine(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsX {ENTER}"); EqualsX(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsDefaultSettings {ENTER}"); EqualsDefaultSettings(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsEmptyStringSemicolon {ENTER}"); EqualsEmptyStringSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsEmptyString {ENTER}"); EqualsEmptyString(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsFalse {ENTER}"); EqualsFalse(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsFalseSemicolon {ENTER}"); EqualsFalseSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsIntPtrZero {ENTER}"); EqualsIntPtrZero(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsUIntPtrZero {ENTER}"); EqualsUIntPtrZero(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsNew {ENTER}"); EqualsNew(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsThis {ENTER}"); EqualsThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsThisSemicolon {ENTER}"); EqualsThisSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsTrue {ENTER}"); EqualsTrue(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsTrueSemicolon {ENTER}"); EqualsTrueSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EqualsZeroSemicolon {ENTER}"); EqualsZeroSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EventFunction {ENTER}"); EventFunction(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("EventFunctionThis {ENTER}"); EventFunctionThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ExitStatement {ENTER}"); ExitStatement(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("FalseOnly {ENTER}"); FalseOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("FalseSemicolon {ENTER}"); FalseSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("FinallyOnly {ENTER}"); FinallyOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("For {ENTER}"); For(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ForEach {ENTER}"); ForEach(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ForEachSimple {ENTER}"); ForEachSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ForInteger {ENTER}"); ForInteger(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ForIntegerSimple {ENTER}"); ForIntegerSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("FormattedMessageBoxConstructor {ENTER}"); FormattedMessageBoxConstructor(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("FormattedMessageBoxConstructorDebug {ENTER}"); FormattedMessageBoxConstructorDebug(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("GreaterThanOrEqualTo {ENTER}"); GreaterThanOrEqualTo(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Height {ENTER}"); Height(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEquals {ENTER}"); IfStringEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEqualsThis {ENTER}"); IfStringEqualsThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotStringEquals {ENTER}"); IfNotStringEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotStringEqualsThis {ENTER}"); IfNotStringEqualsThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEqualsCompound {ENTER}"); IfStringEqualsCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEqualsCompoundThis {ENTER}"); IfStringEqualsCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotStringEqualsCompound {ENTER}"); IfNotStringEqualsCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotStringEqualsCompoundThis {ENTER}"); IfNotStringEqualsCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfCompound {ENTER}"); IfCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfPartial {ENTER}"); IfPartial(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfCompoundThis {ENTER}"); IfCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfSimpleElseSimple {ENTER}"); IfSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisSimpleElseCompound {ENTER}"); IfThisSimpleElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisSimpleElseSimple {ENTER}"); IfThisSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotCompound {ENTER}"); IfNotCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotSimpleElseCompound {ENTER}"); IfNotSimpleElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotSimpleElseSimple {ENTER}"); IfNotSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotThisSimpleElseCompound {ENTER}"); IfNotThisSimpleElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotThisSimpleElseSimple {ENTER}"); IfNotThisSimpleElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotTryParseDouble {ENTER}"); IfNotTryParseDouble(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotTryParseFloat {ENTER}"); IfNotTryParseFloat(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotTryParseInteger {ENTER}"); IfNotTryParseInteger(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfTryParseDouble {ENTER}"); IfTryParseDouble(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfTryParseFloat {ENTER}"); IfTryParseFloat(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfTryParseInteger {ENTER}"); IfTryParseInteger(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotSimple {ENTER}"); IfNotSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotCompoundThis {ENTER}"); IfNotCompoundThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotThisSimple {ENTER}"); IfNotThisSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfSimple {ENTER}"); IfSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisSimple {ENTER}"); IfThisSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfCompoundElseCompound {ENTER}"); IfCompoundElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfCompoundThisElseSimple {ENTER}"); IfCompoundThisElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfCompoundThisElseCompound {ENTER}"); IfCompoundThisElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotCompoundThisElseSimple {ENTER}"); IfNotCompoundThisElseSimple(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfNotCompoundThisElseCompound {ENTER}"); IfNotCompoundThisElseCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEmpty {ENTER}"); IfStringEmpty(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisStringEmpty {ENTER}"); IfThisStringEmpty(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringNotEmpty {ENTER}"); IfStringNotEmpty(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisStringNotEmpty {ENTER}"); IfThisStringNotEmpty(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringEmptyCompound {ENTER}"); IfStringEmptyCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisStringEmptyCompound {ENTER}"); IfThisStringEmptyCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfStringNotEmptyCompound {ENTER}"); IfStringNotEmptyCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IfThisStringNotEmptyCompound {ENTER}"); IfThisStringNotEmptyCompound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IntPtrX {ENTER}"); IntPtrX(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IntPtrZero {ENTER}"); IntPtrZero(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("IntPtrZeroSemicolon {ENTER}"); IntPtrZeroSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("UIntPtrX {ENTER}"); UIntPtrX(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("UIntPtrZero {ENTER}"); UIntPtrZero(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("UIntPtrZeroSemicolon {ENTER}"); UIntPtrZeroSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Left {ENTER}"); Left(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LeftAngleBracket {ENTER}"); LeftAngleBracket(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LeftCurlyBrace {ENTER}"); LeftCurlyBrace(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LeftParentheses {ENTER}"); LeftParentheses(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LessThanOrEqualTo {ENTER}"); LessThanOrEqualTo(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Location {ENTER}"); Location(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LocationDot {ENTER}"); LocationDot(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LogicalAnd {ENTER}"); LogicalAnd(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LogicalEquals {ENTER}"); LogicalEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LogicalEqualsThis {ENTER}"); LogicalEqualsThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LogicalNot {ENTER}"); LogicalNot(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("LogicalOr {ENTER}"); LogicalOr(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathAbsolute {ENTER}"); MathAbsolute(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathCeiling {ENTER}"); MathCeiling(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathFloor {ENTER}"); MathFloor(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathMax {ENTER}"); MathMax(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathMin {ENTER}"); MathMin(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathRound {ENTER}"); MathRound(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MathTruncate {ENTER}"); XXXMathTruncate SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MessageBoxConstructor {ENTER}"); MessageBoxConstructor(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MessageBoxConstructorThis {ENTER}"); MessageBoxConstructorThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MessageBoxConstructorDebug {ENTER}"); MessageBoxConstructorDebug(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MessageBoxConstructorDebugThis {ENTER}"); MessageBoxConstructorDebugThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("MinusSign {ENTER}"); MinusSign(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Modulo {ENTER}"); Modulo(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Namespace {ENTER}"); Namespace(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewOnly {ENTER}"); NewOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewButton {ENTER}"); NewButton(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewLabel {ENTER}"); NewLabel(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewPanel {ENTER}"); NewPanel(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewPoint {ENTER}"); NewPoint(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewRectangle {ENTER}"); NewRectangle(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NewSize {ENTER}"); NewSize(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NotEquals {ENTER}"); NotEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("NullOnly {ENTER}"); NullOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ParseDouble {ENTER}"); ParseDouble(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ParseFloat {ENTER}"); ParseFloat(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ParseInteger {ENTER}"); ParseInteger(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PlusEquals {ENTER}"); PlusEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PlusPlus {ENTER}"); PlusPlus(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PlusSign {ENTER}"); PlusSign(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Point {ENTER}"); Point(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundDefine {ENTER}"); PoundDefine(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundElse {ENTER}"); PoundElse(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundElseIf {ENTER}"); PoundElseIf(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundEndIf {ENTER}"); PoundEndIf(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundIf {ENTER}"); PoundIf(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundIfNot {ENTER}"); PoundIfNot(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundRegion {ENTER}"); PoundRegion(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("PoundUndefine {ENTER}"); PoundUndefine(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("RectangleOnly {ENTER}"); RectangleOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ReturnFalse {ENTER}"); ReturnFalse(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ReturnOnly {ENTER}"); ReturnOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ReturnThis {ENTER}"); ReturnThis(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ReturnTrue {ENTER}"); ReturnTrue(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Right {ENTER}"); Right(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("RightAngleBracket {ENTER}"); RightAngleBracket(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("RightCurlyBrace {ENTER}"); RightCurlyBrace(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("RightParentheses {ENTER}"); RightParentheses(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ScrollBarHeight {ENTER}"); ScrollBarHeight(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ScrollBarWidth {ENTER}"); ScrollBarWidth(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendSomeKeys {ENTER}"); SendSomeKeys(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendBACKSPACE {ENTER}"); SendBACKSPACE(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendBREAK {ENTER}"); SendBREAK(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendCAPSLOCK {ENTER}"); SendCAPSLOCK(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendDELETE {ENTER}"); SendDELETE(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendDOWN {ENTER}"); SendDOWN(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendEND {ENTER}"); SendEND(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendENTER {ENTER}"); SendENTER(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendESC {ENTER}"); SendESC(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendHELP {ENTER}"); SendHELP(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendHOME {ENTER}"); SendHOME(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendINSERT {ENTER}"); SendINSERT(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendLEFT {ENTER}"); SendLEFT(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendNUMLOCK {ENTER}"); SendNUMLOCK(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendPGDN {ENTER}"); SendPGDN(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendPGUP {ENTER}"); SendPGUP(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendPRTSC {ENTER}"); SendPRTSC(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendRIGHT {ENTER}"); SendRIGHT(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendSCROLLLOCK {ENTER}"); SendSCROLLLOCK(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendTAB {ENTER}"); SendTAB(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendUP {ENTER}"); SendUP(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF1 {ENTER}"); SendF1(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF2 {ENTER}"); SendF2(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF3 {ENTER}"); SendF3(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF4 {ENTER}"); SendF4(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF5 {ENTER}"); SendF5(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF6 {ENTER}"); SendF6(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF7 {ENTER}"); SendF7(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF8 {ENTER}"); SendF8(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF9 {ENTER}"); SendF9(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF10 {ENTER}"); SendF10(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF11 {ENTER}"); SendF11(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF12 {ENTER}"); SendF12(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF13 {ENTER}"); SendF13(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF14 {ENTER}"); SendF14(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF15 {ENTER}"); SendF15(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendF16 {ENTER}"); SendF16(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   //DebugSendKeys.{ESC}SendWait("SendF17-24 {ENTER}"); SendF17-24(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendADD {ENTER}"); SendADD(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendSUBTRACT {ENTER}"); SendSUBTRACT(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendMULTIPLY {ENTER}"); SendMULTIPLY(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendDIVIDE {ENTER}"); SendDIVIDE(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendSHIFT {ENTER}"); SendSHIFT(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendCONTROL {ENTER}"); SendCONTROL(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SendALTERNATE {ENTER}"); SendALTERNATE(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ShellExecute {ENTER}"); ShellExecute(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ShellExecuteConstructor {ENTER}"); ShellExecuteConstructor(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SimpleElse {ENTER}"); SimpleElse(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Size {ENTER}"); Size(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SizeDot {ENTER}"); SizeDot(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SizeOf {ENTER}"); SizeOf(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Slash {ENTER}"); Slash(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("StaticCast {ENTER}"); StaticCast(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("StringFormat {ENTER}"); StringFormat(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("StringIsNullOrEmpty {ENTER}"); StringIsNullOrEmpty(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Structure {ENTER}"); Structure(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SwitchConstructor {ENTER}"); SwitchConstructor(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("SwitchOnly {ENTER}"); SwitchOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Text {ENTER}"); Text(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("This {ENTER}"); This(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("ThreadSleep {ENTER}"); ThreadSleep(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TimesEquals {ENTER}"); TimesEquals(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Top {ENTER}"); Top(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TrueOnly {ENTER}"); TrueOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TrueSemicolon {ENTER}"); TrueSemicolon(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryCatch {ENTER}"); TryCatch(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryCatchFinally {ENTER}"); TryCatchFinally(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryOnly {ENTER}"); TryOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryParseDouble {ENTER}"); TryParseDouble(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryParseFloat {ENTER}"); TryParseFloat(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TryParseInteger {ENTER}"); TryParseInteger(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("TypeOf {ENTER}"); TypeOf(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("Using {ENTER}"); Using(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("UsingStatic {ENTER}"); UsingStatic(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("VerticalBar {ENTER}"); VerticalBar(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //   SendKeys.SendWait("WidthOnly {ENTER}"); WidthOnly(); SendKeys.SendWait("^{END}{ENTER}{ENTER}");
         //}

         public static void AbbreviateHResult() { LeadingSpace(); SendKeys.SendWait("HRESULT{ESC} "); }
         public static void AbbreviateRectangle() { LeadingSpace(); SendKeys.SendWait("RECT{ESC} "); }
         public static void AbbreviateTCHAR() { LeadingSpace(); SendKeys.SendWait("TCHAR{ESC} "); }
         public static void AbbreviateTSMI() { LeadingSpace(); SendKeys.SendWait("TSMI{ESC}"); }
         public static void AbbreviateWindowHandle() { LeadingSpace(); SendKeys.SendWait("HWND{ESC} "); }
         public static void Ampersand() { LeadingSpace(); SendKeys.SendWait("& "); }
         public static void Apostrophe() { LeadingSpace(); SendKeys.SendWait("'"); }
         public static void Asterisk() { LeadingSpace(); SendKeys.SendWait("* "); }
         public static void BackSlash() { LeadingSpace(); SendKeys.SendWait("\\"); }
         public static void Beep() { SendKeys.SendWait("Console{ESC}.{ESC}Beep{(}500, 500{)};//DEBUG Beep"); }
         public static void BeepHigh() { SendKeys.SendWait("Console{ESC}.{ESC}Beep{(}2500, 500{)};//DEBUG Beep"); }
         public static void BeepLow() { SendKeys.SendWait("Console{ESC}.{ESC}Beep{(}300, 500{)};//DEBUG Beep"); }
         public static void BeepMedium() { SendKeys.SendWait("Console{ESC}.{ESC}Beep{(}1500, 500{)};//DEBUG Beep"); }
         public static void Bottom() { LeadingSpace(); SendKeys.SendWait("Bottom{ESC} "); }
         public static void BreakOnly() { LeadingSpace(); SendKeys.SendWait("break;"); }
         public static void Caret() { LeadingSpace(); SendKeys.SendWait("{^}"); }
         public static void CaseOnly() { LeadingSpace(); SendKeys.SendWait("case{ESC} \"\":{ENTER}{UP}{END}"); }
         public static void CaseThis() { LeadingSpace(); SendKeys.SendWait("case{ESC} \"\":{ENTER}{UP}{END}{LEFT 2}^v"); }
         public static void CatchOnly() {
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("DisplayMessage{(}pException{)};{ENTER}{}}");
         }
         public static void CatchOnlyThis() {
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("DisplayMessage{(}pException{)};{ENTER}{}}{UP}{END}{LEFT 16}^v");

         }
         public static void CatchOnlyPartial() { SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}"); }
         public static void ClientSize() { LeadingSpace(); SendKeys.SendWait("ClientSize{ESC} "); }
         public static void CloseStatement() { SendKeys.SendWait("Close{ESC}{(}{)};"); }
         public static void ContinueOnly() { LeadingSpace(); SendKeys.SendWait("continue;"); }
         public static void CurlyBraces() { LeadingSpace(); SendKeys.SendWait("{END}{{}{ENTER}{}}{UP}{END}"); }
         public static void DefaultSettings() { LeadingSpace(); SendKeys.SendWait("Settings.{ESC}Default.{ESC}"); }
         public static void DefaultSettingsSave() { SendKeys.SendWait("Settings.{ESC}Default.{ESC}Save{ESC}{(}{)};"); }
         public static void DotBottom() { SendKeys.SendWait(".{ESC}Bottom{ESC} "); }
         public static void DotClientSize() { SendKeys.SendWait(".{ESC}ClientSize{ESC} "); }
         public static void DotEnabled() { SendKeys.SendWait(".{ESC}Enabled{ESC} "); }
         public static void DotEnabledTrue() { SendKeys.SendWait(".{ESC}Enabled{ESC} = true;"); }
         public static void DotEnabledFalse() { SendKeys.SendWait(".{ESC}Enabled{ESC} = false;"); }
         public static void DotFont() { SendKeys.SendWait(".{ESC}Font{ESC} "); }
         public static void DotHeight() { SendKeys.SendWait(".{ESC}Height{ESC} "); }
         public static void DotLeft() { SendKeys.SendWait(".{ESC}Left{ESC} "); }
         public static void DotLocation() { SendKeys.SendWait(".{ESC}Location{ESC} "); }
         public static void DotPoint() { SendKeys.SendWait(".{ESC}Point{ESC} "); }
         public static void DotRight() { SendKeys.SendWait(".{ESC}Right{ESC} "); }
         public static void DotSize() { SendKeys.SendWait(".{ESC}Size{ESC} "); }
         public static void DotText() { SendKeys.SendWait(".{ESC}Text{ESC} "); }
         public static void DotTop() { SendKeys.SendWait(".{ESC}Top{ESC} "); }
         public static void DotWidth() { SendKeys.SendWait(".{ESC}Width{ESC}I "); }
         public static void DoubleQuote() { LeadingSpace(); SendKeys.SendWait("\""); }
         public static void DoWhile() { LeadingSpace(); SendKeys.SendWait("do{ESC} {{}{ENTER}{}}{ENTER}"); SendKeys.SendWait("while {(}{)};{LEFT 2}"); }
         public static void DoWhileSimpleVS() { LeadingSpace(); SendKeys.SendWait("do{ESC} {ENTER}{ENTER}"); SendKeys.SendWait("while {(}{)};{LEFT}{BACKSPACE}{HOME}{BACKSPACE 3}{RIGHT 7}"); }
         public static void DoWhileSimple() { LeadingSpace(); SendKeys.SendWait("do{ESC} {ENTER}{ENTER}"); SendKeys.SendWait("while {(}{)};{LEFT 2}"); }
         public static void DoWhileNot() { LeadingSpace(); SendKeys.SendWait("do{ESC} {{}{ENTER}{}}{ENTER}"); SendKeys.SendWait("while {(}!{)};{LEFT 2}"); }
         public static void DoWhileNotThis() { LeadingSpace(); SendKeys.SendWait("do{ESC} {{}{ENTER}{}}{ENTER}"); SendKeys.SendWait("while {(}!{)};{LEFT 2}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{UP 2}{END}"); }
         public static void DoWhileThis() { LeadingSpace(); SendKeys.SendWait("do{ESC} {{}{ENTER}{}}{ENTER}"); SendKeys.SendWait("while {(}{)};{LEFT 2}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{UP 2}{END}"); }
         public static void ElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC}{ENTER}"); }
         public static void ElseCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} {{}{ENTER}{}}{UP}{END}"); }
         public static void ElsePartial() { SendKeys.SendWait("else{ESC} {{}"); }
         public static void ElseIfPartial() {
            SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{LEFT 3}");
         }
         public static void ElseIfPartialThis() {
            SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{LEFT 3}");
            SendKeys.SendWait("^v{END}");
            SendKeys.SendWait("{END}");
         }
         public static void ElseIfCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); }
         public static void ElseIfCompoundThis() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}^v{END}"); }
         public static void ElseIfNotCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); }
         public static void ElseIfNotCompoundThis() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}^v{END}"); }
         public static void ElseIfNotSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)}{ENTER}"); }
         public static void ElseIfNotThisSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)}{ENTER}{UP}{END}{LEFT}^v{END}"); }
         public static void ElseIfSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{ENTER}"); }
         public static void ElseIfSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{ENTER}else{ESC}{UP}{END}{LEFT}"); }
         public static void ElseIfCompoundElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}"); }
         public static void ElseIfCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); }
         public static void ElseIfThisSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{ENTER}{UP}{END}{LEFT}^v{END}"); }
         public static void ElseIfThisSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{ENTER}else{ESC}{UP}{END}{LEFT}^v{END}"); }
         public static void ElseIfCompoundThisElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}^v{END}"); }
         public static void ElseIfCompoundThisElseCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}{)}{{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}^v{END}"); }
         public static void ElseIfNotSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)}{ENTER}else{ESC}{UP}{END}{LEFT}"); }
         public static void ElseIfNotCompoundElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}"); }
         public static void ElseIfNotCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); }
         public static void ElseIfNotThisSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)}{ENTER}else{ESC}{UP}{END}{LEFT}^v{END}"); }
         public static void ElseIfNotCompoundThisElseSimple() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}^v{END}"); }
         public static void ElseIfNotCompoundThisElseCompound() { LeadingSpace(); SendKeys.SendWait("else{ESC} if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}^v{END}"); }
         public static void EmptyCurlyBraces() { LeadingSpace(); SendKeys.SendWait("{{}{}}"); }
         public static void EmptyParens() { LeadingSpace(); SendKeys.SendWait("{(}{)}"); }
         public static void EmptyParensSemicolon() { LeadingSpace(); SendKeys.SendWait("{(}{)};"); }
         public static void EmptyQuotes() { LeadingSpace(); SendKeys.SendWait("\"\""); }
         public static void EmptySquareBrackets() { LeadingSpace(); SendKeys.SendWait("[] "); }
         public static void EmptyString() { LeadingSpace(); SendKeys.SendWait("string.{ESC}Empty{ESC}"); }
         public static void Enabled() { LeadingSpace(); SendKeys.SendWait("Enabled{ESC}"); }
         public static void EndRegion() { LeadingSpace(); SendKeys.SendWait("#endregion{ESC}"); }
         public static void EnvironmentNewLine() { LeadingSpace(); SendKeys.SendWait("Environment.{ESC}NewLine{ESC}"); }
         public static void EventHandlerMethod() {
            LeadingSpace();
            SendKeys.SendWait("private void XXX{(}object pSender, EventArgs{ESC} pE{)} {{}{ESC}" + Environment.NewLine + "{ESC}{}}{UP}{END}{HOME}{RIGHT 13}+{RIGHT 3}");
         }
         public static void EventHandlerMethodThis() {
            LeadingSpace();
            SendKeys.SendWait("private void XXX{(}object pSender, EventArgs{ESC} pE{)} {{}{ESC}" + Environment.NewLine + "{ESC}{}}{UP}{END}{HOME}{RIGHT 13}+{RIGHT 3}^v");
         }
         public static void EqualsX() { LeadingSpace(); SendKeys.SendWait("{ESC}= "); }
         public static void EqualsDefaultSettings() { LeadingSpace(); SendKeys.SendWait("= Settings.{ESC}Default.{ESC}"); }
         public static void EqualsEmptyString() { LeadingSpace(); SendKeys.SendWait("= string.{ESC}Empty{ESC}"); }
         public static void EqualsEmptyStringSemicolon() { LeadingSpace(); SendKeys.SendWait("= string.{ESC}Empty{ESC};"); }
         public static void EqualsFalse() { LeadingSpace(); SendKeys.SendWait("= false{ESC}"); }
         public static void EqualsFalseSemicolon() { LeadingSpace(); SendKeys.SendWait("= false{ESC};"); }
         public static void EqualsIntPtrZero() { LeadingSpace(); SendKeys.SendWait("= IntPtr.{ESC}Zero{ESC};"); }
         public static void EqualsUIntPtrZero() { LeadingSpace(); SendKeys.SendWait("= UIntPtr.{ESC}Zero{ESC};"); }
         public static void EqualsNew() { LeadingSpace(); SendKeys.SendWait("= new{ESC} {TAB}"); }
         public static void EqualsNull() { LeadingSpace(); SendKeys.SendWait("= null"); }
         public static void EqualsNullSemicolon() { LeadingSpace(); SendKeys.SendWait("= null;"); }
         public static void EqualsThis() { LeadingSpace(); SendKeys.SendWait("= ^v{ESC}"); }
         public static void EqualsThisSemicolon() { LeadingSpace(); SendKeys.SendWait("= ^v{ESC};"); }
         public static void EqualsTrue() { LeadingSpace(); SendKeys.SendWait("= true{ESC}"); }
         public static void EqualsTrueSemicolon() { LeadingSpace(); SendKeys.SendWait("= true{ESC};"); }
         public static void EqualsZero() { LeadingSpace(); SendKeys.SendWait("= 0"); }
         public static void EqualsZeroSemicolon() { LeadingSpace(); SendKeys.SendWait("= 0;"); }
         public static void EventFunction() { SendKeys.SendWait("private void {(}object{ESC} pSender, EventArgs{ESC} pE{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 30}"); }
         public static void EventFunctionThis() { SendKeys.SendWait("private void "); SendKeys.SendWait("^v"); SendKeys.SendWait("{(}object{ESC} pSender, EventArgs{ESC} e{)} {{}{ENTER 2}{}}{UP}{END}"); }
         public static void ApplicationExitStatement() { SendKeys.SendWait("Application.{ESC}Exit{ESC}{(}{)};"); }
         public static void EnvironmentExitStatement() { SendKeys.SendWait("Environment.{ESC}Exit{ESC}{(}{)};"); }
         public static void FalseOnly() { LeadingSpace(); SendKeys.SendWait("false{ESC}"); }
         public static void FalseSemicolon() { LeadingSpace(); SendKeys.SendWait("false{ESC};"); }
         public static void FinallyOnly() { LeadingSpace(); SendKeys.SendWait("finally{ESC} {{}{ENTER}{}}{UP}{END}"); }
         public static void For() { LeadingSpace(); SendKeys.SendWait("for {(}variableType{ESC} i{ESC} = 0; i{ESC} CONDITIONAL XX; i{ESC}"); SendKeys.SendWait("{ESC}{+}{+}{)} {{}{ENTER}{}}{UP}{HOME}{RIGHT 5}+^{RIGHT}+{LEFT}"); }
         public static void ForEach() {
            Console.Beep(500, 500);//DEBUG Beep
            LeadingSpace();
            SendKeys.SendWait("foreach{ESC} {(}ClassType{ESC} variableName{ESC} in{ESC} whatList{ESC} {)} {{}{ENTER}{}}{UP}{HOME}{Right 9}^+{RIGHT}+{LEFT}");
         }
         public static void ForEachSimple() {
            Console.Beep(1500, 500);//DEBUG Beep
            LeadingSpace();
            SendKeys.SendWait("foreach{ESC} {(}ClassType{ESC} variableName{ESC} in{ESC} whatList{ESC} {)}{ENTER}{UP}{HOME}{Right 9}^+{RIGHT}+{LEFT}");
         }
         public static void ForInteger() { LeadingSpace(); SendKeys.SendWait("for{ESC} {(}int{ESC} i{ESC} = 0; i{ESC} CONDITIONAL XX; i{ESC}"); SendKeys.SendWait("{ESC}{+}{+}{)} {{}{ENTER}{}}{UP}{END}{LEFT 22}+^{RIGHT}+{LEFT}"); }
         public static void ForIntegerSimple() { LeadingSpace(); SendKeys.SendWait("for{ESC} {(}int{ESC} i{ESC} = 0; i{ESC} CONDITIONAL XX; i{ESC}"); SendKeys.SendWait("{ESC}{+}{+}{)}{ENTER}{UP}{END}{LEFT 20}+^{RIGHT}+{LEFT}"); }
         public static void FormattedMessageBoxConstructor() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{ESC}{(}string.{ESC}Format{ESC}{(}\"{{}0{}}\", XX{ESC}{)}, \"TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};{HOME}^{RIGHT 12}{RIGHT 2}+{RIGHT 2}"); }
         public static void FormattedMessageBoxConstructorDebug() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{ESC}{(}string.{ESC}Format{ESC}{(}\"{{}0{}}\", XX{ESC}{)}, \"TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};//DEBUG MessageBox{HOME}^{RIGHT 9}{RIGHT 4}+{RIGHT 2}"); }
         public static void GreaterThanOrEqualTo() { LeadingSpace(); SendKeys.SendWait(">= "); }
         public static void Height() { LeadingSpace(); SendKeys.SendWait("Height{ESC} "); }
         public static void HideStatement() { LeadingSpace(); SendKeys.SendWait("Hide{ESC}{(}{)};"); }
         public static void IfStringContains() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{ENTER}"); }
         public static void IfStringContainsCompound() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{{}{ENTER}{}}{Up}{End}"); }
         public static void IfStringContainsThis() { LeadingSpace(); SendKeys.SendWait("if {(}.{ESC}Contains{(}\"\"{)}{ENTER}{UP}{End}{Home}{Right 5}^v"); }
         public static void IfStringContainsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{{}{ENTER}{}}{Up}{End}{Home}{Right 5}^v"); }
         public static void IfStringDoesNotContain() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{ENTER}"); }
         public static void IfStringDoesNotContainCompound() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{{}{ENTER}{}}{Up}{End}"); }
         public static void IfStringDoesNotContainThis() { LeadingSpace(); SendKeys.SendWait("if {(}.{ESC}Contains{(}\"\"{)}{ENTER}{UP}{End}{Home}{Right 5}^v"); }
         public static void IfStringDoesNotContainCompoundThis() { LeadingSpace(); SendKeys.SendWait("if {(}XXX.{ESC}Contains{(}\"\"{)}{{}{ENTER}{}}{Up}{End}{Home}{Right 5}^v"); }
         public static void IfStringEquals() { LeadingSpace(); SendKeys.SendWait("if {(}string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}"); }
         public static void IfStringEqualsCompound() { LeadingSpace(); SendKeys.SendWait("if {(}string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{{}{ENTER}{}}"); }
         public static void IfStringEqualsThis() { LeadingSpace(); SendKeys.SendWait("if {(}string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}{UP}{END}{LEFT 43}^v{RIGHT 4}"); }
         public static void IfStringEqualsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if {(}string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 45}^v{RIGHT 4}"); }
         public static void IfNotStringEquals() { LeadingSpace(); SendKeys.SendWait("if {(}!string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}"); }
         public static void IfNotStringEqualsCompound() { LeadingSpace(); SendKeys.SendWait("if {(}!string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}"); }
         public static void IfNotStringEqualsThis() { LeadingSpace(); SendKeys.SendWait("if {(}!string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}{UP}{END}{LEFT 43}^v{RIGHT 4}"); }
         public static void IfNotStringEqualsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if {(}!string.{ESC}Equals {(}\"\", \"\", StringComparison.{ESC}OrdinalIgnoreCase{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 45}^v{RIGHT 4}"); }
         public static void IfCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); }
         public static void IfPartial() { SendKeys.SendWait("if{ESC} {(}{)} {{}"); }
         public static void IfPartialThis() { SendKeys.SendWait("if{ESC} {(}{)} {{}{LEFT 3}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfCompoundElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ENTER}{UP 3}{END}{LEFT 3}"); }
         public static void IfSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{ENTER}else{ESC}{UP}{END}{LEFT}"); }
         public static void IfSimpleElseIfSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{ENTER}else if {(}{)}{ENTER}else{ESC}{ESC}{UP 2}{END}{LEFT}"); }
         public static void IfThisSimpleElseIfSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{ENTER}else if {(}{)}{ENTER}else{ESC}{ESC}{UP 2}{END}{LEFT}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfNotThisSimpleElseIfSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{ENTER}else if {(}{)}{ENTER}else{ESC}{ESC}{UP 2}{END}{LEFT}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfCompoundElseIfCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else if {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 5}{END}{LEFT 3}"); }
         public static void IfCompoundThisElseIfCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else if {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 5}{END}{LEFT}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfNotCompoundThisElseIfCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else if {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 5}{END}{LEFT}"); SendKeys.SendWait("^v{END}"); SendKeys.SendWait("{END}"); }
         public static void IfThisSimpleElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); SendKeys.SendWait("^v{END}"); }
         public static void IfThisSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{LEFT}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{RIGHT}{ENTER}else{UP}{END}"); }
         public static void IfNotCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); }
         public static void IfNotCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); }
         public static void IfNotSimpleElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{ENTER}else{ESC} {{}{ENTER}{}}{UP 2}{END}{LEFT}"); }
         public static void IfNotSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{ENTER}else{ESC}{UP}{END}{LEFT}"); }
         public static void IfNotThisSimpleElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{END}"); }
         public static void IfNotThisSimpleElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{LEFT}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{RIGHT}{ENTER}else{UP}{END}"); }
         public static void IfNotSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{LEFT}"); }
         public static void IfNotCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); SendKeys.SendWait("^v{END}"); }
         public static void IfNotCompoundElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC}{ENTER}{UP 3}{END}{LEFT 3}"); }
         public static void IfCompoundElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}"); }
         public static void IfCompoundThisElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}^v{END}"); }
         public static void IfCompoundThisElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}^v{END}"); }
         public static void IfNotCompoundThisElseSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC}{UP 2}{END}{LEFT 3}^v{END}"); }
         public static void IfNotCompoundThisElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)} {{}{ENTER}{}}{ENTER}else{ESC} {{}{ENTER}{}}{UP 3}{END}{LEFT 3}^v{END}"); }
         public static void IfNotThisSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!{)}{LEFT}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{RIGHT}{ENTER}"); }
         public static void IfSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{LEFT}"); }
         public static void IfSimpleElseCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{ENTER}else{ESC} {{}{ENTER}{}}{UP 2}{END}{LEFT}"); }
         public static void IfThisSimple() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}{)}{LEFT}"); SendKeys.SendWait("^v"); SendKeys.SendWait("{RIGHT}{ENTER}"); }
         public static void IfStringEmpty() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)}{LEFT 2}"); }
         public static void IfThisStringEmpty() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)}{LEFT 2}^v"); }
         public static void IfStringNotEmpty() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)}{LEFT 2}"); }
         public static void IfThisStringNotEmpty() { LeadingSpace(); SendKeys.SendWait("{(}!string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)}{LEFT 2}^v"); }
         public static void IfStringEmptyCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 4}"); }
         public static void IfThisStringEmptyCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 4}^v"); }
         public static void IfStringNotEmptyCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 4}"); }
         public static void IfThisStringNotEmptyCompound() { LeadingSpace(); SendKeys.SendWait("{(}!string.{ESC}IsNullOrEmpty{ESC}{(}{)}{)} {{}{ENTER}{}}{UP}{END}{LEFT 4}^v"); }
         public static void IfStringsAreIdentical() {
            LeadingSpace();
            SendKeys.SendWait("if{ESC} {(}string.{ESC}Equals{ESC}{(}{\"}{\"}, {\"}{\"}, StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}{UP}{HOME}{RIGHT 19}");
         }
         public static void IfStringsAreIdenticalCompound() {
            LeadingSpace();
            SendKeys.SendWait("if{ESC} {(}string.{ESC}Equals{ESC}{(}{\"}{\"}, {\"}{\"}, StringComparison.{ESC}OrdinalIgnoreCase{)}{)} {{}{ENTER 2}{}}{UP 2}{HOME}{RIGHT 19}");
         }
         public static void IfStringsAreNotIdentical() {
            LeadingSpace();
            SendKeys.SendWait("if{ESC} {(}!string.{ESC}Equals{ESC}{(}{\"}{\"}, {\"}{\"}, StringComparison.{ESC}OrdinalIgnoreCase{)}{)}{ENTER}{UP}{HOME}{RIGHT 20}");
         }
         public static void IfStringsAreNotIdenticalCompound() {
            LeadingSpace();
            SendKeys.SendWait("if{ESC} {(}!string.{ESC}Equals{ESC}{(}{\"}{\"}, {\"}{\"}, StringComparison.{ESC}OrdinalIgnoreCase{)}{)} {{}{ENTER 2}{}}{UP 2}{HOME}{RIGHT 20}");
         }
         public static void IfFileExists() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}"); }
         public static void IfFileExistsCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}"); }
         public static void IfNotFileExists() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}"); }
         public static void IfNotFileExistsCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}"); }
         public static void IfFileExistsThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}^v"); }
         public static void IfFileExistsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}^v"); }
         public static void IfNotFileExistsThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}^v"); }
         public static void IfNotFileExistsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!File.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}^v"); }
         public static void IfFolderExists() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}"); }
         public static void IfFolderExistsCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}"); }
         public static void IfNotFolderExists() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}"); }
         public static void IfNotFolderExistsCompound() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}"); }
         public static void IfFolderExistsThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}^v"); }
         public static void IfFolderExistsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}^v"); }
         public static void IfNotFolderExistsThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)}{ENTER}{UP}{END}{LEFT 3}^v"); }
         public static void IfNotFolderExistsCompoundThis() { LeadingSpace(); SendKeys.SendWait("if{ESC} {(}!Folder.{ESC}Exists{ESC}{(}{\"}{\"}{)}{)} {{}{ENTER 2}{}}{UP 2}{END}{LEFT 5}^v"); }
         public static void IfIsNullSimple() { LeadingSpace(); SendKeys.SendWait("if {(} == null{)}{ENTER}"); }
         public static void IfIsNotNullSimple() { LeadingSpace(); SendKeys.SendWait("if {(} != null{)}{ENTER}"); }
         public static void IfIsNullCompound() { LeadingSpace(); SendKeys.SendWait("if {(} == null{)} {{}{ENTER 2}{}}{UP}"); }
         public static void IfIsNotNullCompound() { LeadingSpace(); SendKeys.SendWait("if {(} != null{)} {{}{ENTER 2}{}}{UP}"); }
         public static void IfThisIsNullSimple() { LeadingSpace(); SendKeys.SendWait("if {(}"); SendKeys.SendWait("^v"); SendKeys.SendWait(" == null{)}{ENTER}"); }
         public static void IfThisIsNotNullSimple() { LeadingSpace(); SendKeys.SendWait("if {(}"); SendKeys.SendWait("^v"); SendKeys.SendWait(" != null{)}{ENTER}"); }
         public static void IfThisIsNullCompound() { LeadingSpace(); SendKeys.SendWait("if {(}"); SendKeys.SendWait("^v"); SendKeys.SendWait(" == null{)} {{}{ENTER 2}"); SendKeys.SendWait("{}}{UP}"); }
         public static void IfThisIsNotNullCompound() { LeadingSpace(); SendKeys.SendWait("if {(}"); SendKeys.SendWait("^v"); SendKeys.SendWait(" != null{)} {{}{ENTER 2}"); SendKeys.SendWait("{}}{UP}"); }
         public static void IfTryParseDouble() {
            SendKeys.SendWait("if {(}double.{ESC}TryParse{(}XXX, out double oDouble{)} {{}{ENTER 2}{}}{ENTER}");
            SendKeys.SendWait("else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 26}+{RIGHT 3}");
         }
         public static void IfTryParseFloat() {
            SendKeys.SendWait("if {(}float.{ESC}TryParse{(}XXX, out float oFloat{)} {{}{ENTER 2}{}}{ENTER}else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 24}+{RIGHT 3}");
         }
         public static void IfTryParseInteger() {
            SendKeys.SendWait("if {(}int.{ESC}TryParse{(}XXX, out int oInteger{)} {{}{ENTER 2}{}}{ENTER}else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 24}+{RIGHT 3}");
         }
         public static void IfNotTryParseDouble() {
            SendKeys.SendWait("if {(}{!}double.{ESC}TryParse{(}XXX, out double oDouble{)} {{}{ENTER 2}{}}{ENTER}else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 26}+{RIGHT 3}");
         }
         public static void IfNotTryParseFloat() {
            SendKeys.SendWait("if {(}{!}float.{ESC}TryParse{(}XXX, out float oFloat{)} {{}{ENTER 2}{}}{ENTER}else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 24}+{RIGHT 3}");
         }
         public static void IfNotTryParseInteger() {
            SendKeys.SendWait("if {(}{!}int.{ESC}TryParse{(}XXX, out int oInteger{)} {{}{ENTER 2}{}}{ENTER}else {{}{ENTER 2}{}}{UP 5}{END}{LEFT 24}+{RIGHT 3}");
         }
         public static void IntPtrX() { LeadingSpace(); SendKeys.SendWait("IntPtr{ESC} "); }
         public static void IntPtrZero() { LeadingSpace(); SendKeys.SendWait("IntPtr.{ESC}Zero{ESC}"); }
         public static void IntPtrZeroSemicolon() { LeadingSpace(); SendKeys.SendWait("IntPtr.{ESC}Zero{ESC};"); }
         public static void UIntPtrX() { LeadingSpace(); SendKeys.SendWait("UIntPtr{ESC} "); }
         public static void UIntPtrZero() { LeadingSpace(); SendKeys.SendWait("UIntPtr.{ESC}Zero{ESC}"); }
         public static void UIntPtrZeroSemicolon() { LeadingSpace(); SendKeys.SendWait("UIntPtr.{ESC}Zero{ESC};"); }
         public static void Left() { LeadingSpace(); SendKeys.SendWait("Left{ESC} "); }
         public static void LeftAngleBracket() { LeadingSpace(); SendKeys.SendWait("< "); }
         public static void LeftCurlyBrace() { LeadingSpace(); SendKeys.SendWait("{{}"); }
         public static void LeftParentheses() { LeadingSpace(); SendKeys.SendWait("{(}"); }
         public static void LeftSquareBracket() { LeadingSpace(); SendKeys.SendWait("["); }
         public static void LessThanOrEqualTo() { LeadingSpace(); SendKeys.SendWait("<= "); }
         public static void Location() { LeadingSpace(); SendKeys.SendWait("Location "); }
         public static void LocationDot() { LeadingSpace(); SendKeys.SendWait("Location{ESC}.{ESC}"); }
         public static void LogicalAnd() { LeadingSpace(); SendKeys.SendWait("&& "); }
         public static void LogicalEquals() { LeadingSpace(); SendKeys.SendWait("== "); }
         public static void LogicalEqualsThis() { LeadingSpace(); SendKeys.SendWait("== ^v{ESC}"); }
         public static void LogicalNot() { LeadingSpace(); SendKeys.SendWait("!"); }
         public static void LogicalOr() { LeadingSpace(); SendKeys.SendWait("|| "); }
         public static void MathAbsolute() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Abs{(}{)}{LEFT}"); }
         public static void MathCeiling() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Ceiling{(}{)}{LEFT}"); }
         public static void MathFloor() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Floor{(}{)}{LEFT}"); }
         public static void MathMax() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Max{(}, {)}{LEFT 3}"); }
         public static void MathMin() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Min{(}, {)}{LEFT 3}"); }
         public static void MathRound() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Round{(}{)}{LEFT}"); }
         public static void MathTruncate() { LeadingSpace(); SendKeys.SendWait("Math{ESC}.{ESC}Truncate{(}{)}{LEFT}"); }
         public static void MessageBoxConstructor() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{ESC}{(}\"\", \"TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};{HOME}^{RIGHT 3}{RIGHT 2}"); }
         public static void MessageBoxConstructorThis() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{(}, \"TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};{HOME}^{RIGHT 3}{RIGHT}^v"); }
         public static void MessageBoxConstructorDebug() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{(}\"\", \"DEBUG TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};//DEBUG MessageBox{HOME}^{RIGHT 3}{RIGHT 2}"); }
         public static void MessageBoxConstructorDebugThis() { LeadingSpace(); SendKeys.SendWait("MessageBox.{ESC}Show{(}, \"DEBUG TITLE\", MessageBoxButtons.{ESC}OK, MessageBoxIcon.{ESC}Error{)};//DEBUG MessageBox{HOME}^{RIGHT 3}{RIGHT}^v"); }
         public static void MinusEquals() { LeadingSpace(); SendKeys.SendWait("-= "); }
         public static void MinusSign() { LeadingSpace(); SendKeys.SendWait("- "); }
         public static void Modulo() { LeadingSpace(); SendKeys.SendWait("{%} "); }
         public static void Namespace() { LeadingSpace(); SendKeys.SendWait("namespace{ESC} "); }
         public static void NewOnly() { LeadingSpace(); SendKeys.SendWait("new{ESC} "); }
         public static void NewButton() {
            SendKeys.SendWait("Button {ESC}button {ESC}= new {ESC}Button {ESC}{{}{ENTER}");
            SendKeys.SendWait("Font {ESC}= XXX,{ENTER}Location {ESC}= XXX,{ENTER 2}{}};{UP}");
         }
         public static void NewLabel() {
            SendKeys.SendWait("Label {ESC}label {ESC}= new {ESC}Label {ESC}{{}{ENTER}");
            SendKeys.SendWait("Font {ESC}= XXX,{ENTER}Location {ESC}= XXX,{ENTER 2}{}};{UP}");
         }
         public static void NewPanel() {
            SendKeys.SendWait("Panel {ESC}panel {ESC}= new {ESC}Panel {ESC}{{}{ENTER}");
            SendKeys.SendWait("Font {ESC}= XXX,{ENTER}Location {ESC}= XXX,{ENTER 2}{}};{UP}");
         }
         public static void NewPoint() { SendKeys.SendWait("Point {ESC}point = new {ESC}Point{ESC}{(}, {)};{LEFT 4}"); }
         public static void NewRectangle() { SendKeys.SendWait("Rectangle {ESC}rectangle = new {ESC}Rectangle{ESC}{(}, , , {)};{LEFT 8}"); }
         public static void NewSize() { SendKeys.SendWait("Size {ESC}size = new {ESC}Size{ESC}{(}, {)};{LEFT 4}"); }
         public static void NotEquals() { LeadingSpace(); SendKeys.SendWait("!= "); }
         public static void NullOnly() { LeadingSpace(); SendKeys.SendWait("null{ESC}"); }
         public static void ParseDouble() { LeadingSpace(); SendKeys.SendWait("double{ESC}.{ESC}Parse{ESC}{(}XXX{)}{LEFT 4}+{RIGHT 3}"); }
         public static void ParseFloat() { LeadingSpace(); SendKeys.SendWait("float{ESC}.{ESC}Parse{ESC}{(}XXX{)}{LEFT 4}+{RIGHT 3}"); }
         public static void ParseInteger() { LeadingSpace(); SendKeys.SendWait("int{ESC}.{ESC}Parse{ESC}{(}XXX{)}{LEFT 4}+{RIGHT 3}"); }
         public static void PlusEquals() { LeadingSpace(); SendKeys.SendWait("{+}= "); }
         public static void PlusPlus() { LeadingSpace(); SendKeys.SendWait("{+}{+} "); }
         public static void PlusSign() { LeadingSpace(); SendKeys.SendWait("{+} "); }
         public static void Point() { LeadingSpace(); SendKeys.SendWait("Point{ESC} "); }
         public static void PoundDefine() { LeadingSpace(); SendKeys.SendWait("#define{ESC}"); }
         public static void PoundElse() { LeadingSpace(); SendKeys.SendWait("#else{ESC}"); }
         public static void PoundElseIf() { LeadingSpace(); SendKeys.SendWait("#elif{ESC}"); }
         public static void PoundEndIf() { LeadingSpace(); SendKeys.SendWait("#endif{ESC}"); }
         public static void PoundIf() { LeadingSpace(); SendKeys.SendWait("#if{ESC}"); }
         public static void PoundIfNot() { LeadingSpace(); SendKeys.SendWait("#if{ESC} !"); }
         public static void PoundRegion() { LeadingSpace(); SendKeys.SendWait("#region{ESC}"); }
         public static void PoundUndefine() { LeadingSpace(); SendKeys.SendWait("#undef{ESC}"); }
         public static void RectangleOnly() { LeadingSpace(); SendKeys.SendWait("Rectangle{ESC} "); }
         public static void ReturnFalse() { LeadingSpace(); SendKeys.SendWait("return{ESC} false{ESC};"); }
         public static void ReturnOnly() { LeadingSpace(); SendKeys.SendWait("return{ESC};"); }
         public static void ReturnThis() { LeadingSpace(); SendKeys.SendWait("return{ESC} ^v;"); }
         public static void ReturnTrue() { LeadingSpace(); SendKeys.SendWait("return{ESC} true{ESC};"); }
         public static void Right() { LeadingSpace(); SendKeys.SendWait("Right{ESC} "); }
         public static void RightAngleBracket() { LeadingSpace(); SendKeys.SendWait("> "); }
         public static void RightCurlyBrace() { LeadingSpace(); SendKeys.SendWait("{}}"); }
         public static void RightParentheses() { LeadingSpace(); SendKeys.SendWait("{)}"); }
         public static void RightSquareBracket() { LeadingSpace(); SendKeys.SendWait("]"); }
         public static void ScrollBarHeight() { LeadingSpace(); SendKeys.SendWait("SystemInformation.{ESC}HorizontalScrollBarHeight{ESC}"); }
         public static void ScrollBarWidth() { LeadingSpace(); SendKeys.SendWait("SystemInformation.{ESC}VerticalScrollBarWidth{ESC}"); }
         public static void SendSomeKeys() { LeadingSpace(); SendKeys.SendWait("SendKeys.SendWait{ESC}{(}\"\"{)};{LEFT 3}"); }
         public static void SendBACKSPACE() { SendKeys.SendWait("{{}BACKSPACE{ESC}{}}"); SendFormat(); }
         public static void SendBREAK() { SendKeys.SendWait("{{}BREAK{ESC}{}}"); SendFormat(); }
         public static void SendCAPSLOCK() { SendKeys.SendWait("{{}CAPSLOCK{ESC}{}}"); SendFormat(); }
         public static void SendDELETE() { SendKeys.SendWait("{{}DELETE{ESC}{}}"); SendFormat(); }
         public static void SendDOWN() { SendKeys.SendWait("{{}DOWN{ESC}{}}"); SendFormat(); }
         public static void SendEND() { SendKeys.SendWait("{{}END{ESC}{}}"); SendFormat(); }
         public static void SendENTER() { SendKeys.SendWait("{{}ENTER{ESC}{}}"); SendFormat(); }
         public static void SendESC() { SendKeys.SendWait("{{}ESC{ESC}{}}"); SendFormat(); }
         public static void SendHELP() { SendKeys.SendWait("{{}HELP{ESC}{}}"); SendFormat(); }
         public static void SendHOME() { SendKeys.SendWait("{{}HOME{ESC}{}}"); SendFormat(); }
         public static void SendINSERT() { SendKeys.SendWait("{{}INSERT{ESC}{}}"); SendFormat(); }
         public static void SendLEFT() { SendKeys.SendWait("{{}LEFT{ESC}{}}"); SendFormat(); }
         public static void SendNUMLOCK() { SendKeys.SendWait("{{}NUMLOCK{ESC}{}}"); SendFormat(); }
         public static void SendPGDN() { SendKeys.SendWait("{{}PGDN{ESC}{}}"); SendFormat(); }
         public static void SendPGUP() { SendKeys.SendWait("{{}PGUP{ESC}{}}"); SendFormat(); }
         public static void SendPRTSC() { SendKeys.SendWait("{{}PRTSC{ESC}{}}"); SendFormat(); }
         public static void SendRIGHT() { SendKeys.SendWait("{{}RIGHT{ESC}{}}"); SendFormat(); }
         public static void SendSCROLLLOCK() { SendKeys.SendWait("{{}SCROLLLOCK{ESC}{}}"); SendFormat(); }
         public static void SendTAB() { SendKeys.SendWait("{{}TAB{ESC}{}}"); SendFormat(); }
         public static void SendUP() { SendKeys.SendWait("{{}UP{ESC}{}}"); SendFormat(); }
         public static void SendF1() { SendKeys.SendWait("{{}F1{ESC}{}}"); SendFormat(); }
         public static void SendF2() { SendKeys.SendWait("{{}F2{ESC}{}}"); SendFormat(); }
         public static void SendF3() { SendKeys.SendWait("{{}F3{ESC}{}}"); SendFormat(); }
         public static void SendF4() { SendKeys.SendWait("{{}F4{ESC}{}}"); SendFormat(); }
         public static void SendF5() { SendKeys.SendWait("{{}F5{ESC}{}}"); SendFormat(); }
         public static void SendF6() { SendKeys.SendWait("{{}F6{ESC}{}}"); SendFormat(); }
         public static void SendF7() { SendKeys.SendWait("{{}F7{ESC}{}}"); SendFormat(); }
         public static void SendF8() { SendKeys.SendWait("{{}F8{ESC}{}}"); SendFormat(); }
         public static void SendF9() { SendKeys.SendWait("{{}F9{ESC}{}}"); SendFormat(); }
         public static void SendF10() { SendKeys.SendWait("{{}F10{ESC}{}}"); SendFormat(); }
         public static void SendF11() { SendKeys.SendWait("{{}F11{ESC}{}}"); SendFormat(); }
         public static void SendF12() { SendKeys.SendWait("{{}F12{ESC}{}}"); SendFormat(); }
         public static void SendF13() { SendKeys.SendWait("{{}F13{ESC}{}}"); SendFormat(); }
         public static void SendF14() { SendKeys.SendWait("{{}F14{ESC}{}}"); SendFormat(); }
         public static void SendF15() { SendKeys.SendWait("{{}F15{ESC}{}}"); SendFormat(); }
         public static void SendF16() { SendKeys.SendWait("{{}F16{ESC}{}}"); SendFormat(); }
         public static void SendF17() { SendKeys.SendWait("{{}F17{ESC}{}}"); SendFormat(); }
         public static void SendF18() { SendKeys.SendWait("{{}F18{ESC}{}}"); SendFormat(); }
         public static void SendF19() { SendKeys.SendWait("{{}F19{ESC}{}}"); SendFormat(); }
         public static void SendF20() { SendKeys.SendWait("{{}F20{ESC}{}}"); SendFormat(); }
         public static void SendF21() { SendKeys.SendWait("{{}F21{ESC}{}}"); SendFormat(); }
         public static void SendF22() { SendKeys.SendWait("{{}F22{ESC}{}}"); SendFormat(); }
         public static void SendF23() { SendKeys.SendWait("{{}F23{ESC}{}}"); SendFormat(); }
         public static void SendF24() { SendKeys.SendWait("{{}F24{ESC}{}}"); SendFormat(); }
         public static void SendADD() { SendKeys.SendWait("{{}ADD{ESC}{}}"); SendFormat(); }
         public static void SendSUBTRACT() { SendKeys.SendWait("{{}SUBTRACT{ESC}{}}"); SendFormat(); }
         public static void SendMULTIPLY() { SendKeys.SendWait("{{}MULTIPLY{ESC}{}}"); SendFormat(); }
         public static void SendDIVIDE() { SendKeys.SendWait("{{}DIVIDE{ESC}{}}"); SendFormat(); }
         public static void SendSHIFT() { SendKeys.SendWait("{+}"); SendFormat(); }
         public static void SendCONTROL() { SendKeys.SendWait("{^}"); SendFormat(); }
         public static void SendALTERNATE() { SendKeys.SendWait("{%}"); SendFormat(); }
         public static void ShellExecute() { SendKeys.SendWait("ShellExecute{ESC}"); }
         public static void ShellExecuteConstructor() { SendKeys.SendWait("ShellExecute{ESC} \"\" & \" \" & ListVar1, 7"); }
         public static void ShowStatement() { LeadingSpace(); SendKeys.SendWait("Show{ESC}{(}{)};"); }
         public static void SimpleElse() { LeadingSpace(); SendKeys.SendWait("else{ESC}{ENTER}"); }
         public static void Size() { LeadingSpace(); SendKeys.SendWait("Size{ESC} "); }
         public static void SizeDot() { LeadingSpace(); SendKeys.SendWait("Size{ESC}.{ESC}"); }
         public static void SizeOf() { LeadingSpace(); SendKeys.SendWait("SizeOf{ESC}{(}{)}"); }
         public static void Slash() { LeadingSpace(); SendKeys.SendWait("/ "); }
         public static void StaticCast() { LeadingSpace(); SendKeys.SendWait("static_cast{ESC}<>{(}{)}{LEFT 3}"); }
         public static void StringEmpty() { LeadingSpace(); SendKeys.SendWait("string.{ESC}Empty{ESC}"); }
         public static void StringEmptySemicolon() { LeadingSpace(); SendKeys.SendWait("string.{ESC}Empty{ESC};"); }
         public static void StringFormat() { LeadingSpace(); SendKeys.SendWait("string.{ESC}Format{ESC}{(}\"{{}0{}}\", XX{ESC}{)}"); }
         public static void StringIsNullOrEmpty() { LeadingSpace(); SendKeys.SendWait("string.{ESC}IsNullOrEmpty{ESC}{(}{)}{LEFT}"); }
         public static void Structure() { LeadingSpace(); SendKeys.SendWait("struct{ESC} "); }
         public static void SwitchOnly() { LeadingSpace(); SendKeys.SendWait("switch{ESC} {(}{)} {{}{ENTER}{}}{UP}{END}{LEFT 3}"); }
         public static void SwitchConstructor() { LeadingSpace(); SendKeys.SendWait("switch{ESC} {(}{)} {{}{ENTER}"); SendKeys.SendWait("case{ESC} \"\":{ENTER}"); SendKeys.SendWait("break;{ENTER}"); SendKeys.SendWait("default:{ENTER}"); SendKeys.SendWait("break;{ENTER}"); SendKeys.SendWait("{}}{UP 5}{END}{LEFT 3}"); }
         public static void Text() { LeadingSpace(); SendKeys.SendWait("Text{ESC}"); }
         public static void This() { LeadingSpace(); SendKeys.SendWait("this{ESC}"); }
         public static void ThreadSleep() { LeadingSpace(); SendKeys.SendWait("Thread{ESC}.{ESC}Sleep{(}{)}{ESC};{LEFT 2}"); }
         public static void Tilde() { LeadingSpace(); SendKeys.SendWait("{~}"); }
         public static void TimesEquals() { LeadingSpace(); SendKeys.SendWait("*= "); }
         public static void Top() { LeadingSpace(); SendKeys.SendWait("Top{ESC} "); }
         public static void TrueOnly() { LeadingSpace(); SendKeys.SendWait("true{ESC}"); }
         public static void TrueSemicolon() { LeadingSpace(); SendKeys.SendWait("true{ESC};"); }
         public static void TryCatch() {
            SendKeys.SendWait("try{ESC} {{}{ENTER 2}{}}{ENTER}");
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("_ = AskingAsync{(}new TM{(}\"\", pException{)}{)};{ENTER}{}}{UP 4}");
         }
         public static void TryCatchThis() {
            SendKeys.SendWait("try{ESC} {{}{ENTER}{}}{ENTER}");
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("_ = AskingAsync{(}new TM{(}\"\", pException{)}{)};{ENTER}{}}{UP}{END}{LEFT 16}^v{UP 4}");
         }
         public static void TryCatchFinally() {
            SendKeys.SendWait("try{ESC} {{}{ENTER 2}{}}{ENTER}");
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("_ = AskingAsync{(}new TM{(}\"\", pException{)}{)};{ENTER}{}}{ENTER}");
            SendKeys.SendWait("finally {{}{ENTER 2}{}}{UP 7}");
         }
         public static void TryCatchFinallyThis() {
            SendKeys.SendWait("try{ESC} {{}{ENTER 2}{}}{ENTER}");
            SendKeys.SendWait("catch{ESC} {(}Exception{ESC} pException{ESC}{)} {{}{ENTER}");
            SendKeys.SendWait("_ = AskingAsync{(}new TM{(}\"\", pException{)}{)};{LEFT 16}^v{END}{ENTER}{}}{ENTER}");
            SendKeys.SendWait("finally {{}{ENTER 2}{}}{UP 7}");
         }
         public static void TryOnly() { SendKeys.SendWait("try{ESC} {{}{ENTER}{}}{UP}{END}"); }
         public static void TryOnlyPartial() { SendKeys.SendWait("try{ESC} {{}"); }
         public static void TryParseDouble() {
            LeadingSpace();
            SendKeys.SendWait("double{ESC}.{ESC}TryParse{ESC}{(}XXX, out double oDouble{)};{LEFT 25}+{RIGHT 3}");
         }
         public static void TryParseFloat() {
            LeadingSpace();
            SendKeys.SendWait("float{ESC}.{ESC}TryParse{ESC}{(}XXX, out float oFloat{)};{LEFT 23}+{RIGHT 3}");
         }
         public static void TryParseInteger() {
            LeadingSpace();
            SendKeys.SendWait("int{ESC}.{ESC}TryParse{ESC}{(}XXX, out int oInteger{)};{LEFT 23}+{RIGHT 3}");
         }
         public static void TypeOf() { LeadingSpace(); SendKeys.SendWait("TypeOf{ESC}"); }
         public static void Using() { LeadingSpace(); SendKeys.SendWait("using{ESC} "); }
         public static void UsingStatic() { LeadingSpace(); SendKeys.SendWait("using{ESC} static{ESC} "); }
         public static void VerticalBar() { LeadingSpace(); SendKeys.SendWait("| "); }
         public static void WidthOnly() { LeadingSpace(); SendKeys.SendWait("Width{ESC} "); }
         public static void ZZZ() { return; }//A do-nothing function for adding comments to the "What Can I Say" entries

         private static void LeadingSpace() {
            //if (gAddASpace)
            SendKeys.SendWait(" ");
         }

         private static void SendFormat() {
            if (gSendFormatting)
               SendKeys.SendWait("{LEFT}^{LEFT}^{RIGHT}");
         }
      }
   }
}