#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAssetCommon.h")]
public partial struct FSkeletalMaterial {
	public UMaterialInterface MaterialInterface;
	public string MaterialSlotName;
	public bool bEnableShadowCasting_DEPRECATED;
	public bool bRecomputeTangent_DEPRECATED;
	public string ImportedMaterialSlotName;
	public FMeshUVChannelInfo UVChannelData;
}
