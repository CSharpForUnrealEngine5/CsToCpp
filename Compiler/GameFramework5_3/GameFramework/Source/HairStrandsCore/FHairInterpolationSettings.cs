namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetInterpolation.h")]
public partial struct FHairInterpolationSettings {
	public EGroomGuideType GuideType;
	public bool bOverrideGuides_DEPRECATED;
	public float HairToGuideDensity;
	public int RiggedGuideNumCurves;
	public int RiggedGuideNumPoints;
	public EHairInterpolationQuality InterpolationQuality;
	public EHairInterpolationWeight InterpolationDistance;
	public bool bRandomizeGuide;
	public bool bUseUniqueGuide;
}
