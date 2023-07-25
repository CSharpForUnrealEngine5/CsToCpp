#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/SpiralStairBuilder.h")]
public partial class USpiralStairBuilder : UEditorBrushBuilder {
// SpiralStairBuilder
	public int InnerRadius;
	public int StepWidth;
	public int StepHeight;
	public int StepThickness;
	public int NumStepsPer360;
	public int NumSteps;
	public string GroupName;
	public bool SlopedCeiling;
	public bool SlopedFloor;
	public bool CounterClockwise;
}
