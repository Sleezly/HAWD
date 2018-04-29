﻿using Hashboard;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HashBoard
{
    public static class Imaging
    {
        public static Image LoadImage(string asset)
        {
            const string UriAssetFormat = "ms-appx:///assets/";

            Uri imageUri = new Uri($"{UriAssetFormat}{asset}");

            BitmapImage bitmapImage = new BitmapImage(imageUri);
            
            Image image = new Image();
            image.Source = bitmapImage;
            
            return image;
        }

        public static ImageBrush LoadAppXImageBrush(string asset)
        {
            const string UriAssetFormat = "ms-appx:///assets/";

            Uri imageUri = new Uri($"{UriAssetFormat}{asset}");

            BitmapImage bitmapImage = new BitmapImage(imageUri);

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;

            return imageBrush;
        }

        public static ImageBrush LoadImageBrush2(string asset)
        {
            Uri imageUri = new Uri($"http://{SettingsControl.HomeAssistantHostname}:{SettingsControl.HomeAssistantPort}{asset}");

            BitmapImage bitmapImage = new BitmapImage(imageUri);

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;

            return imageBrush;
        }


        public static ImageBrush LoadAppDataImageBrush(string asset)
        {
            const string UriAssetFormat = "ms-appdata:///local/";

            Uri imageUri = new Uri($"{UriAssetFormat}{asset}");

            BitmapImage bitmapImage = new BitmapImage(imageUri);

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;

            return imageBrush;
        }

        public static ImageSource LoadImageSource(string asset)
        {
            Uri imageUri = new Uri($"http://{SettingsControl.HomeAssistantHostname}:{SettingsControl.HomeAssistantPort}{asset}");

            return new BitmapImage(imageUri);
        }
    }
}
