namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARMeshUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public EARObjectClassification ObjectClassification;
}
