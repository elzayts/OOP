using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace laba3
{
    public class LINQ : Istrategy
    {
        List<Anime> res = new List<Anime>();
        XDocument doc = new XDocument();
        public LINQ(string path)
        {
            doc = XDocument.Load(@path);
        }
        public List<Anime> Search(Anime a, string path)
        {
            var find = (from val in doc.Descendants("Anime")
                        where
                        ((a.author == null || a.author == val.Element("Author").Value) &&
                        (a.title == null || a.title == val.Element("Title").Value) &&
                        (a.year == null || a.year == val.Element("Year").Value) &&
                        (a.episodes == null || a.episodes == val.Element("Episodes").Value) &&
                        (a.rating == null || a.rating == val.Element("Rating").Value) &&
                        (a.genres == null || val.Element("Genres").Value.Contains(a.genres)))
                        select val).ToList();
            foreach(var k in find)
            {
                Anime anime = new Anime();
                anime.author = k.Element("Author").Value;
                anime.title = k.Element("Title").Value;
                anime.year = k.Element("Year").Value;
                anime.episodes = k.Element("Episodes").Value;
                anime.rating = k.Element("Rating").Value;
                anime.genres = k.Element("Genres").Value;
                res.Add(anime);
            }
            return res;
        }
    }
}
