using System;

using Xamarin.Forms;

// CustomBoxViewのレンダラーをCustomBoxRendererに変更する宣言
[assembly:ExportRenderer(typeof(CustomImage.CustomImage), typeof(CustomImage.iOS.CustomImageRenderer))]
namespace CustomImage.iOS
{
	/// <summary>
	/// Imageに対応した、ImageRendererを継承したクラスをカスタムレンダラークラスとして作成
	/// </summary>
	public class CustomImageRenderer : Xamarin.Forms.Platform.iOS.ImageRenderer
	{
		public CustomImageRenderer()
		{
		}
	}
}


