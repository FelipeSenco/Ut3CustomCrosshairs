using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ut3CustomCrosshairs.CustomCrosshair
{
    static class CrosshairTypes
    {
        public static CustomCrosshairSettings A1 = new CustomCrosshairSettings() { CustomCrosshairCoordinates= "CustomCrosshairCoordinates=(U=0,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A2 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=64,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A3 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=128,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A4 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=192,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A5 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=256,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A6 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=322,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A7 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=386,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings A8 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=450,V=0,UL=64,VL=64)" };
        public static CustomCrosshairSettings B1 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=0,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B2 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=64,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B3 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=128,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B4 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=192,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B5 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=256,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B6 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=322,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B7 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=386,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings B8 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=450,V=64,UL=64,VL=64)" };
        public static CustomCrosshairSettings C1 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=0,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C2 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=64,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C3 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=128,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C4 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=192,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C5 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=256,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C6 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=322,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C7 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=386,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings C8 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=450,V=128,UL=64,VL=64)" };
        public static CustomCrosshairSettings D1 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=0,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D2 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=64,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D3 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=128,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D4 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=192,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D5 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=256,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D6 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=322,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D7 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=386,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings D8 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=450,V=192,UL=64,VL=64)" };
        public static CustomCrosshairSettings E1 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=0,V=256,UL=64,VL=64)" };
        public static CustomCrosshairSettings E2 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=62,V=256,UL=20,VL=20)" };
        public static CustomCrosshairSettings E3 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=83,V=255,UL=6,VL=6)" };
        public static CustomCrosshairSettings E4 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=68,V=294,UL=20,VL=20)" };
        public static CustomCrosshairSettings E5 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=298,V=256,UL=64,VL=64)" };
        public static CustomCrosshairSettings E6 = new CustomCrosshairSettings() { CustomCrosshairCoordinates = "CustomCrosshairCoordinates=(U=384,V=256,UL=64,VL=64)" };
      
    }
}
