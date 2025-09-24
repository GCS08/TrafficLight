using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight.Models
{
    // This abstract class knows what string shout be displayed in the Auto Change Light button, based on the bool
    internal abstract class SwitchChangeLightTextModel
    {
        public abstract string GetSwitchChangeLightText(bool isAutoChange);
    }
}
