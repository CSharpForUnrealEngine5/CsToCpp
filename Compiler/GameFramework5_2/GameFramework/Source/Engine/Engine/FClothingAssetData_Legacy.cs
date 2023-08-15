namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Legacy struct for handling back compat serialization</summary>
[CppInclude("Engine/SkeletalMesh.h")]
public partial struct FClothingAssetData_Legacy {
	public FName AssetName;
	public string ApexFileName;
	public bool bClothPropertiesChanged;
	public FClothPhysicsProperties_Legacy PhysicsProperties;
}
