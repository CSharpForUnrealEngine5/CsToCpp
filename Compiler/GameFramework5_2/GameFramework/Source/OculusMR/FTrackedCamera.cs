#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_State.h")]
public partial struct FTrackedCamera {
	public int Index;
	public string Name;
	public double UpdateTime;
	public float FieldOfView;
	public int SizeX;
	public int SizeY;
	public ETrackedDeviceType AttachedTrackedDevice;
	public FRotator CalibratedRotation;
	public FVector CalibratedOffset;
	public FRotator UserRotation;
	public FVector UserOffset;
	public FRotator RawRotation_DEPRECATED;
	public FVector RawOffset_DEPRECATED;
}
