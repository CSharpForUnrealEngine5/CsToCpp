namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paper Terrain Material</summary>
[CppInclude("PaperTerrainMaterial.h")]
public partial class UPaperTerrainMaterial : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Rules</summary>
	public TArray<FPaperTerrainMaterialRule> Rules;
	///<summary>The sprite to use for an interior region fill</summary>
	public UPaperSprite InteriorFill;
}
