namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simulates a time value - and outputs loop information</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Timeline.h")]
public partial struct FRigVMFunction_TimeLoop {
	public float Speed;
	public float Duration;
	public bool Normalize;
	public float Absolute;
	public float Relative;
	public float FlipFlop;
	public bool Even;
	public float AccumulatedAbsolute;
	public float AccumulatedRelative;
	public int NumIterations;
	public bool bIsInitialized;
}
