namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAssetCommon.h")]
public partial struct FSkeletalMaterial {
	public UMaterialInterface MaterialInterface;
	public FName MaterialSlotName;
	public bool bEnableShadowCasting_DEPRECATED;
	public bool bRecomputeTangent_DEPRECATED;
	public FName ImportedMaterialSlotName;
	public FMeshUVChannelInfo UVChannelData;
}
