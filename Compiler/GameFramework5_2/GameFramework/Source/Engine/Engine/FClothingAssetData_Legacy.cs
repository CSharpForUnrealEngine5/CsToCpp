#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Legacy struct for handling back compat serialization</summary>
[CppInclude("Engine/SkeletalMesh.h")]
public partial struct FClothingAssetData_Legacy {
	public string AssetName;
	public string ApexFileName;
	public bool bClothPropertiesChanged;
	public FClothPhysicsProperties_Legacy PhysicsProperties;
}
