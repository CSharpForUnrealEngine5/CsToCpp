namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelVariantSets.h")]
public partial class ULevelVariantSets : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetNumVariantSets</summary>
	public int GetNumVariantSets() { return default; }
	///<summary>GetVariantSet</summary>
	public UVariantSet GetVariantSet(int VariantSetIndex) { return default; }
	///<summary>GetVariantSetByName</summary>
	public UVariantSet GetVariantSetByName(string VariantSetName) { return default; }
	///<summary>A pointer to the director blueprint that generates this levelvariantsets&#39; DirectorClass</summary>
	public UObject DirectorBlueprint;
	///<summary>The class that is used to spawn this levelvariantsets&#39; director instance.</summary>
	public UBlueprintGeneratedClass DirectorClass;
	///<summary>VariantSets</summary>
	public TArray<UVariantSet> VariantSets;
}
