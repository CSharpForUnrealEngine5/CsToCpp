#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rule for a single section of a terrain material</summary>
[CppInclude("PaperTerrainMaterial.h")]
public partial struct FPaperTerrainMaterialRule {
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
