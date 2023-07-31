#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Spherical lens distortion parameters</summary>
[CppInclude("Models/SphericalLensModel.h")]
public partial struct FSphericalDistortionParameters {
	public float K1;
	public float K2;
	public float K3;
	public float P1;
	public float P2;
}
