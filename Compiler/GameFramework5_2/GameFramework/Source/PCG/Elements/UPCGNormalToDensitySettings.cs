#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Finds the angle against the specified direction and applies that to the density</summary>
[CppInclude("Elements/PCGNormalToDensity.h")]
public partial class UPCGNormalToDensitySettings : UPCGSettings {
	///<summary>The normal to compare against</summary>
	public FVector Normal;
	///<summary>This is biases the value towards or against the normal (positive or negative)</summary>
	public double Offset;
	///<summary>This applies a curve to scale the result density with Result = Result^(1/Strength)</summary>
	public double Strength;
	///<summary>The operator to apply to the output density</summary>
	public PCGNormalToDensityMode DensityMode;
}
