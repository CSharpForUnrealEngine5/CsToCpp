namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning various asset related nodes (nodes associated with</summary>
[CppInclude("BlueprintAssetNodeSpawner.h")]
public partial class UBlueprintAssetNodeSpawner : UBlueprintNodeSpawner {
	public static UClass StaticClass() {return default;}
	///<summary>The asset to configure new nodes with.</summary>
	public FAssetData AssetData;
}
