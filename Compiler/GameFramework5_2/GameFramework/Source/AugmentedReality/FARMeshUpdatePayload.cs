#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARMeshUpdatePayload {
// ARMeshUpdatePayload
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public EARObjectClassification ObjectClassification;
}
