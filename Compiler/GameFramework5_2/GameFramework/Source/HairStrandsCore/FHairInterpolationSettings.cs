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
