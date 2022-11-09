using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debase
{
    public enum Categorieenum 
    {
        Horror, 
        Fantasie, 
        Actie, 
        Romance, 
        Humor, 
        Superhero, 
        Documantaire, 
        Dramas, 
        Scifi, 
        Animation,
    }
    public enum Ratedenum
    {
        GGeneralAudiences,
        PG,
        PG13,
        R,
    }
    public enum Cijferenum
    {
        Disappointed,
        Bad,
        Alright,
        Good,
        Verygood,
        Amazing,
        Perfect, 
    }

    public class defilms
    {

        /*   alle collomen in mijn database   */

        public int id { get; set; }

        public Ratedenum rated { get; set; }
        
        public Categorieenum categorie { get; set; }

        public Cijferenum cijfer { get; set; }

        public string naam { get; set; }

        public string uitkomst { get; set; }

        public string place { get; set; }

        public string krtomschrijving { get; set; }

        public string lengte { get; set;  }

        public string image_url { get; set; }
    }
}
