#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that handles rendering and collision for a single instance of a UPaperSprite asset.</summary>
[CppInclude("PaperSpriteComponent.h")]
public partial class UPaperSpriteComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The sprite asset used by this component</summary>
	public UPaperSprite SourceSprite;
	///<summary>DEPRECATED in 4.4: The material override for this sprite component (if any); replaced by the Materials array inherited from UMeshComponent</summary>
	public UMaterialInterface MaterialOverride_DEPRECATED;
	///<summary>The color of the sprite (passed to the sprite material as a vertex color)</summary>
	public FLinearColor SpriteColor;
	///<summary>Change the PaperSprite used by this instance.</summary>
	public  bool SetSprite(UPaperSprite NewSprite) { return default; }
	///<summary>Gets the PaperSprite used by this instance.</summary>
	public  UPaperSprite GetSprite() { return default; }
	///<summary>Set color of the sprite</summary>
	public  void SetSpriteColor(FLinearColor NewColor) {}
}
