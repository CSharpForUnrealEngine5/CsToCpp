#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for Grid Patterns in the Pattern Tool</summary>
public partial class UPatternTool_GridSettings : UInteractiveToolPropertySet {
// PatternTool_GridSettings
	public EPatternToolAxisSpacingMode SpacingX;
	public int CountX;
	public double StepSizeX;
	public double ExtentX;
	public bool bCenteredX;
	public EPatternToolAxisSpacingMode SpacingY;
	public int CountY;
	public double StepSizeY;
	public double ExtentY;
	public bool bCenteredY;
}
