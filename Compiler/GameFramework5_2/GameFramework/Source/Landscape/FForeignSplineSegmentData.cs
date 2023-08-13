namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignSplineSegmentData {
	public FGuid ModificationKey;
	public TArray<USplineMeshComponent> MeshComponents;
	public TLazyObjectPtr<ULandscapeSplineSegment> Identifier;
}
