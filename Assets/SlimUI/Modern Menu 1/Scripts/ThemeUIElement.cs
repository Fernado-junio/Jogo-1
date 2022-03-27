using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SlimUI.ModernMenu{
	[System.Serializable]
	public class ThemeUIElement : ThemeUI {
		[Header("Parameters")]
		Color outline;
		Image image;
		SpriteRenderer sprite;
		GameObject message;
		public enum OutlineStyle {solidThin, solidThick, dottedThin, dottedThick};
		public bool hasImage = false;
		public bool hasSprite = false;
		public bool isText = false;

		protected override void OnSkinUI(){
			base.OnSkinUI();

			if(hasImage){
				image = GetComponent<Image>();
				image.color = themeController.currentColor;
				
				
			}
			if (hasSprite)
			{
				sprite = GetComponent<SpriteRenderer>();
				sprite.color = themeController.currentColor;
			}

			message = gameObject;

			if(isText){
				message.GetComponent<TextMeshPro>().color = themeController.textColor;
			}
		}
	}
}