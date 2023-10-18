namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomSettings.h")]
public partial struct FGroomBuildSettings {
	public bool bOverrideGuides;
	public float HairToGuideDensity;
	public EGroomInterpolationQuality InterpolationQuality;
	public EGroomInterpolationWeight InterpolationDistance;
	public bool bRandomizeGuide;
	public bool bUseUniqueGuide;
}
