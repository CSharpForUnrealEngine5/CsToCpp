#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Takes care of spawning various asset related nodes (nodes associated with</summary>
[CppInclude("BlueprintAssetNodeSpawner.h")]
public partial class UBlueprintAssetNodeSpawner : UBlueprintNodeSpawner {
	///<summary>The asset to configure new nodes with.</summary>
	public FAssetData AssetData;
}
