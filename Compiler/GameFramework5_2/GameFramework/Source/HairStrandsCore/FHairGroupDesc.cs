#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomDesc.h")]
///<summary>Note: If a new field is added to this struct, think to update GroomComponentDestailsCustomization.cpp to handle override flags</summary>
public partial struct FHairGroupDesc {
// HairGroupDesc
	public float HairLength;
	public float HairWidth;
	public bool HairWidth_Override;
	public float HairRootScale;
	public bool HairRootScale_Override;
	public float HairTipScale;
	public bool HairTipScale_Override;
	public float HairShadowDensity;
	public bool HairShadowDensity_Override;
	public float HairRaytracingRadiusScale;
	public bool HairRaytracingRadiusScale_Override;
	public bool bUseHairRaytracingGeometry;
	public bool bUseHairRaytracingGeometry_Override;
	public float LODBias;
	public bool bUseStableRasterization;
	public bool bUseStableRasterization_Override;
	public bool bScatterSceneLighting;
	public bool bScatterSceneLighting_Override;
	public bool bSupportVoxelization;
	public bool bSupportVoxelization_Override;
	public float HairLengthScale;
	public bool HairLengthScale_Override;
}
