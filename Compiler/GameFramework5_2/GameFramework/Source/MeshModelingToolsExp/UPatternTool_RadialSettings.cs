#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for Radial Patterns in the Pattern Tool</summary>
public partial class UPatternTool_RadialSettings : UInteractiveToolPropertySet {
// PatternTool_RadialSettings
	public EPatternToolAxisSpacingMode SpacingMode;
	public int Count;
	public double StepSize;
	public double Radius;
	public double StartAngle;
	public double EndAngle;
	public double AngleShift;
	public bool bOriented;
}
