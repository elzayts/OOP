using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public interface Istrategy
    {
       List<Anime> Search(Anime a, string path);
    }
}
