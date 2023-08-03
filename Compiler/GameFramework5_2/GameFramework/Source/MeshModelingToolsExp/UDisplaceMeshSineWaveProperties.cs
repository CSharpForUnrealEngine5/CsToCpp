#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PropertySet for Sine wave displacement</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshSineWaveProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Sine wave displacement frequency</summary>
	public float SineWaveFrequency;
	///<summary>Sine wave phase shift</summary>
	public float SineWavePhaseShift;
	///<summary>Unit vector representing the direction of wave displacement.</summary>
	public FVector SineWaveDirection;
}
