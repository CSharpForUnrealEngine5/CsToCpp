namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Linear Patterns in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_LinearSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Spacing Technique used to distribute Pattern Elements</summary>
	public EPatternToolAxisSpacingMode SpacingMode;
	///<summary>Number of Pattern Elements to place</summary>
	public int Count;
	///<summary>Fixed Increment used to place Pattern Elements</summary>
	public double StepSize;
	///<summary>Length of Pattern along the Axis</summary>
	public double Extent;
	///<summary>If true, Pattern is centered at the Origin, otherwise Pattern starts at the Origin</summary>
	public bool bCentered;
}
