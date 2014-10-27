using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using rotation_test.Resources;

using System.Windows.Media;
using System.Windows.Media.Animation;

namespace rotation_test
{
    public partial class MainPage : PhoneApplicationPage
    {
        RotateTransform transform = new RotateTransform();
        RotateTransform transform2 = new RotateTransform();


        // Constructor
        public MainPage()
        {
            InitializeComponent();

            transform.Angle = 360;
            transform2.Angle = 360;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Arrow.RenderTransformOrigin = new Point(0.5, 0.5);
            transform.Angle -= 30;
            Arrow.RenderTransform = transform;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Face.RenderTransformOrigin = new Point(0.5, 0.5);
            transform2.Angle += 30;
            Face.RenderTransform = transform2;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}