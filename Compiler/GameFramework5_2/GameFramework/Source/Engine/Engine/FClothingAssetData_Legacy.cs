#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMesh.h")]
///<summary>Legacy struct for handling back compat serialization</summary>
public partial struct FClothingAssetData_Legacy {
// ClothingAssetData_Legacy
	public string AssetName;
	public string ApexFileName;
	public bool bClothPropertiesChanged;
	public FClothPhysicsProperties_Legacy PhysicsProperties;
}
