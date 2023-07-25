#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
///<summary>ULandscapeSplinesComponent</summary>
public partial class ULandscapeSplinesComponent : UPrimitiveComponent {
// LandscapeSplinesComponent
	public float SplineResolution;
	public FColor SplineColor;
	public UTexture2D ControlPointSprite;
	public UStaticMesh SplineEditorMesh;
	public bool bShowSplineEditorMesh;
	public TArray<ULandscapeSplineControlPoint> ControlPoints;
	public TArray<ULandscapeSplineSegment> Segments;
	public TMap<TSoftObjectPtr<UWorld>,FForeignWorldSplineData> ForeignWorldSplineDataMap;
	public TArray<UMeshComponent> CookedForeignMeshComponents;
	public TArray<UObject> GetSplineMeshComponents() { return default; }
}
