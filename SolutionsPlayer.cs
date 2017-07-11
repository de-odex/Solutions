using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace SolutionsMod
{
    public class SolutionsPlayer: ModPlayer
    {
        public bool solTimesTwo = false;
        public bool solTimesFour = false;
        public bool solTimesOneThird = false;
        public bool solTimesOneFifth = false;

        public bool solRadiusHalf = false;
        public bool solRadiusDouble = false;

        public bool lightless = false;

        public override void ResetEffects()
        {
            solTimesTwo = false;
            solTimesFour = false;
            solTimesOneThird = false;
            solTimesOneFifth = false;

            solRadiusHalf = false;
            solRadiusDouble = false;


            lightless = false;
        }



    }
}
