#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetActionUtility.h")]
///<summary>Base class for all asset action-related utilities</summary>
public partial class UAssetActionUtility : UEditorUtilityObject {
// AssetActionUtility
	public UClass GetSupportedClass() { return default; }
	public bool IsActionForBlueprints() { return default; }
	public TArray<TSoftObjectPtr<UClass>> GetSupportedClasses() { return default; }
	public TArray<TSoftObjectPtr<UClass>> SupportedClasses;
	public TArray<FAssetActionSupportCondition> SupportedConditions;
}
