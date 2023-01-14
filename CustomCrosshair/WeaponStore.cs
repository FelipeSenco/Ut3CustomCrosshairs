using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ut3CustomCrosshairs.CustomCrosshair
{
    public class WeaponStore
    {
        public List<CustomCrosshairSettings> FileWeaponSettings;
        public List<CustomCrosshairSettings> AppWeaponSettings;
              
        public WeaponStore()
        {
            FileWeaponSettings = new List<CustomCrosshairSettings>();
            AppWeaponSettings = new List<CustomCrosshairSettings>();
        }                  
               
    }
}
