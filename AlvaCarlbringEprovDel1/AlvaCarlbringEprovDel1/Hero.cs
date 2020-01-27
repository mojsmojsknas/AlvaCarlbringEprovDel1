using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaCarlbringEprovDel1
{
    //Detta kommer att vara basklassen alltså den som alla olika typer av karaktärer kommer att utgå ifrån

    class Hero
    {
        public string name = "";
        

        private int hp = 150;
        //Gör att man kan komma åt hp i program.cs utan att råka knasa till saker i själva klassen. Detta trots att det är en privat
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = Math.Max(value, 0);
            }
        }

        public int dmg = 20;

        public int Attack()
        {


            return dmg;
        }











    }
}