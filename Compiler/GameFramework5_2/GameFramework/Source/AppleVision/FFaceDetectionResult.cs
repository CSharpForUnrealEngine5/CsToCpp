#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The result of a face detection request with information about the detected faces</summary>
[CppInclude("AppleVisionTypes.h")]
public partial struct FFaceDetectionResult {
	public TArray<FDetectedFace> DetectedFaces;
}
