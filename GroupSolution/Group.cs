using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSolution
{


    class ListItem
    {
        public string Id = null;
        public string Text = null;

        public ListItem(string id, string text)
        {
            this.Id = id;
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    class ListDown
    {
        public string Id = null;
        public string Text = null;
        public string Pers = null;

        public ListDown(string id, string text, string pers)
        {
            this.Id = id;
            this.Text = text;
            this.Pers = pers;
        }

        public override string ToString()
        {
            return this.Text;
            return this.Pers;
        }
    }
}
