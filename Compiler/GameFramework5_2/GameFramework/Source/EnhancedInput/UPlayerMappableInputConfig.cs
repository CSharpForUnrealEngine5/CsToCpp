#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPlayerMappableInputConfig</summary>
[CppInclude("PlayerMappableInputConfig.h")]
public partial class UPlayerMappableInputConfig : UPrimaryDataAsset {
	///<summary>Get all the player mappable keys in this config.</summary>
	public  TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys() { return default; }
	///<summary>Returns the action key mapping for the mapping that matches the given name</summary>
	public  FEnhancedActionKeyMapping GetMappingByName(string MappingName) { return default; }
	///<summary>Returns all the keys mapped to a specific Input Action in this mapping config.</summary>
	public  TArray<FEnhancedActionKeyMapping> GetKeysBoundToAction(UInputAction InAction) { return default; }
	///<summary>Resets this mappable config to use the keys</summary>
	public  void ResetToDefault() {}
	///<summary>The unique name of this config that can be used when saving it</summary>
	public string ConfigName;
	///<summary>The display name that can be used</summary>
	public string ConfigDisplayName;
	///<summary>A flag that can be used to mark this Input Config as deprecated to your player/designers.</summary>
	public bool bIsDeprecated;
	///<summary>Metadata that can used to store any other related items to your key mapping such as icons, ability assets, etc.</summary>
	public UObject Metadata;
	///<summary>Mapping contexts that make up this Input Config with their associated priority.</summary>
	public TMap<UInputMappingContext,int> Contexts;
	///<summary>Return all the Input Mapping contexts that</summary>
	public  TMap<UInputMappingContext,int> GetMappingContexts() { return default; }
	///<summary>GetConfigName</summary>
	public  string GetConfigName() { return default; }
	///<summary>GetDisplayName</summary>
	public  string GetDisplayName() { return default; }
	///<summary>IsDeprecated</summary>
	public  bool IsDeprecated() { return default; }
	///<summary>Get all the player mappable keys in this config.</summary>
	public  UObject GetMetadata() { return default; }
}
