#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetInterpolation.h")]
public partial struct FHairInterpolationSettings {
	public bool bOverrideGuides;
	public float HairToGuideDensity;
	public EHairInterpolationQuality InterpolationQuality;
	public EHairInterpolationWeight InterpolationDistance;
	public bool bRandomizeGuide;
	public bool bUseUniqueGuide;
}
