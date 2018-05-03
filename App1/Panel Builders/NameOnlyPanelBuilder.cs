﻿using Hashboard;
using System.Collections.Generic;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HashBoard
{
    public class NameOnlyPanelBuilder : PanelBuilderBase
    {
        public new int? FontSize { get; set; } 

        protected override Panel CreateSinglePanel(Entity entity, int width, int height)
        {
            Grid grid = new Grid();
            grid.Width = width;
            grid.Height = height;
            grid.Padding = new Thickness(PanelMargins);

            TextBlock textBlock = new TextBlock();
            textBlock.Foreground = FontColorBrush;
            textBlock.FontWeight = FontWeights.Bold;
            textBlock.FontSize = FontSize.HasValue ? FontSize.Value : base.FontSize;
            textBlock.Text = entity.Attributes["friendly_name"] ?? string.Empty;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Center;

            if (entity.Attributes.ContainsKey("local_assets_picture"))
            {
                grid.Background = Imaging.LoadAppXImageBrush(entity.Attributes["local_assets_picture"]);
            }
            else
            {
                grid.Background = ThemeControl.AccentColorBrush;
            }

            grid.Children.Add(textBlock);

            return grid;
        }

        protected override Panel CreateGroupPanel(Entity entity, IEnumerable<Entity> childrenEntities, int width, int height)
        {
            return null;
        }
    }
}
