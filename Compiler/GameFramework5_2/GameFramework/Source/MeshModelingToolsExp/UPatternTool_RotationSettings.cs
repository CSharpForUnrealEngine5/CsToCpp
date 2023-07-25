#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for Per Element Rotation in the Pattern Tool</summary>
public partial class UPatternTool_RotationSettings : UInteractiveToolPropertySet {
// PatternTool_RotationSettings
	public bool bInterpolate;
	public bool bJitter;
	public FRotator StartRotation;
	public FRotator EndRotation;
	public FRotator Jitter;
}
