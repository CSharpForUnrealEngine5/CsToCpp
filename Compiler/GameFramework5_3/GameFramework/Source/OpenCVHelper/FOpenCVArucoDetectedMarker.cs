namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVBlueprintFunctionLibrary.h")]
public partial struct FOpenCVArucoDetectedMarker {
	public int Id;
	public TArray<FVector2D> Corners;
	public FTransform Pose;
}
