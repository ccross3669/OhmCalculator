﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Library
{
    public interface IOhmValueCalculator
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        /// <summary>
        /// Calculates the Tolerance of a resistor based on fourth color.
        /// </summary>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        int GetToleranceValue(string bandDColor);
    }
}
