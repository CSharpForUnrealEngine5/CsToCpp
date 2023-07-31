#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a float through a noise fluctuation process between a min and a max through speed</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_Noise.h")]
public partial struct FRigVMFunction_NoiseDouble {
	public double Value;
	public double Speed;
	public double Frequency;
	public double Minimum;
	public double Maximum;
	public double Result;
	public double Time;
}
