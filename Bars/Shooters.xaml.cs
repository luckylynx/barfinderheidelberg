﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Device.Location;
using Microsoft.Phone.Controls.Maps;

namespace DatenErkundungen
{
    public partial class Shooters : PhoneApplicationPage
    {
        public Shooters()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(Shooters_Loaded);
        }


        // wenn die Shooters geladen wird, wird folgendes getan:
        void Shooters_Loaded(object sender, RoutedEventArgs e)
        {


            Pushpin Shooters = new Pushpin();
            Shooters.Location = new GeoCoordinate(49.40921, 8.69196);
            myMap.Center = Shooters.Location;
            Shooters.Background = new SolidColorBrush(Colors.Black);
            Shooters.Content = "Shooter Stars";
            Shooters.FontSize = 18;
            myMap.ZoomLevel = 15;
            
            myMap.Children.Add(Shooters);
            
            //throw new NotImplementedException();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phone = new PhoneCallTask();
            phone.DisplayName = "Shooter Stars";
            phone.PhoneNumber = "+4962217255412";
            phone.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask browser = new WebBrowserTask();
            browser.URL = "http://www.shooterstars.de/ ";
            browser.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask email = new EmailComposeTask();
            email.Subject = "Anfrage";
            email.To = "heidelberg@shooterstars.de";
            email.Body = "";
            email.Show();
        }
    }
}