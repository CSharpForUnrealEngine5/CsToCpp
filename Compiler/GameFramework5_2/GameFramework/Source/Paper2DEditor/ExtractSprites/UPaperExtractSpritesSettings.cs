namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtractSprites/PaperExtractSpritesSettings.h")]
public partial class UPaperExtractSpritesSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sprite extract mode</summary>
	public ESpriteExtractMode SpriteExtractMode;
	///<summary>The color of the sprite boundary outlines</summary>
	public FLinearColor OutlineColor;
	///<summary>Apply a tint to the texture in the viewport to improve outline visibility in this editor</summary>
	public FLinearColor ViewportTextureTint;
	///<summary>The viewport background color</summary>
	public FLinearColor BackgroundColor;
	///<summary>The name of the sprite that will be created. {0} will get replaced by the sprite number.</summary>
	public string NamingTemplate;
	///<summary>The number to start naming with</summary>
	public int NamingStartIndex;
}
