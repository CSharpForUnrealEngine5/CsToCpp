#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
///<summary>Averages a value over time.</summary>
public partial struct FRigVMFunction_KalmanFloat {
// RigVMFunction_KalmanFloat
	public float Value;
	public int BufferSize;
	public float Result;
	public TArray<float> Buffer;
	public int LastInsertIndex;
}
