using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Library
{
    public class ResistorBand
    {
        public string RingColorName {get; set;}
        public string RingColorCode { get; set; }
        public int?  RingColorRAL { get; set; }
        public int?  SignificantFigure { get; set; }
        public double Multiplier { get; set; }
        public double? TolerancePercent { get; set; }
        public char? ToleranceLetter { get; set; }
        public int? TemperaturePPMK { get; set; }
        public char? TemperatureLetter { get; set; }
        
        
    }




}
