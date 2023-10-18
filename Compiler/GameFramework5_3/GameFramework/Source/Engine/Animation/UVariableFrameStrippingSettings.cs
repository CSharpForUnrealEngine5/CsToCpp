namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This is a wrapper for the Variable frame stripping Codec.</summary>
[CppInclude("Animation/VariableFrameStrippingSettings.h")]
public partial class UVariableFrameStrippingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enables the change from standard 1/2 frame stripping to stripping a higher amount of frames per frame kept</summary>
	public FPerPlatformBool UseVariableFrameStripping;
	///<summary>The number of Frames that are stripped down to one.</summary>
	public FPerPlatformInt FrameStrippingRate;
}
