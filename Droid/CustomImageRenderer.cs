using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// CustomImageViewのレンダラーをCustomImageViewRendererに変更する宣言
[assembly:ExportRenderer(typeof(CustomImage.CustomImage), typeof(CustomImage.Droid.CustomImageRenderer))]

namespace CustomImage.Droid
{
	/// <summary>
	/// Imageに対応した、ImageRendererを継承したクラスをカスタムレンダラークラスとして作成
	/// </summary>
	public class CustomImageRenderer : Xamarin.Forms.Platform.Android.ImageRenderer
	{
		/// <summary>
		/// 初期設定されたときに呼ばれる
		/// </summary>
		/// <param name="e">E.</param>
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged(e);

			// 画像の色を設定
			SetImageColor();
		}

		/// <summary>
		/// 画像のカラーを設定
		/// </summary>
		void SetImageColor()
		{
			// ElementをキャストしてFormsで定義したカスタム用のImageを取得
			var formsImage = (CustomImage)Element;

			// 設定の変更があった場合
			// Controlでこのカスタムレンダラーで使用する、AndroidのImageViewが取得できる
			if (Control != null && formsImage.ImageColor != Color.Transparent)
			{
				// 画像のカラーをプロパティに設定したものに変更
				Control.SetColorFilter(formsImage.ImageColor.ToAndroid());
			}
		}
	}
}


