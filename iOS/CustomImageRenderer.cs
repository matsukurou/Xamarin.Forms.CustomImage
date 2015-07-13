using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;

// CustomImageのレンダラーをCustomImageRendererに変更する宣言
[assembly:ExportRenderer(typeof(CustomImage.CustomImage), typeof(CustomImage.iOS.CustomImageRenderer))]
namespace CustomImage.iOS
{
	/// <summary>
	/// Imageに対応した、ImageRendererを継承したクラスをカスタムレンダラークラスとして作成
	/// </summary>
	public class CustomImageRenderer : Xamarin.Forms.Platform.iOS.ImageRenderer
	{
		/// <summary>
		/// 初期設定されたときに呼ばれる
		/// </summary>
		/// <param name="e">E.</param>
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged(e);
		}

		/// <summary>
		/// プロパティの変更があった場合に呼び出される
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			// ElementをキャストしてFormsで定義したカスタム用のImageを取得
			var formsImage = (CustomImage)Element;

			// 透明色が設定されていた場合は以降の処理をしない
			// カラー設定されていないものの、意図しない塗りつぶしを防ぐため
			if (formsImage.ImageColor == Color.Transparent)
				return;

			// iOS用のイメージを取得
			var image = Control.Image;
			if (image != null && image.RenderingMode != UIImageRenderingMode.AlwaysTemplate)
			{
				// 色変更できるモードでUIImageを生成する
				// こうしないと色変更できない
				// 変更するのはAlpha値のみを見ている,0以外は塗りつぶし
				var img = image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
				// UIImageViewに生成したUIImageを設定する
				Control.Image = img;

				// 画像のカラーをプロパティに設定したものに変更
				Control.TintColor = formsImage.ImageColor.ToUIColor();
			}
		}
	}
}


