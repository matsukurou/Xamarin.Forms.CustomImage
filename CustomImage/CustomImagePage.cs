using System;

using Xamarin.Forms;

namespace CustomImage
{
	public class CustomImagePage : ContentPage
	{
		public CustomImagePage()
		{
			// 背景色を設定
			BackgroundColor = Color.White;

			// CustomImageViewを生成
			var image = new CustomImage()
			{
				Source = FileImageSource.FromResource("CustomImage.github.png"),
			};

			// レイアウトを生成
			var stackLayout = new StackLayout
			{
				// 縦方向は中心に設定
				VerticalOptions = LayoutOptions.Center,
				// 生成したimageをレイアウトに追加
				Children =
				{
					image,
				}
			};

			// ページのレイアウトにコンテントを追加
			Content = stackLayout;
		}
	}
}


