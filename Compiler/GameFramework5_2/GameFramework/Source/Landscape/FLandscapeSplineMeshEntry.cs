#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineSegment.h")]
public partial struct FLandscapeSplineMeshEntry {
// LandscapeSplineMeshEntry
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> MaterialOverrides;
	public bool bCenterH;
	public FVector2D CenterAdjust;
	public bool bScaleToWidth;
	public FVector Scale;
	public LandscapeSplineMeshOrientation Orientation_DEPRECATED;
	public ESplineMeshAxis ForwardAxis;
	public ESplineMeshAxis UpAxis;
}
