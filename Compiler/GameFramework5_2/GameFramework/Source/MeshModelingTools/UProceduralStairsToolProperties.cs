#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralStairsToolProperties : UProceduralShapeToolProperties {
	///<summary>Type of staircase</summary>
	public EProceduralStairsType StairsType;
	///<summary>Number of steps</summary>
	public int NumSteps;
	///<summary>Width of each step</summary>
	public float StepWidth;
	///<summary>Height of each step</summary>
	public float StepHeight;
	///<summary>Depth of each step of linear stairs</summary>
	public float StepDepth;
	///<summary>Angular length of curved stairs. Positive values are for clockwise and negative values are for counterclockwise.</summary>
	public float CurveAngle;
	///<summary>Angular length of spiral stairs. Positive values are for clockwise and negative values are for counterclockwise.</summary>
	public float SpiralAngle;
	///<summary>Inner radius of curved and spiral stairs</summary>
	public float InnerRadius;
}
