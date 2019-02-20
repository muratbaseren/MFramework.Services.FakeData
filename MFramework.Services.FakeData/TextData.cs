using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MFramework.Services.FakeData
{

    public static class TextData
    {
        public static string GetAlphabetical(int length)
        {
            return TextData.GetSubString(length, "abcdefghijkmnopqrstuvwxyz");
        }

        public static string GetAlphaNumeric(int length)
        {
            return TextData.GetSubString(length, "0123456789abcdefghijkmnopqrstuvwxyz");
        }

        public static string GetNumeric(int length)
        {
            return TextData.GetSubString(length, "0123456789");
        }

        public static string GetPatternString(string pattern)
        {
            string str = Regex.Replace(pattern, "[#\\?]", (Match m) => (m.ToString() == "#" ? TextData.GetNumeric(1) : TextData.GetAlphabetical(1)));
            return str;
        }

        public static string GetSentence()
        {
            return TextData.GetSentences(1);
        }

        public static string GetSentences(int count)
        {
            HashSet<string> strs = new HashSet<string>();
            strs.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            strs.Add("Suspendisse pharetra massa sed leo commodo malesuada.");
            strs.Add("Donec volutpat turpis congue, suscipit dui eget, tempus lorem.");
            strs.Add("Suspendisse laoreet ligula ac dolor egestas gravida.");
            strs.Add("Proin at leo eget odio condimentum faucibus.");
            strs.Add("Donec interdum velit a orci consectetur, non mollis diam hendrerit.");
            strs.Add("Sed dignissim augue eget orci vulputate, a pellentesque odio facilisis.");
            strs.Add("Nullam tincidunt arcu sit amet nisl tempor, ac dictum odio tincidunt.");
            strs.Add("Nam vitae purus gravida, dignissim lacus in, venenatis elit.");
            strs.Add("In eu justo sed est faucibus tincidunt non quis ligula.");
            strs.Add("In laoreet justo et condimentum bibendum.");
            strs.Add("Phasellus pharetra leo eu tempor molestie.");
            strs.Add("Nulla hendrerit ligula in eros suscipit sagittis.");
            strs.Add("Nunc ac sem quis augue pharetra volutpat.");
            strs.Add("Etiam scelerisque nisl sed urna dictum mattis.");
            strs.Add("Suspendisse a lectus at nibh luctus faucibus.");
            strs.Add("Nulla a ligula laoreet, viverra purus vel, suscipit enim.");
            strs.Add("Suspendisse a diam vitae erat pretium pharetra.");
            strs.Add("Nulla in metus sed mauris faucibus scelerisque ut vel augue.");
            strs.Add("Maecenas ac ligula interdum, faucibus leo in, faucibus quam.");
            strs.Add("Duis gravida erat et euismod consequat.");
            strs.Add("Ut rutrum massa sit amet tortor lacinia, id mollis massa bibendum.");
            strs.Add("Phasellus non ante non lectus ullamcorper faucibus id a eros.");
            strs.Add("Curabitur imperdiet dolor eget volutpat ultrices.");
            strs.Add("Duis cursus risus et nisi suscipit sollicitudin.");
            strs.Add("Maecenas sed leo mollis, egestas mauris vitae, porta risus.");
            strs.Add("Vivamus facilisis lectus in suscipit facilisis.");
            strs.Add("Nam tincidunt orci vel pellentesque sagittis.");
            strs.Add("Vestibulum in enim nec eros faucibus elementum sed vitae dolor.");
            strs.Add("Etiam imperdiet nibh vitae sapien fringilla, vitae vulputate quam tincidunt.");
            strs.Add("Nullam quis turpis eu urna vehicula ornare vel et enim.");
            strs.Add("Phasellus tincidunt nunc eu orci vehicula bibendum.");
            strs.Add("Pellentesque commodo risus vitae orci pretium tincidunt.");
            strs.Add("Curabitur sed lorem a dui consequat congue.");
            strs.Add("Donec varius libero nec ligula congue volutpat.");
            strs.Add("Ut eget neque porttitor, aliquet nibh at, sodales tellus.");
            strs.Add("Curabitur sed urna eget dui laoreet semper id sit amet erat.");
            strs.Add("Fusce scelerisque sapien ornare neque pharetra aliquam.");
            strs.Add("Nullam et tellus posuere, consectetur ante eget, iaculis lorem.");
            strs.Add("Sed adipiscing dolor eget turpis eleifend eleifend.");
            strs.Add("Morbi et mi id sapien consequat rutrum in quis risus.");
            strs.Add("Morbi sit amet nibh eget eros tempor mollis vel nec lacus.");
            strs.Add("Pellentesque accumsan mi eu velit ultrices varius.");
            strs.Add("Maecenas tincidunt leo id nibh vestibulum, in feugiat justo varius.");
            strs.Add("In facilisis dui sed odio dictum laoreet.");
            strs.Add("Nunc ac ipsum sed purus consectetur sodales.");
            strs.Add("Nullam consectetur enim in sem varius gravida.");
            strs.Add("Vivamus et felis ut augue laoreet mollis.");
            strs.Add("Praesent hendrerit odio quis arcu feugiat luctus.");
            strs.Add("Nullam et enim congue, pretium eros id, pretium nibh.");
            strs.Add("Fusce sollicitudin magna ut risus ullamcorper, ut ullamcorper elit adipiscing.");
            strs.Add("Donec tincidunt felis sit amet rutrum faucibus.");
            strs.Add("Suspendisse tempor dui id libero interdum, vulputate malesuada felis dapibus.");
            strs.Add("Nulla malesuada massa eget nunc accumsan placerat.");
            strs.Add("Mauris nec est quis libero interdum condimentum.");
            strs.Add("Etiam tincidunt augue vestibulum, tempus mi ac, facilisis lectus.");
            strs.Add("Praesent id magna sed massa hendrerit pellentesque ut quis enim.");
            strs.Add("Duis eu augue sed lectus pellentesque rutrum non eu augue.");
            strs.Add("Pellentesque non risus sed odio dapibus gravida quis non dolor.");
            strs.Add("Vivamus porta neque non neque malesuada scelerisque.");
            strs.Add("Integer eu neque at lectus imperdiet tincidunt.");
            strs.Add("Nunc vel quam laoreet, congue erat a, suscipit neque.");
            strs.Add("Donec dignissim massa nec urna porttitor facilisis.");
            strs.Add("Nunc iaculis metus a tristique adipiscing.");
            strs.Add("Morbi bibendum nulla non lectus posuere convallis.");
            strs.Add("Vivamus scelerisque felis sed nisl feugiat, mattis consequat lacus pulvinar.");
            strs.Add("Praesent non tortor dictum, interdum ligula vel, dapibus tortor.");
            strs.Add("Phasellus et dui vitae mi laoreet malesuada.");
            strs.Add("Morbi sit amet libero vitae augue porttitor tempus.");
            HashSet<string> sentences = strs;
            string str = string.Join(" ", CollectionData.GetElement<string>(count, sentences));
            return str;
        }

        public static string GetSubString(int length, string characters)
        {
            StringBuilder returnString = new StringBuilder();
            int charLength = characters.Length;
            while (length > 0)
            {
                returnString.Append(characters[NumberData.GetNumber(charLength)]);
                length--;
            }
            return returnString.ToString();
        }
    }
}