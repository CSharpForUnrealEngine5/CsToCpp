#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelVariantSets.h")]
public partial class ULevelVariantSets : UObject {
// LevelVariantSets
	public  int GetNumVariantSets() { return default; }
	public  UVariantSet GetVariantSet(int VariantSetIndex) { return default; }
	public  UVariantSet GetVariantSetByName(string VariantSetName) { return default; }
	public UObject DirectorBlueprint;
	public UBlueprintGeneratedClass DirectorClass;
	public TArray<UVariantSet> VariantSets;
}
