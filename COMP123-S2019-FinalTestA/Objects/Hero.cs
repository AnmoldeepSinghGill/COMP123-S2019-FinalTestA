using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: Anmoldeep Singh Gill
 * STUDENT ID: 301044883
 * DESCRIPTION: This is the Hero Data Container Class.
 */

namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        //Indentity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physical Abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        //Mental Abilities
        public string Reason { get; set; }
        public string Intution { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }

        // Power List
        List<Power> Powers;

        //Constructor
        Hero()
        {
            //intantiates an empty power List
            Powers = new List<Power>();
        }
    }
}
