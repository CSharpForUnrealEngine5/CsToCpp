#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARImageUpdatePayload {
// ARImageUpdatePayload
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public UARCandidateImage DetectedImage;
	public FVector2D EstimatedSize;
}
