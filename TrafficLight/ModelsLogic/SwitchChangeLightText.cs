using TrafficLight.Models;

namespace TrafficLight.ModelsLogic
{
    //The ModelLogic of the change light text. Makes sure that when the button is clicked once then it'll show "Stop", and if it doesn't, "Start".
    internal class SwitchChangeLightText : SwitchChangeLightTextModel
    {
        public override string GetSwitchChangeLightText(bool isAutoChange)
        {
            if (isAutoChange) { return Strings.constantStopChangeLightText; }//If we are currently on the cuto change, return the "Stop"
            else {  return Strings.constantStartChangeLightText; }//otherwise, return the "Start"
        }
    }
}
