#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigSpacePickerBakeSettings.h")]
public partial struct FRigSpacePickerBakeSettings {
	public FRigElementKey TargetSpace;
	public FFrameNumber StartFrame;
	public FFrameNumber EndFrame;
	public bool bReduceKeys;
	public float Tolerance;
}
