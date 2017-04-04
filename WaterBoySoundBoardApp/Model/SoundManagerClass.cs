using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBoySoundBoardApp.Model
{
    public class SoundManagerClass
    {
        //get all sounds in the local storage folders 
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            //call method get all sounds 
            var allSounds = getSounds();
            sounds.Clear(); //clear any existing sounds 
            allSounds.ForEach(p => sounds.Add(p));//lambda expression to get all sounds added  
        }

        //get all sounds by category
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCateory MySoundCategory)
        {
            //call method get all sounds 
            var allSounds = getSounds(); 
            // filter all sounds and assign all sounds to there subcategory via lambda expression
            var SoundByCategory = allSounds.Where(P => P.SoundCategory == MySoundCategory).ToList();  
            sounds.Clear();
            SoundByCategory.ForEach(p => sounds.Add(p));

        }

        //Arraylist of Type Sound method called getSounds 
        private static List<Sound> getSounds()
        {
            //declare a new list add the available sounds to it as seen below return the list back when called 
            var sounds = new List<Sound>();
            
            //Add Sounds to List 
            sounds.Add(new Sound("devil", SoundCateory.WaterBoy1));
            sounds.Add(new Sound("colonelsanders", SoundCateory.WaterBoy1));
            sounds.Add(new Sound("dontsmokecrack", SoundCateory.WaterBoy1));
            sounds.Add(new Sound("gatorade", SoundCateory.WaterBoy1));

            sounds.Add(new Sound("choochootrain", SoundCateory.WaterBoy2));
            sounds.Add(new Sound("herboobies", SoundCateory.WaterBoy2));
            sounds.Add(new Sound("holdthescotch", SoundCateory.WaterBoy2));
            sounds.Add(new Sound("imavirgo", SoundCateory.WaterBoy2));

            sounds.Add(new Sound("imthewaterboy", SoundCateory.WaterBoy3));
            sounds.Add(new Sound("joemontana", SoundCateory.WaterBoy3));
            sounds.Add(new Sound("mamasaid", SoundCateory.WaterBoy3));
            sounds.Add(new Sound("maybethedevil", SoundCateory.WaterBoy3));

            sounds.Add(new Sound("pleasedonthurtme", SoundCateory.WaterBoy4));
            sounds.Add(new Sound("runsprints", SoundCateory.WaterBoy4));
            sounds.Add(new Sound("wakeherassup", SoundCateory.WaterBoy4));
            sounds.Add(new Sound("yourefired", SoundCateory.WaterBoy4));

            sounds.Add(new Sound("abigdeal", SoundCateory.RonBurgendy1));
            sounds.Add(new Sound("attractbears", SoundCateory.RonBurgendy1));
            sounds.Add(new Sound("beardofzeus", SoundCateory.RonBurgendy1));
            sounds.Add(new Sound("glasscase", SoundCateory.RonBurgendy1));

            sounds.Add(new Sound("howgoodilook", SoundCateory.RonBurgendy2));
            sounds.Add(new Sound("ilovescotch", SoundCateory.RonBurgendy2));
            sounds.Add(new Sound("lookatme", SoundCateory.RonBurgendy2));
            sounds.Add(new Sound("piratehooker", SoundCateory.RonBurgendy2));

            sounds.Add(new Sound("stayclassy", SoundCateory.RonBurgendy3));
            sounds.Add(new Sound("stoppingby", SoundCateory.RonBurgendy3));
            sounds.Add(new Sound("veryimportant", SoundCateory.RonBurgendy3));
            sounds.Add(new Sound("wantedfor", SoundCateory.RonBurgendy3));

            sounds.Add(new Sound("wastheballs", SoundCateory.RonBurgendy4));
            sounds.Add(new Sound("whatcologne", SoundCateory.RonBurgendy4));
            sounds.Add(new Sound("whoreisland", SoundCateory.RonBurgendy4));
            sounds.Add(new Sound("yourattention", SoundCateory.RonBurgendy4));
            sounds.Add(new Sound("yourdoctor", SoundCateory.RonBurgendy4));




            return sounds;

        }
    }
}
