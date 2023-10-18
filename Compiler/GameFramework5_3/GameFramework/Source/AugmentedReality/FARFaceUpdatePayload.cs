namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARFaceUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FVector LeftEyePosition;
	public FVector RightEyePosition;
	public FVector LookAtTarget;
}
