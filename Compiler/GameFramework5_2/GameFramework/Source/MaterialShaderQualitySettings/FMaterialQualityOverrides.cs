#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FMaterialQualityOverrides represents the full set of possible material overrides per quality level.</summary>
[CppInclude("ShaderPlatformQualitySettings.h")]
public partial struct FMaterialQualityOverrides {
	public bool bDiscardQualityDuringCook;
	public bool bEnableOverride;
	public bool bForceFullyRough;
	public bool bForceNonMetal;
	public bool bForceDisableLMDirectionality;
	public bool bForceDisablePreintegratedGF;
	public bool bDisableMaterialNormalCalculation;
	public EMobileShadowQuality MobileShadowQuality;
}
