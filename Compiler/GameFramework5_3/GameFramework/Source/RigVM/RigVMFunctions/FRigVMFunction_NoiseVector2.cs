namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a vector through a noise fluctuation process between a min and a max through speed</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Noise.h")]
public partial struct FRigVMFunction_NoiseVector2 {
	public FVector Value;
	public FVector Speed;
	public FVector Frequency;
	public double Minimum;
	public double Maximum;
	public FVector Result;
	public FVector Time;
}
