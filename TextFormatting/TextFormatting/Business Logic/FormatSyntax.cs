using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatting.DesktopClient.ViewModels
{
    class FormatSyntax
    {
        static List<string> tags = new List<string>();


       static FormatSyntax()
        {
            string[] strs = {
               "@a","@b","@c","@d","@e","@f","@g","@h","@i","@j","@k","@l","@m","@n","@o","@p","@q","@r","@s","@t","@u","@v","@w","@x","@y","@z",
               "#a","#b","#c","#d","#e","#f","#g","#h","#i","#j","#k","#l","#m","#n","#o","#p","#q","#r","#s","#t","#u","#v","#w","#x","#y","#z"

            };
            tags = new List<string>(strs);
        }

        public static List<string> GetTags
        {
            get { return tags; }
        }
        public static bool IsKnownTag(string tag)
        {
            return tags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
        public static List<string> GetFormatSyntax(string tag)
        {
            return tags.FindAll(delegate (string s) { return s.ToLower().StartsWith(tag.ToLower()); });
        }
        public static bool IsHashSymbol(string tag)
        {
            if (tag.Length > 2 && tag.Contains("#")) {
                tag = tag.Substring(tag.Length - 2);
                    }
            return tags.Exists(delegate (string s) { return s.ToLower().Equals(tag.ToLower()); });
        }
    }
}
