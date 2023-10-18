namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARImageUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public UARCandidateImage DetectedImage;
	public FVector2D EstimatedSize;
}
