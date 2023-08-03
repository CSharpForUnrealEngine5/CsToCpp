#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Radial Patterns in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_RadialSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Spacing Technique used to distribute Pattern Elements around the Circle/Arc</summary>
	public EPatternToolAxisSpacingMode SpacingMode;
	///<summary>Number of  Pattern Elements to place</summary>
	public int Count;
	///<summary>Fixed Increment (in Degrees) used to position Pattern Elements around the Circle/Arc</summary>
	public double StepSize;
	///<summary>Radius of the Circle/Arc</summary>
	public double Radius;
	///<summary>Start angle of the Circle/Arc</summary>
	public double StartAngle;
	///<summary>End angle of the Circle/Arc</summary>
	public double EndAngle;
	///<summary>Fixed offset added to Start/End Angles</summary>
	public double AngleShift;
	///<summary>If true, Pattern elements are rotated to align with the Circle tangent</summary>
	public bool bOriented;
}
