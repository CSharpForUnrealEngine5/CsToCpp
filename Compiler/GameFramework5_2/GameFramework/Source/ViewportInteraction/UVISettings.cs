#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VISettings.h")]
///<summary>Implements the settings for Viewport Interaction and VR Mode. Note that this is primarily a base class for anything that needs to be accessed in the VI module.</summary>
public partial class UVISettings : UObject {
// VISettings
	public bool bScaleWorldFromFloor;
	public bool bScaleWorldWithDynamicPivot;
	public bool bAllowSimultaneousWorldScalingAndRotation;
}
