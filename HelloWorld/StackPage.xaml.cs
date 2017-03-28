using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class StackPage : ContentPage
	{
		public StackPage()
		{
			InitializeComponent();

			//Grid in code if we don't want to code in XAML the layout//

			/*
			var layout = new StackLayout
			{
				Spacing = 40,
				Padding = new Thickness(0, 20, 0, 0),
				Orientation = StackOrientation.Horizontal
			};

			layout.Children.Add(new Label { Text = "Label1" });

			Content = layout;
			*/

		}
	}
}
