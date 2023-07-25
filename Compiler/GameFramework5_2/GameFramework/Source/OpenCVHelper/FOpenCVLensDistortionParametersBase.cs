#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVHelper.h")]
///<summary>Mathematic camera model for lens distortion/undistortion.</summary>
public partial struct FOpenCVLensDistortionParametersBase {
// OpenCVLensDistortionParametersBase
	public float K1;
	public float K2;
	public float P1;
	public float P2;
	public float K3;
	public float K4;
	public float K5;
	public float K6;
	public FVector2D F;
	public FVector2D C;
	public bool bUseFisheyeModel;
}
