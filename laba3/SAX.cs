using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace laba3
{
    public class SAX : Istrategy
    {
        List<Anime> res = new List<Anime>();
        XmlReader read;

        public SAX(string path)
        {
            read = new XmlTextReader(path);
        }
        public List<Anime> Filtr(List<Anime> info, Anime a)
        {
            List<Anime> res1 = new List<Anime>();
            if (info != null)
            {
                foreach (Anime a1 in info)
                {
                    if ((a1.title == a.title || a.title == null) &&
                        (a1.author == a.author || a.author == null) &&
                        (a1.year == a.year || a.year == null) &&
                        (a1.episodes == a.year || a.episodes == null) &&
                        (a1.rating == a.rating || a.rating == null) &&
                        (a.genres == null || a1.genres.Contains(a.genres)))
                        res1.Add(a1);
                    
                }
                
            }
            return res1;
        }
        public List<Anime> Search(Anime a, string path)
        {
            List<Anime> info = new List<Anime>();
            Anime anime = null;
            info.Clear();
            while(read.Read())
            {
                

                if (read.NodeType != XmlNodeType.EndElement && read.Name == "Anime")
                {
                    anime = new Anime();
                }
                if (read.Name=="Title")
                {
                    anime.title = read.ReadElementContentAsString();                  
                }
                   
                    

                if (read.Name == "Author")
                    anime.author = read.ReadElementContentAsString();

                if (read.Name == "Year")
                    anime.year = read.ReadElementContentAsString();

                if (read.Name == "Episodes")
                    anime.episodes = read.ReadElementContentAsString();

                if (read.Name == "Rating")
                    anime.rating = read.ReadElementContentAsString();

                if (read.Name == "Genres")
                    anime.genres = read.ReadElementContentAsString();
                if (read.NodeType== XmlNodeType.EndElement&& read.Name=="Anime")
                {
                    info.Add(anime);
                   
                }
                    
            }
            

            res = Filtr(info, a);
            return res;
        }
    }
}
