#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/PlayerCameraManager.h")]
///<summary>A ViewTarget is the primary actor the camera is associated with.</summary>
public partial struct FTViewTarget {
// TViewTarget
	public AActor Target;
	public FMinimalViewInfo POV;
	public APlayerState PlayerState;
}
