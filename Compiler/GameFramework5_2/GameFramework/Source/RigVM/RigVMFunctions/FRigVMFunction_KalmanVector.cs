#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
///<summary>Averages a value over time.</summary>
public partial struct FRigVMFunction_KalmanVector {
// RigVMFunction_KalmanVector
	public FVector Value;
	public int BufferSize;
	public FVector Result;
	public TArray<FVector> Buffer;
	public int LastInsertIndex;
}
