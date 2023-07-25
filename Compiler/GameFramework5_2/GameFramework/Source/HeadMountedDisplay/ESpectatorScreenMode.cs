#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
///<summary>The Spectator Screen Mode controls what the non-vr video device displays on platforms that support one.</summary>
public enum ESpectatorScreenMode {
	Disabled=0,
	SingleEyeLetterboxed=1,
	Undistorted=2,
	Distorted=3,
	SingleEye=4,
	SingleEyeCroppedToFill=5,
	Texture=6,
	TexturePlusEye=7,
}
