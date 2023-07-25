#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVBlueprintFunctionLibrary.h")]
public partial struct FOpenCVArucoDetectedMarker {
// OpenCVArucoDetectedMarker
	public int Id;
	public TArray<FVector2D> Corners;
	public FTransform Pose;
}
