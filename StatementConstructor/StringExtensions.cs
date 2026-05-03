using System.Text.RegularExpressions;

namespace StatementConstructors {
   public static class StringExtensions {
      public static string FirstCharToUpper(this string pInput) {
         switch (pInput) {
            case null:
               throw new ArgumentNullException(nameof(pInput));
            case "":
               return string.Empty;
            //case "": throw new ArgumentException($"{nameof(pInput)} cannot be empty", nameof(pInput));
            default:
               return pInput.First().ToString().ToUpper() + pInput.Substring(1);
         }
      }

      public static string FirstCharToLower(this string pInput) {
         switch (pInput) {
            case null:
               throw new ArgumentNullException(nameof(pInput));
            case "":
               return string.Empty;
            //case "": throw new ArgumentException($"{nameof(pInput)} cannot be empty", nameof(pInput));
            default:
               return pInput.First().ToString().ToLower() + pInput.Substring(1);
         }
      }

      public static string NormalizeSpacing(this string pInput, bool pRemoveTrailing = true) {
         switch (pInput) {
            case null:
               throw new ArgumentNullException(nameof(pInput));
            case "":
               return string.Empty;
            default: {
                  string normalizedString = CompressWhiteSpace(pInput);
                  normalizedString = RemoveLeadingSpaces(normalizedString);
                  if (pRemoveTrailing)
                     normalizedString = RemoveTrailingSpaces(normalizedString);
                  return normalizedString;
               }
         }
      }

      public static string RemoveLeadingSpaces(string pName) {
         string returnString = pName;
         char[] charsToTrim = [' ', '\t'];
         returnString = returnString.TrimStart(charsToTrim);
         return returnString;
      }

      public static string RemoveTrailingSpaces(string pName) {
         string returnString = pName;
         char[] charsToTrim = [' ', '\t'];
         returnString = returnString.TrimEnd(charsToTrim);
         return returnString;
      }

      public static string CompressWhiteSpace(string pName) {
         //compresses all duplicate identical white spaces into a single one 
         //NOTE: the string is NOT trimmed of leading nor trailing spaces
         /*A string that looks like:
               " Word<space><space>another word<tab><tab> "
           Becomes:                          
               " Word<space>another word<tab> "
           But                       
               "Word<space><tab>another word<tab><tab>"
           Becomes:                          
               "Word<space><tab>another word<tab>"
         */
         int nameLength = pName.Length,
             index = 0,
             i = 0;
         char[] nameAsCharacterArray = pName.ToCharArray();
         bool skip = false;
         char individualCharacter;
         for (; i < nameLength; i++) {
            individualCharacter = nameAsCharacterArray[i];
            switch (individualCharacter) {
               case '\u0020':
               case '\u00A0':
               case '\u1680':
               case '\u2000':
               case '\u2001':
               case '\u2002':
               case '\u2003':
               case '\u2004':
               case '\u2005':
               case '\u2006':
               case '\u2007':
               case '\u2008':
               case '\u2009':
               case '\u200A':
               case '\u202F':
               case '\u205F':
               case '\u3000':
               case '\u2028':
               case '\u2029':
               case '\u0009':
               case '\u000A':
               case '\u000B':
               case '\u000C':
               case '\u000D':
               case '\u0085':
                  if (skip)
                     continue;
                  nameAsCharacterArray[index++] = individualCharacter;
                  skip = true;
                  continue;
               default:
                  skip = false;
                  nameAsCharacterArray[index++] = individualCharacter;
                  continue;
            }
         }
         string returnString = new string(nameAsCharacterArray, 0, index);
         if (returnString.Contains("  ")) {
            do {
               returnString = returnString.Replace("  ", " ");
            }
            while (returnString.Contains("  "));
         }
         if (returnString.Contains("( "))
            returnString = returnString.Replace("( ", "(");
         if (returnString.Contains(" ;"))
            returnString = returnString.Replace(" ;", ";");
         return returnString;
      }

      public static string CapitalizeAllWords(string pName) {
         char[] delimiters = [' ', '“', '‘', '(', '[', '\t', '¡', '¿'];
         string characterToChange = "";
         string precedingCharacter = "";
         int length = pName.Length;
         char[] resultString = pName.ToCharArray();

         for (int i = 0; i < length; i++) {
            characterToChange = pName.Substring(i, 1);
            if (i == 0) {
               characterToChange = characterToChange.ToUpper();
               resultString[i] = Char.Parse(characterToChange);
            }
            else {
               precedingCharacter = pName.Substring(i - 1, 1);
               foreach (char delimiter in delimiters) {
                  if (delimiter == Char.Parse(precedingCharacter))
                     characterToChange = characterToChange.ToUpper();
               }
               resultString[i] = Char.Parse(characterToChange);
            }
         }
         string returnString = new string(resultString);
         char[] charsToTrim = [' ', '\t'];
         returnString = returnString.Trim(charsToTrim);
         return returnString;
      }

      public static bool StringContainsPhrase(string pString, string pWord) {
         string pattern = @"\b" + Regex.Escape(pWord) + @"\b";

         return Regex.IsMatch(pString, pattern, RegexOptions.IgnoreCase);
      }

      public static string StringReplaceWord(string pString, string pWord, string pReplacement) {
         string pattern = @"\b" + Regex.Escape(pWord) + @"\b";

         return Regex.Replace(pString, pattern, pReplacement);
      }
   }
}
