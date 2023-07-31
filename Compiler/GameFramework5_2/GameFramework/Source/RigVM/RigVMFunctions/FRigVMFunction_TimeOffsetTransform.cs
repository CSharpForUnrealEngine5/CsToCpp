#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Records a value over time and can access the value from the past</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_TimeOffset.h")]
public partial struct FRigVMFunction_TimeOffsetTransform {
	public FTransform Value;
	public float SecondsAgo;
	public int BufferSize;
	public float TimeRange;
	public FTransform Result;
	public TArray<FTransform> Buffer;
	public TArray<float> DeltaTimes;
	public int LastInsertIndex;
	public int UpperBound;
}
