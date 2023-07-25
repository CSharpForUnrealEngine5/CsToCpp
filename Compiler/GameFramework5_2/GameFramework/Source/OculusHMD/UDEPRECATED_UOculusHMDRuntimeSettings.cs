#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusHMDRuntimeSettings.h")]
///<summary>Implements the settings for the OculusVR plugin.</summary>
public partial class UDEPRECATED_UOculusHMDRuntimeSettings : UObject {
// UOculusHMDRuntimeSettings
	public bool bAutoEnabled;
	public TArray<FOculusSplashDesc> SplashDescs;
	public EOculusXrApi XrApi;
	public EOculusColorSpace ColorSpace;
	public bool bSupportsDash;
	public bool bCompositesDepth;
	public bool bHQDistortion;
	public float PixelDensityMin;
	public float PixelDensityMax;
	public FFilePath OSSplashScreen;
	public int CPULevel;
	public int GPULevel;
	public bool bFocusAware;
	public bool bLateLatching;
	public bool bRequiresSystemKeyboard;
	public EHandTrackingSupport HandTrackingSupport;
	public EHandTrackingFrequency HandTrackingFrequency;
	public bool bPhaseSync;
}
