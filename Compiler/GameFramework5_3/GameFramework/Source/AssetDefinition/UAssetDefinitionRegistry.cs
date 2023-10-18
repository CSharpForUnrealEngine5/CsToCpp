namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetDefinitionRegistry.h")]
public partial class UAssetDefinitionRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AssetDefinitions</summary>
	public TMap<TSoftObjectPtr<UClass>,UAssetDefinition> AssetDefinitions;
}
