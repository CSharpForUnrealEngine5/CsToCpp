#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the OculusVR plugin.</summary>
[CppInclude("OculusHMDRuntimeSettings.h")]
public partial class UDEPRECATED_UOculusHMDRuntimeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bAutoEnabled</summary>
	public bool bAutoEnabled;
	///<summary>SplashDescs</summary>
	public TArray<FOculusSplashDesc> SplashDescs;
	///<summary>XrApi</summary>
	public EOculusXrApi XrApi;
	///<summary>ColorSpace</summary>
	public EOculusColorSpace ColorSpace;
	///<summary>bSupportsDash</summary>
	public bool bSupportsDash;
	///<summary>bCompositesDepth</summary>
	public bool bCompositesDepth;
	///<summary>bHQDistortion</summary>
	public bool bHQDistortion;
	///<summary>PixelDensityMin</summary>
	public float PixelDensityMin;
	///<summary>PixelDensityMax</summary>
	public float PixelDensityMax;
	///<summary>OSSplashScreen</summary>
	public FFilePath OSSplashScreen;
	///<summary>CPULevel</summary>
	public int CPULevel;
	///<summary>GPULevel</summary>
	public int GPULevel;
	///<summary>bFocusAware</summary>
	public bool bFocusAware;
	///<summary>bLateLatching</summary>
	public bool bLateLatching;
	///<summary>bRequiresSystemKeyboard</summary>
	public bool bRequiresSystemKeyboard;
	///<summary>HandTrackingSupport</summary>
	public EHandTrackingSupport HandTrackingSupport;
	///<summary>HandTrackingFrequency</summary>
	public EHandTrackingFrequency HandTrackingFrequency;
	///<summary>bPhaseSync</summary>
	public bool bPhaseSync;
}
