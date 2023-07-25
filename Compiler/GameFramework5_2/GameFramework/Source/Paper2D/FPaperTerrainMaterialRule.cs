#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTerrainMaterial.h")]
///<summary>Rule for a single section of a terrain material</summary>
public partial struct FPaperTerrainMaterialRule {
// PaperTerrainMaterialRule
	public UPaperSprite StartCap;
	public TArray<UPaperSprite> Body;
	public UPaperSprite EndCap;
	public float MinimumAngle;
	public float MaximumAngle;
	public bool bEnableCollision;
	public float CollisionOffset;
	public int DrawOrder;
	public string Description;
}
