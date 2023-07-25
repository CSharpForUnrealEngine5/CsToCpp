#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlayerMappableInputConfig.h")]
///<summary>UPlayerMappableInputConfig</summary>
public partial class UPlayerMappableInputConfig : UPrimaryDataAsset {
// PlayerMappableInputConfig
	public TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys() { return default; }
	public FEnhancedActionKeyMapping GetMappingByName(string MappingName) { return default; }
	public TArray<FEnhancedActionKeyMapping> GetKeysBoundToAction(UObject InAction) { return default; }
	public void ResetToDefault() {}
	public string ConfigName;
	public string ConfigDisplayName;
	public bool bIsDeprecated;
	public UObject Metadata;
	public TMap<UInputMappingContext,int> Contexts;
	public TMap<UInputMappingContext,int> GetMappingContexts() { return default; }
	public string GetConfigName() { return default; }
	public string GetDisplayName() { return default; }
	public bool IsDeprecated() { return default; }
	public UObject GetMetadata() { return default; }
}
