namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the OpenXR HMD plugin.</summary>
[CppInclude("OpenXRHMDSettings.h")]
public partial class UOpenXRHMDSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enables foveation provided by the XR_FB_foveation OpenXR extension.</summary>
	public bool bIsFBFoveationEnabled;
}
