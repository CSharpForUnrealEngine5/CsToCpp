#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_TimeOffset.h")]
///<summary>Records a value over time and can access the value from the past</summary>
public partial struct FRigVMFunction_TimeOffsetFloat {
// RigVMFunction_TimeOffsetFloat
	public float Value;
	public float SecondsAgo;
	public int BufferSize;
	public float TimeRange;
	public float Result;
	public TArray<float> Buffer;
	public TArray<float> DeltaTimes;
	public int LastInsertIndex;
	public int UpperBound;
}
