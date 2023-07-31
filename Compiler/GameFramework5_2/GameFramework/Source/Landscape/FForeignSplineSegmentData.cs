#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignSplineSegmentData {
	public FGuid ModificationKey;
	public TArray<USplineMeshComponent> MeshComponents;
	public TLazyObjectPtr<ULandscapeSplineSegment> Identifier;
}
