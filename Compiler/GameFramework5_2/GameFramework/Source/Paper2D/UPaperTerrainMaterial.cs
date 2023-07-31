#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paper Terrain Material</summary>
[CppInclude("PaperTerrainMaterial.h")]
public partial class UPaperTerrainMaterial : UDataAsset {
	///<summary>Rules</summary>
	public TArray<FPaperTerrainMaterialRule> Rules;
	///<summary>The sprite to use for an interior region fill</summary>
	public UPaperSprite InteriorFill;
}
