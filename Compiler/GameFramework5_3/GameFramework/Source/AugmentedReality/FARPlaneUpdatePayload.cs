namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARPlaneUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public FVector Center;
	public FVector Extents;
	public TArray<FVector> BoundaryVertices;
	public EARObjectClassification ObjectClassification;
}
