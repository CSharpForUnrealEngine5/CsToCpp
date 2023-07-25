#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperSpriteComponent.h")]
///<summary>A component that handles rendering and collision for a single instance of a UPaperSprite asset.</summary>
public partial class UPaperSpriteComponent : UMeshComponent {
// PaperSpriteComponent
	public UPaperSprite SourceSprite;
	public UMaterialInterface MaterialOverride_DEPRECATED;
	public FLinearColor SpriteColor;
	public bool SetSprite(UObject NewSprite) { return default; }
	public UObject GetSprite() { return default; }
	public void SetSpriteColor(FLinearColor NewColor) {}
}
