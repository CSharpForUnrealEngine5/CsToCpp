#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/LinearStairBuilder.h")]
public partial class ULinearStairBuilder : UEditorBrushBuilder {
	///<summary>The length of each step</summary>
	public int StepLength;
	///<summary>The height of each step</summary>
	public int StepHeight;
	///<summary>The width of each step</summary>
	public int StepWidth;
	///<summary>The number of steps</summary>
	public int NumSteps;
	///<summary>The distance below the first step</summary>
	public int AddToFirstStep;
	///<summary>GroupName</summary>
	public string GroupName;
}
