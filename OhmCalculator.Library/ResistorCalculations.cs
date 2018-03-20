using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmCalculator.Library
{
    public class ResistorCalculations
    {   

        public IEnumerable<string> GetResistorColors()
        {
            return new List<string> { "none" ,"pink", "silver", "gold", "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        }

        public ResistorBand GetbandValues(string bandColor)
        {

            ResistorBand band = new ResistorBand();

            switch(bandColor.ToLower())
            {
                case "none":
                    band.RingColorName = "None";
                    band.TolerancePercent = 20;
                    band.ToleranceLetter = 'M';
                    break;
                case "pink":
                    band.RingColorName = "Pink";
                    band.RingColorCode = "PK";
                    band.RingColorRAL = 3015 ;
                    band.Multiplier = .001;
                    break;
                case "silver":
                    band.RingColorName = "Silver";
                    band.RingColorCode = "SR";
                    band.Multiplier = .01;
                    band.TolerancePercent = 10;
                    band.ToleranceLetter = 'K';
                    break;
                case "gold":
                    band.RingColorName = "Gold";
                    band.RingColorCode = "GD";                    
                    band.Multiplier = .1;
                    band.TolerancePercent = 5;
                    band.ToleranceLetter = 'J';
                    break;
                case "black":
                    band.RingColorName = "Black";
                    band.RingColorCode = "BK";
                    band.RingColorRAL = 9005;
                    band.SignificantFigure = 0;
                    band.Multiplier = 1;
                    band.TemperaturePPMK = 250;
                    band.TemperatureLetter = 'U';
                    break;
                case "brown":
                    band.RingColorName = "Brown";
                    band.RingColorCode = "BN";
                    band.RingColorRAL = 8003;
                    band.SignificantFigure = 1;
                    band.Multiplier = 10;
                    band.TolerancePercent = 1;
                    band.ToleranceLetter = 'F';
                    band.TemperaturePPMK = 100;
                    band.TemperatureLetter = 'S';
                    break;
                case "red":
                    band.RingColorName = "Red";
                    band.RingColorCode = "RD";
                    band.RingColorRAL = 3000;
                    band.SignificantFigure = 2;
                    band.Multiplier = 100;
                    band.TolerancePercent = 2;
                    band.ToleranceLetter = 'G';
                    band.TemperaturePPMK = 50;
                    band.TemperatureLetter = 'R';
                    break;
                case "orange":
                    band.RingColorName = "Orange";
                    band.RingColorCode = "OG";
                    band.RingColorRAL = 2003;
                    band.SignificantFigure = 3;
                    band.Multiplier = 1000;
                    band.TemperaturePPMK = 15;
                    band.TemperatureLetter = 'P';
                    break;
                case "yellow":
                    band.RingColorName = "Yellow";
                    band.RingColorCode = "YE";
                    band.RingColorRAL = 1021;
                    band.SignificantFigure = 4;
                    band.Multiplier = 10000;
                    band.TolerancePercent = 5;
                    band.TemperaturePPMK = 25;
                    band.TemperatureLetter = 'Q';
                    break;
                case "green":
                    band.RingColorName = "Green";
                    band.RingColorCode = "GN";
                    band.RingColorRAL = 6018;
                    band.SignificantFigure = 5;
                    band.Multiplier = 100000;
                    band.TolerancePercent = .5;
                    band.ToleranceLetter = 'D';
                    band.TemperaturePPMK = 20;
                    band.TemperatureLetter = 'Z';
                    break;
                case "blue":
                    band.RingColorName = "Blue";
                    band.RingColorCode = "BU";
                    band.RingColorRAL = 5015;
                    band.SignificantFigure = 6;
                    band.Multiplier = 1000000;
                    band.TolerancePercent = .25;
                    band.ToleranceLetter = 'C';
                    band.TemperaturePPMK = 10;
                    band.TemperatureLetter = 'Z';
                    break;
                case "violet":
                    band.RingColorName = "Violet";
                    band.RingColorCode = "VT";
                    band.RingColorRAL = 4005;
                    band.SignificantFigure = 7;
                    band.Multiplier = 10000000;
                    band.TolerancePercent = .1;
                    band.ToleranceLetter = 'B';
                    band.TemperaturePPMK = 5;
                    band.TemperatureLetter = 'M';
                    break;
                case "grey":
                    band.RingColorName = "Grey";
                    band.RingColorCode = "GY";
                    band.RingColorRAL = 7000;
                    band.SignificantFigure = 8;
                    band.Multiplier = 100000000;
                    band.TolerancePercent = .05;
                    band.ToleranceLetter = 'A';
                    band.TemperaturePPMK = 1;
                    band.TemperatureLetter = 'K';
                    break;
                case "white":
                    band.RingColorName = "White";
                    band.RingColorCode = "WH";
                    band.RingColorRAL = 7000;
                    band.SignificantFigure = 9;
                    band.Multiplier = 100000000;      
                    break;
                default:
                    band = null;
                    break;
            }
            return band;
        }

    }
}
