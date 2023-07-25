#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
///<summary>Stores relevant information for an axis for the virtual camera pawn</summary>
public partial struct FVirtualCameraAxisSettings {
// VirtualCameraAxisSettings
	public bool bIsLocked;
	public bool bIsFrozen;
	public float StabilizationScale;
	public float MovementScale;
}
