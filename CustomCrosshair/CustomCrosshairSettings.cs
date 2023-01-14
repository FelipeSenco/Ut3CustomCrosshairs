using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ut3CustomCrosshairs.CustomCrosshair
{
    public class CustomCrosshairSettings
    {
        public string? CustomCrosshairCoordinates { get; set; }
        public string? CrosshairColor { get; set; }
        public Color? Color { get; set; }
        public bool UseGeneralCoordinates { get; set; }
        public bool UseGeneralColor{ get; set; }
        public string WeaponSection { get; set; }  
        public bool UseSuggestions { get; set; }    
        public Image? SuggestionImage { get; set; } 
    }
}




