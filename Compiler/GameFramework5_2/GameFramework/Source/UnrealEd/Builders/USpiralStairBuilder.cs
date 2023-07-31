#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/SpiralStairBuilder.h")]
public partial class USpiralStairBuilder : UEditorBrushBuilder {
	///<summary>The radius of the inner curve of the stair</summary>
	public int InnerRadius;
	///<summary>The width of each step</summary>
	public int StepWidth;
	///<summary>The height of each step</summary>
	public int StepHeight;
	///<summary>The thickness of each step</summary>
	public int StepThickness;
	///<summary>The number of steps in one whole spiral rotation</summary>
	public int NumStepsPer360;
	///<summary>The total number of steps</summary>
	public int NumSteps;
	///<summary>GroupName</summary>
	public string GroupName;
	///<summary>Whether the underside of the spiral is sloped or stepped</summary>
	public bool SlopedCeiling;
	///<summary>Whether the surface of the spiral is sloped or stepped</summary>
	public bool SlopedFloor;
	///<summary>Whether the stair curves clockwise or counter-clockwise</summary>
	public bool CounterClockwise;
}
