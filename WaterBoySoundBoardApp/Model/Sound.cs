using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBoySoundBoardApp.Model
{
   public class Sound{
        //varibales with getters and setters 
        public string SoundName { get; set; }
        public SoundCateory SoundCategory { get; set; }
        public string SoundAudio { get; set; }
        public string SoundImage { get; set; }

        /*public arg construct which assigns the variables to the 
          audio files and image files as well as sound name and category  
          via the below enum 
        */    
    public Sound(String soundName, SoundCateory category)
    {
            SoundName = soundName;
            SoundCategory = category;
            SoundAudio = String.Format("/Assets/Audio/{0}/{1}.wav", category, soundName);
            SoundImage = String.Format("/Assets/Icons/{0}/{0}.png", category, soundName);
    }

    }

    public enum SoundCateory
    {
        //Declaring the Categorys available for searching via by category 
        WaterBoy1,
        WaterBoy2,
        WaterBoy3,
        WaterBoy4,
        RonBurgendy1,
        RonBurgendy2,
        RonBurgendy3,
        RonBurgendy4
    }

    
}
