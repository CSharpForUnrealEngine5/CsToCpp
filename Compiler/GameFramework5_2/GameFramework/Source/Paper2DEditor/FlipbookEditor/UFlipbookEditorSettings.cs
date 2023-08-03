#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Paper2D sprite editor</summary>
[CppInclude("FlipbookEditor/FlipbookEditorSettings.h")]
public partial class UFlipbookEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Background color in the flipbook editor</summary>
	public FColor BackgroundColor;
	///<summary>Should the grid be shown by default when the editor is opened?</summary>
	public bool bShowGridByDefault;
}
