using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Library
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        private ResistorCalculations _resistorCalculations = new ResistorCalculations();

        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            if (!AreColorsValid(bandAColor,bandBColor, bandDColor, bandDColor))
                return 0;



            throw new NotImplementedException();
            
        }

        public int GetToleranceValue(string bandDColor)
        {
            throw new NotImplementedException();
        }

        private bool AreColorsValid(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            

            if (_resistorCalculations.GetResistorColors().Where(x => x.Contains(bandAColor)) == null)
                 return false;

            if (_resistorCalculations.GetResistorColors().Where(x => x.Contains(bandBColor)) == null)
                return false;

            if (_resistorCalculations.GetResistorColors().Where(x => x.Contains(bandCColor)) == null)
                return false;

            if (_resistorCalculations.GetResistorColors().Where(x => x.Contains(bandDColor)) == null)
                return false;

            return true;

        }

    }
}
