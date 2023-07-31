#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a float through a noise fluctuation process between a min and a max through speed</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Noise.h")]
public partial struct FRigVMFunction_NoiseFloat {
	public float Value;
	public float Speed;
	public float Frequency;
	public float Minimum;
	public float Maximum;
	public float Result;
	public float Time;
}
