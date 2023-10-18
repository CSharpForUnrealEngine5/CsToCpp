namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ITDSpatializationSourceSettings.h")]
public partial class UITDSpatializationSourceSettings : USpatializationPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether we should use any level difference between the left and right channel in our spatialization algorithm.</summary>
	public bool bEnableILD;
	///<summary>This curve will map the intensity of panning (y-axis, 0.0-1.0) as a factor of distance (in Unreal Units)</summary>
	public FRuntimeFloatCurve PanningIntensityOverDistance;
}
