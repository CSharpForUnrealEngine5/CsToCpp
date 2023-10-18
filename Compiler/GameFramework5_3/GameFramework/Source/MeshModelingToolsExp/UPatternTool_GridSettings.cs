namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Grid Patterns in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_GridSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Spacing Technique used to distribute Pattern Elements along the Main axis</summary>
	public EPatternToolAxisSpacingMode SpacingX;
	///<summary>Number of Pattern Elements to place along the Main axis</summary>
	public int CountX;
	///<summary>Fixed Increment used to place Pattern Elements along the Main axis</summary>
	public double StepSizeX;
	///<summary>Length/Extent of Pattern falong the Main Axis</summary>
	public double ExtentX;
	///<summary>If true, Pattern is centered at the Origin along the Main axis, otherwise Pattern starts at the Origin</summary>
	public bool bCenteredX;
	///<summary>Spacing Technique used to distribute Pattern Elements along the Secondary axis</summary>
	public EPatternToolAxisSpacingMode SpacingY;
	///<summary>Number of  Pattern Elements to place along the Secondary axis</summary>
	public int CountY;
	///<summary>Fixed Increment used to place Pattern Elements along the Secondary axis</summary>
	public double StepSizeY;
	///<summary>Length/Extent of Pattern falong the Secondary Axis</summary>
	public double ExtentY;
	///<summary>If true, Pattern is centered at the Origin along the Secondary axis, otherwise Pattern starts at the Origin</summary>
	public bool bCenteredY;
}
