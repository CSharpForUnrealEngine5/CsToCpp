namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Paper2D sprite editor</summary>
[CppInclude("SpriteEditor/SpriteEditorSettings.h")]
public partial class USpriteEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Background color in the sprite editor</summary>
	public FColor BackgroundColor;
	///<summary>Should the grid be shown by default when the editor is opened?</summary>
	public bool bShowGridByDefault;
}
