namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationViewSettings.h")]
public partial class UAutomationViewSettings : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>AntiAliasing</summary>
	public bool AntiAliasing;
	///<summary>MotionBlur</summary>
	public bool MotionBlur;
	///<summary>TemporalAA</summary>
	public bool TemporalAA;
	///<summary>ScreenSpaceReflections</summary>
	public bool ScreenSpaceReflections;
	///<summary>ScreenSpaceAO</summary>
	public bool ScreenSpaceAO;
	///<summary>DistanceFieldAO</summary>
	public bool DistanceFieldAO;
	///<summary>ContactShadows</summary>
	public bool ContactShadows;
	///<summary>EyeAdaptation</summary>
	public bool EyeAdaptation;
	///<summary>Bloom</summary>
	public bool Bloom;
}
