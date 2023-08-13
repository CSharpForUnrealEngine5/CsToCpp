namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Averages a value over time.</summary>
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Kalman.h")]
public partial struct FRigVMFunction_KalmanFloat {
	public float Value;
	public int BufferSize;
	public float Result;
	public TArray<float> Buffer;
	public int LastInsertIndex;
}
