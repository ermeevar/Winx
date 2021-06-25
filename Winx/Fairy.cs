using System;
using System.Collections.Generic;
using System.Text;

namespace Winx
{
    class Fairy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Power { get; set; }
        public int CountOfLife { get; set; } = 5;

        private Fairy[] fairies;

        public Fairy this[int index]
        {
            get
            {
                return fairies[index];
            }
            set
            {
                fairies[index] = value;
            }
        }

        public static Fairy operator +(Fairy first, Fairy second)
        {
            Fairy fairy = new Fairy();
            fairy.Name = first.Name + " and " + second.Name;
            fairy.CountOfLife = first.CountOfLife + second.CountOfLife;
            fairy.Power = first.Power + second.Power;
            fairy.Id = 100;
            return fairy;
        }

        public static bool operator >(Fairy first, Fairy second)
        {
            return first.Power > second.Power;
        }

        public static bool operator <(Fairy first, Fairy second)
        {
            return first.Power < second.Power;
        }
    }
}
