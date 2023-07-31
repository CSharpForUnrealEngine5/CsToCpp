#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores relevant information for an axis for the virtual camera pawn</summary>
[CppInclude("VirtualCameraSaveGame.h")]
public partial struct FVirtualCameraAxisSettings {
	public bool bIsLocked;
	public bool bIsFrozen;
	public float StabilizationScale;
	public float MovementScale;
}
