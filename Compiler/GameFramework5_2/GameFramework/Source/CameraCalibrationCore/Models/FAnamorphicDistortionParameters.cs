#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Lens distortion parameters for the 3DE4 Anamorphic - Standard Degree 4 model</summary>
[CppInclude("Models/AnamorphicLensModel.h")]
public partial struct FAnamorphicDistortionParameters {
	public float PixelAspect;
	public float CX02;
	public float CX04;
	public float CX22;
	public float CX24;
	public float CX44;
	public float CY02;
	public float CY04;
	public float CY22;
	public float CY24;
	public float CY44;
	public float SqueezeX;
	public float SqueezeY;
	public float LensRotation;
}
