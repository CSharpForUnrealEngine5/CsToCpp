namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprint.h")]
public partial struct FRigGraphDisplaySettings {
	public bool bShowNodeInstructionIndex;
	public bool bShowNodeRunCounts;
	public int NodeRunLowerBound;
	public int NodeRunLimit;
	public double MinMicroSeconds;
	public double MaxMicroSeconds;
	public double TotalMicroSeconds;
	public bool bAutoDetermineRange;
	public double LastMinMicroSeconds;
	public double LastMaxMicroSeconds;
	public FLinearColor MinDurationColor;
	public FLinearColor MaxDurationColor;
}
