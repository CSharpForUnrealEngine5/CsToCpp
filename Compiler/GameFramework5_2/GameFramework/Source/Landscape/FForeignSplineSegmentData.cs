#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignSplineSegmentData {
// ForeignSplineSegmentData
	public FGuid ModificationKey;
	public TArray<USplineMeshComponent> MeshComponents;
	public TLazyObjectPtr<ULandscapeSplineSegment> Identifier;
}
