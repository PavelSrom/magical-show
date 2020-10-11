using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace handin_3
{
    public class Magician : Person
    {
        ArrayList favoriteTricks;

        public Magician(string favTrick, string name, string password) : base(name, password)
        {
            this.favoriteTricks = new ArrayList();
            if (favTrick.Length > 0)
            {
                this.AddFavoriteTrick(favTrick);
            }
        }

        public void AddFavoriteTrick(string trickToAdd)
        {
            this.favoriteTricks.Add(trickToAdd);
        }
    }
}