namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Per Element Rotation in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_RotationSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>If true, Rotation is linearly interpolated between StartRotation and Rotation values</summary>
	public bool bInterpolate;
	///<summary>If true, Rotation at each Pattern Element is offset by a uniformly chosen random value in the range of [-RotationJitterRange, RotationJitterRange]</summary>
	public bool bJitter;
	///<summary>Rotation applied to all Pattern Elements, or to first Pattern Element for Interpolated rotation</summary>
	public FRotator StartRotation;
	///<summary>Rotation applied to last Pattern Elements for Interpolated rotation</summary>
	public FRotator EndRotation;
	///<summary>Upper bound of the range which is sampled to randomly rotate each Pattern Element if Jitter is true</summary>
	public FRotator Jitter;
}
