namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationScreenshotOptions.h")]
public partial struct FAutomationScreenshotOptions {
	public FVector2D Resolution;
	public float Delay;
	public int FrameDelay;
	public bool bOverride_OverrideTimeTo;
	public double OverrideTimeTo;
	public bool bDisableNoisyRenderingFeatures;
	public bool bDisableTonemapping;
	public UAutomationViewSettings ViewSettings;
	public string VisualizeBuffer;
	public EComparisonTolerance Tolerance;
	public FComparisonToleranceAmount ToleranceAmount;
	public float MaximumLocalError;
	public float MaximumGlobalError;
	public bool bIgnoreAntiAliasing;
	public bool bIgnoreColors;
}
