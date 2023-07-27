#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelVariantSetsActor.h")]
public partial class ALevelVariantSetsActor : AActor {
// LevelVariantSetsActor
	public  ULevelVariantSets GetLevelVariantSets(bool bLoad/*=false*/) { return default; }
	public  void SetLevelVariantSets(ULevelVariantSets InVariantSets) {}
	public  bool SwitchOnVariantByName(string VariantSetName,string VariantName) { return default; }
	public  bool SwitchOnVariantByIndex(int VariantSetIndex,int VariantIndex) { return default; }
	public FSoftObjectPath LevelVariantSets;
	public TMap<UBlueprintGeneratedClass,ULevelVariantSetsFunctionDirector> DirectorInstances;
}
