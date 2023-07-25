#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
///<summary>Supported methods for focusing the camera.</summary>
public enum ECameraFocusMethod {
	DoNotOverride=0,
	Manual=1,
	Tracking=2,
	Disable=3,
	MAX=4,
}
