#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVBlueprintFunctionLibrary.h")]
public partial struct FOpenCVArucoDetectedMarker {
	public int Id;
	public TArray<FVector2D> Corners;
	public FTransform Pose;
}
