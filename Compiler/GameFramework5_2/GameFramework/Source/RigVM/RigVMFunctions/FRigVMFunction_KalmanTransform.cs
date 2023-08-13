namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Averages a transform over time.</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
public partial struct FRigVMFunction_KalmanTransform {
	public FTransform Value;
	public int BufferSize;
	public FTransform Result;
	public TArray<FTransform> Buffer;
	public int LastInsertIndex;
}
