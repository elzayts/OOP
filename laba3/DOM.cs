using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace laba3
{
   public class DOM: Istrategy
    {
        List<Anime> res = new List<Anime>();
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);
        }
      public List<Anime> Search(Anime a, string path)
        {
            string[] str = new string[6];
            str[0] = null;
            str[1] = null;
            str[2] = null;
            str[3] = null;
            str[4] = null;
            str[5] = null;
            XmlNode node = doc.DocumentElement;

            foreach (XmlNode nod in node.SelectNodes("//Anime"))
            {

                foreach (XmlNode nodd in nod.ChildNodes)
                {
                    switch (nodd.Name)
                    {
                        case "Title":
                            if (nodd.InnerText == a.title || a.title == null)
                                str[0] = nodd.InnerText;
                            break;
                        case "Author":
                            if (nodd.InnerText == a.author || a.author == null)
                                str[1] = nodd.InnerText;
                            break;
                        case "Year":
                            if (nodd.InnerText == a.year || a.year == null)
                                str[2] = nodd.InnerText;
                            break;
                        case "Episodes":
                            if (nodd.InnerText == a.episodes || a.episodes == null)
                                str[3] = nodd.InnerText;
                            break;
                        case "Rating":
                            if (nodd.InnerText == a.rating || a.rating == null)
                                str[4] = nodd.InnerText;
                            break;
                        case "Genres":
                            if (a.genres == null || nodd.InnerText.Contains(a.genres))
                                str[5] = nodd.InnerText;
                            break;
                    }


                }


                Anime an = new Anime(str);
                str[0] = null;
                str[1] = null;
                str[2] = null;
                str[3] = null;
                str[4] = null;
                str[5] = null;
                res.Add(an);
            }

            return res;
        }
    }
}
