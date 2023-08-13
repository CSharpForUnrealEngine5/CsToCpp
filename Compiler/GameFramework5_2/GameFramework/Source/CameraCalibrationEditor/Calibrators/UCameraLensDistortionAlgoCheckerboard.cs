namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a lens distortion calibration algorithm. It requires a checkerboard pattern</summary>
[CppInclude("Calibrators/CameraLensDistortionAlgoCheckerboard.h")]
public partial class UCameraLensDistortionAlgoCheckerboard : UCameraLensDistortionAlgo {
	public static UClass StaticClass() {return default;}
}
