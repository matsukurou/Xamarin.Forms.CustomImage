using System;

using Xamarin.Forms;

// CustomImageViewのレンダラーをCustomImageViewRendererに変更する宣言
[assembly:ExportRenderer(typeof(CustomImage.CustomImage), typeof(CustomImage.Droid.CustomImageRenderer))]

namespace CustomImage.Droid
{
	/// <summary>
	/// Imageに対応した、ImageRendererを継承したクラスをカスタムレンダラークラスとして作成
	/// </summary>
	public class CustomImageRenderer : Xamarin.Forms.Platform.Android.ImageRenderer
	{
		public CustomImageRenderer()
		{
		}
	}
}


