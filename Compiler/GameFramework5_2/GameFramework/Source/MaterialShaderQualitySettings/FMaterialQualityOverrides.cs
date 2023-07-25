#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShaderPlatformQualitySettings.h")]
///<summary>FMaterialQualityOverrides represents the full set of possible material overrides per quality level.</summary>
public partial struct FMaterialQualityOverrides {
// MaterialQualityOverrides
	public bool bDiscardQualityDuringCook;
	public bool bEnableOverride;
	public bool bForceFullyRough;
	public bool bForceNonMetal;
	public bool bForceDisableLMDirectionality;
	public bool bForceDisablePreintegratedGF;
	public bool bDisableMaterialNormalCalculation;
	public EMobileShadowQuality MobileShadowQuality;
}
