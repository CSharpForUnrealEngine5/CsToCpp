#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVLensCalibrator.h")]
public partial class UOpenCVLensCalibrator : UObject {
	///<summary>@param BoardWidth The width of the checkerboard used to calibrate the camera counted as number of inner edges.</summary>
	public static UOpenCVLensCalibrator CreateCalibrator(int BoardWidth/*=7*/,int BoardHeight/*=5*/,float SquareSize/*=3.0f*/,bool bUseFisheyeModel/*=false*/) { return default; }
	///<summary>Feeds a render target to the calibration. It must contain a checkerboard somewhere in the image.</summary>
	public  bool FeedRenderTarget(UTextureRenderTarget2D TextureRenderTarget) { return default; }
	///<summary>Feeds an image to the calibration. It must contain a checkerboard somewhere in the image.</summary>
	public  bool FeedImage(string FilePath) { return default; }
	///<summary>@param LensDistortionParameters the calculated distortion data from the images passed into the calibrator.</summary>
	public  bool CalculateLensParameters(FOpenCVLensDistortionParameters LensDistortionParameters,float MarginOfError,FOpenCVCameraViewInfo CameraViewInfo) { return default; }
	///<summary>Smallest coordinates of a grid corner that was found. For best result, try to cover full resolution of the input.</summary>
	public FVector2D MinimumCornerCoordinates;
	///<summary>Biggest coordinates of a grid corner that was found. For best result, try to cover full resolution of the input.</summary>
	public FVector2D MaximumCornerCoordinates;
}
