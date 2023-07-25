#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARFaceUpdatePayload {
// ARFaceUpdatePayload
	public FARSessionPayload SessionPayload;
	public FVector LeftEyePosition;
	public FVector RightEyePosition;
	public FVector LookAtTarget;
}
