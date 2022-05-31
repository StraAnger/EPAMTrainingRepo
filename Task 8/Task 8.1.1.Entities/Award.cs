using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Entities
{
    // сущность «Награда» (Award: Id, Title) и реализуйте соответствующие механизмы для добавления и запроса перечня наград.
    public class Award
    {
        public Guid AwardID { get; set; }

       public string Title { get; private set; }

        public Award(Guid Id, string title)
        {
            AwardID = Id;
            Title= title;
        }

        public Award(string title)
        {
            AwardID = Guid.NewGuid();
            Title = title;
        }

        public Award()
        {


        }


        public void Edit(string newTitle)
        {
            Title = newTitle;
        }

    }
}
