#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/CurvedStairBuilder.h")]
public partial class UCurvedStairBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>The radius of the inner curve of the stair</summary>
	public int InnerRadius;
	///<summary>The height of each step</summary>
	public int StepHeight;
	///<summary>The width of each step</summary>
	public int StepWidth;
	///<summary>The angle of the total arc described by this stair</summary>
	public int AngleOfCurve;
	///<summary>The number of steps</summary>
	public int NumSteps;
	///<summary>The distance below the first step</summary>
	public int AddToFirstStep;
	///<summary>GroupName</summary>
	public string GroupName;
	///<summary>Whether the stair curves clockwise or counter-clockwise</summary>
	public bool CounterClockwise;
}
