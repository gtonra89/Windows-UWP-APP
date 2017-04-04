using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WaterBoySoundBoardApp.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace WaterBoySoundBoardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection <Sound> Sounds;
        private List<MenuBoard> Menu;

        public MainPage()
        {
            /**
             * on init add to the side menu a list of  
             * all below clickable menu items with pictures and text
             * sorted by category  
             *  preload tge page with all sounds 
            */
            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            SoundManagerClass.GetAllSounds(Sounds);
            Menu = new List<MenuBoard>();
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/WaterBoy1/waterboy1.png", MyCategory = SoundCateory.WaterBoy1 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/WaterBoy2/waterboy2.png", MyCategory = SoundCateory.WaterBoy2 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/WaterBoy3/waterboy3.png", MyCategory = SoundCateory.WaterBoy3 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/WaterBoy4/waterboy4.png", MyCategory = SoundCateory.WaterBoy4 });

            Menu.Add(new MenuBoard { Icon = "Assets/Icons/RonBurgendy1/RonBurgendy1.png", MyCategory = SoundCateory.RonBurgendy1 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/RonBurgendy2/RonBurgendy2.png", MyCategory = SoundCateory.RonBurgendy2 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/RonBurgendy3/RonBurgendy3.png", MyCategory = SoundCateory.RonBurgendy3 });
            Menu.Add(new MenuBoard { Icon = "Assets/Icons/RonBurgendy4/RonBurgendy4.png", MyCategory = SoundCateory.RonBurgendy4 });

            BackButton.Visibility = Visibility.Collapsed;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        /**
         * if back button clicked when visiable
         * return all sounds menu back and 
         * set back button visibility to collapsed 
         */
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            SoundManagerClass.GetAllSounds(Sounds);
            CategoryTextBlock.Text = "All Sounds";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menu = (MenuBoard)e.ClickedItem;
            CategoryTextBlock.Text = menu.MyCategory.ToString();
            SoundManagerClass.GetSoundsByCategory(Sounds, menu.MyCategory);

            BackButton.Visibility = Visibility.Visible;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            var sound = (Sound)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.SoundAudio);

        }
    }
}
