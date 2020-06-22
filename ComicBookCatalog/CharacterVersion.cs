using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCatalog
{
   public  class CharacterVersion
    {
        public virtual int Id { get; set; }
        public virtual int Version { get; set; }
        public Character Character { get; set; }
        public Person AlterEgo { get; set; }
    }
}
