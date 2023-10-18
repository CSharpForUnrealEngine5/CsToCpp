namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory class for FPhysicsAssetRenderSettings.</summary>
[CppInclude("PhysicsAssetRenderUtils.h")]
public partial class UPhysicsAssetRenderUtilities : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>IdToSettingsMap</summary>
	public TMap<uint,FPhysicsAssetRenderSettings> IdToSettingsMap;
	///<summary>BoneUnselectedMaterial</summary>
	public UMaterialInterface BoneUnselectedMaterial;
	///<summary>BoneNoCollisionMaterial</summary>
	public UMaterialInterface BoneNoCollisionMaterial;
}
