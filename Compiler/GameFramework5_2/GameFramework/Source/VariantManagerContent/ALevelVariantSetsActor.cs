#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelVariantSetsActor.h")]
public partial class ALevelVariantSetsActor : AActor {
	///<summary>Returns the LevelVariantSets asset, optionally loading it if necessary</summary>
	public  ULevelVariantSets GetLevelVariantSets(bool bLoad/*=false*/) { return default; }
	///<summary>SetLevelVariantSets</summary>
	public  void SetLevelVariantSets(ULevelVariantSets InVariantSets) {}
	///<summary>SwitchOnVariantByName</summary>
	public  bool SwitchOnVariantByName(string VariantSetName,string VariantName) { return default; }
	///<summary>SwitchOnVariantByIndex</summary>
	public  bool SwitchOnVariantByIndex(int VariantSetIndex,int VariantIndex) { return default; }
	///<summary>LevelVariantSets</summary>
	public FSoftObjectPath LevelVariantSets;
	///<summary>DirectorInstances</summary>
	public TMap<UBlueprintGeneratedClass,ULevelVariantSetsFunctionDirector> DirectorInstances;
}
