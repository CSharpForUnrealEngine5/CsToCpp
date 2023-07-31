#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleVisionBlueprintProxy.h")]
public partial class UAppleVisionDetectFacesAsyncTaskBlueprintProxy : UObject {
	///<summary>OnSuccess</summary>
	public FAppleVisionDetectFacesDelegate OnSuccess;
	///<summary>OnFailure</summary>
	public FAppleVisionDetectFacesDelegate OnFailure;
	///<summary>Detects faces within an image</summary>
	public static UAppleVisionDetectFacesAsyncTaskBlueprintProxy CreateProxyObjectForDetectFaces(UTexture SourceImage) { return default; }
	///<summary>FaceDetectionResult</summary>
	public FFaceDetectionResult FaceDetectionResult;
}
