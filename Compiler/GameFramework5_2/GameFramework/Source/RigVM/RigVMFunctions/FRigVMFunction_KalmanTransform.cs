#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
///<summary>Averages a transform over time.</summary>
public partial struct FRigVMFunction_KalmanTransform {
// RigVMFunction_KalmanTransform
	public FTransform Value;
	public int BufferSize;
	public FTransform Result;
	public TArray<FTransform> Buffer;
	public int LastInsertIndex;
}
