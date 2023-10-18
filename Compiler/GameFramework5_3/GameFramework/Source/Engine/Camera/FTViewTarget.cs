namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ViewTarget is the primary actor the camera is associated with.</summary>
[CppInclude("Camera/PlayerCameraManager.h")]
public partial struct FTViewTarget {
	public AActor Target;
	public FMinimalViewInfo POV;
	public APlayerState PlayerState;
}
