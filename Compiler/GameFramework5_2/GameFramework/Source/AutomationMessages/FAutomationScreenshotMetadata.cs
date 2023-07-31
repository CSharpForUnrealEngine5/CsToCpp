#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationScreenshotMetadata {
	public string ScreenShotName;
	public string Context;
	public string TestName;
	public string Notes;
	public FGuid Id;
	public string Commit;
	public int Width;
	public int Height;
	public string Rhi;
	public string Platform;
	public string FeatureLevel;
	public bool bIsStereo;
	public string Vendor;
	public string AdapterName;
	public string AdapterInternalDriverVersion;
	public string AdapterUserDriverVersion;
	public string UniqueDeviceId;
	public float ResolutionQuality;
	public int ViewDistanceQuality;
	public int AntiAliasingQuality;
	public int ShadowQuality;
	public int GlobalIlluminationQuality;
	public int ReflectionQuality;
	public int PostProcessQuality;
	public int TextureQuality;
	public int EffectsQuality;
	public int FoliageQuality;
	public int ShadingQuality;
	public bool bHasComparisonRules;
	public byte ToleranceRed;
	public byte ToleranceGreen;
	public byte ToleranceBlue;
	public byte ToleranceAlpha;
	public byte ToleranceMinBrightness;
	public byte ToleranceMaxBrightness;
	public float MaximumLocalError;
	public float MaximumGlobalError;
	public bool bIgnoreAntiAliasing;
	public bool bIgnoreColors;
}
