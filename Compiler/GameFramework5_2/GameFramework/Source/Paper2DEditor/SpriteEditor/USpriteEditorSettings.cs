#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Paper2D sprite editor</summary>
[CppInclude("SpriteEditor/SpriteEditorSettings.h")]
public partial class USpriteEditorSettings : UObject {
	///<summary>Background color in the sprite editor</summary>
	public FColor BackgroundColor;
	///<summary>Should the grid be shown by default when the editor is opened?</summary>
	public bool bShowGridByDefault;
}
