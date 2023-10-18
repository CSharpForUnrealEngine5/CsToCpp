namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMBlueprint.h")]
public partial struct FRigVMEdGraphDisplaySettings {
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
