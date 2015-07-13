using System;

using Xamarin.Forms;

namespace CustomImage
{
	/// <summary>
	/// Imageを継承したImageカスタム用のビュー
	/// </summary>
	public class CustomImage : Image
	{
		/// <summary>
		/// 画像に設定するカラーのプロパティ
		/// </summary>
		public Color ImageColor { get; set; }

		public CustomImage()
		{
			ImageColor = Color.Transparent;
		}
	}
}


