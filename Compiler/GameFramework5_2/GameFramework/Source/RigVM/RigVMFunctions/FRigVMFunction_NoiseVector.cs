#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a vector through a noise fluctuation process between a min and a max through speed</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Noise.h")]
public partial struct FRigVMFunction_NoiseVector {
	public FVector Position;
	public FVector Speed;
	public FVector Frequency;
	public float Minimum;
	public float Maximum;
	public FVector Result;
	public FVector Time;
}
