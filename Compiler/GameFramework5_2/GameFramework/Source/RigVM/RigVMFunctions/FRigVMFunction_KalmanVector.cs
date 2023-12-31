namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Averages a value over time.</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
public partial struct FRigVMFunction_KalmanVector {
	public FVector Value;
	public int BufferSize;
	public FVector Result;
	public TArray<FVector> Buffer;
	public int LastInsertIndex;
}
