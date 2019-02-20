using System.Collections.Generic;
using System.Linq;

namespace MFramework.Services.FakeData
{
    public static class NetworkData
    {
        private static HashSet<string> _exts;

        static NetworkData()
        {
            HashSet<string> strs = new HashSet<string>();
            strs.Add(".co.uk");
            strs.Add(".com");
            strs.Add(".net");
            strs.Add(".org");
            strs.Add(".org.uk");
            strs.Add(".biz");
            strs.Add(".info");
            strs.Add(".co");
            strs.Add(".us");
            NetworkData._exts = strs;
        }

        public static string GetDomain()
        {
            string[] strArrays = new string[] { "google", "yahoo", "microsoft", "adamriddick", "bbc", "gmail", "stackoverflow", "msdn", "qq", "youtube", "baidu", "wikipedia", "linkedin", "taobao", "live", "amazon", "ebay", "bing", "wordpress", "studio1337", "pinterest", "sohu", "163", "ask", "paypal", "cnn", "sky", "bet365", "yelp", "globo", "flipkart", "expedia", "deviantart", "theguardian", "wikia", "etsy", "lego", "bestbuy", "maplin", "techcrunch", "arstechnica" };
            string domain = ArrayData.GetElement<string>(strArrays);
            string str = string.Concat(domain, CollectionData.GetElement<string>(NetworkData._exts));
            return str;
        }

        public static string GetDomain(string name)
        {
            string str = string.Concat(name, CollectionData.GetElement<string>(NetworkData._exts));
            return str;
        }

        public static string GetEmail()
        {
            string email = NetworkData.GetEmail(NameData.GetFirstName(), NameData.GetSurname());
            return email;
        }

        public static string GetEmail(string firstName, string lastName)
        {
            string str;
            if (!BooleanData.GetBoolean())
            {
                object[] objArray = new object[] { firstName[0], ".", lastName, "@", NetworkData.GetDomain() };
                str = string.Concat(objArray);
            }
            else
            {
                string[] strArrays = new string[] { firstName, ".", lastName, "@", NetworkData.GetDomain() };
                str = string.Concat(strArrays);
            }
            return str;
        }

        public static string GetEmail(string domain)
        {
            string[] firstName = new string[] { NameData.GetFirstName(), ".", NameData.GetSurname(), "@", domain };
            return string.Concat(firstName);
        }

        public static string GetIpAddress()
        {
            object[] number = new object[] { NumberData.GetNumber(256), ".", NumberData.GetNumber(256), ".", NumberData.GetNumber(256), ".", NumberData.GetNumber(256) };
            return string.Concat(number);
        }

        public static string GetMacAddress()
        {
            string result = string.Concat((
                from x in (IEnumerable<byte>)NumberData.GetBytes(new byte[6])
                select string.Format("{0}:", x.ToString("X2"))).ToArray<string>());
            return result.TrimEnd(new char[] { ':' });
        }
    }
}