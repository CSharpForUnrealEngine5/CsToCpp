#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for Viewport Interaction and VR Mode. Note that this is primarily a base class for anything that needs to be accessed in the VI module.</summary>
[CppInclude("VISettings.h")]
public partial class UVISettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the world should scale relative to your tracking space floor instead of the center of your hand locations</summary>
	public bool bScaleWorldFromFloor;
	///<summary>Whether to compute a new center point for scaling relative from by looking at how far either controller moved relative to the last frame</summary>
	public bool bScaleWorldWithDynamicPivot;
	///<summary>When enabled, you can freely rotate and scale the world with two hands at the same time.  Otherwise, we&#39;ll detect whether to rotate or scale depending on how much of either gesture you initially perform.</summary>
	public bool bAllowSimultaneousWorldScalingAndRotation;
}
