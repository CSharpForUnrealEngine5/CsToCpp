#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_Noise.h")]
///<summary>Generates a vector through a noise fluctuation process between a min and a max through speed</summary>
public partial struct FRigVMFunction_NoiseVector {
// RigVMFunction_NoiseVector
	public FVector Position;
	public FVector Speed;
	public FVector Frequency;
	public float Minimum;
	public float Maximum;
	public FVector Result;
	public FVector Time;
}
