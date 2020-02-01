using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
  public  class Anime
    {
        public string title = null;
        public string author  = null;
        public string year = null;
        public string episodes = null;
        public string rating = null;
        public string genres = null;

        public Anime() { }
        public Anime(string[] data)
        {
            title = data[0];
            author = data[1];
            year = data[2];
            episodes = data[3];
            rating = data[4];
            genres = data[5];
        }

        public bool Compare(Anime anime)
        {
            if (this.author == anime.author &&
                this.title == anime.title &&
                this.year == anime.year &&
                this.episodes == anime.episodes &&
                this.rating == anime.rating &&
                this.genres == anime.genres)
                return true;
            else return false;
        }

    }
}
