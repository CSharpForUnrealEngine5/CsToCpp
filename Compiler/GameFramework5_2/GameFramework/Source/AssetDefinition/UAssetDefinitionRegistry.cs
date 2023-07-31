#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetDefinitionRegistry.h")]
public partial class UAssetDefinitionRegistry : UObject {
	///<summary>AssetDefinitions</summary>
	public TMap<TSoftObjectPtr<UClass>,UAssetDefinition> AssetDefinitions;
}
