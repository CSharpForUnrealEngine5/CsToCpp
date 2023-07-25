#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGNormalToDensity.h")]
///<summary>Finds the angle against the specified direction and applies that to the density</summary>
public partial class UPCGNormalToDensitySettings : UPCGSettings {
// PCGNormalToDensitySettings
	public FVector Normal;
	public double Offset;
	public double Strength;
	public PCGNormalToDensityMode DensityMode;
}
