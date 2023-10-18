namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replace the current physics assets to collide the simulation mesh against.</summary>
[CppInclude("ChaosClothAsset/SetPhysicsAssetNode.h")]
public partial struct FChaosClothAssetSetPhysicsAssetNode {
	public FManagedArrayCollection Collection;
	public UPhysicsAsset PhysicsAsset;
}
