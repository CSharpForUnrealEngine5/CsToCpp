#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraRig_Rail.h")]
public partial class ACameraRig_Rail : AActor {
// CameraRig_Rail
	public float CurrentPositionOnRail;
	public bool bLockOrientationToRail;
	public bool bShowRailVisualization;
	public float PreviewMeshScale;
	public UObject GetRailSplineComponent() { return default; }
	public USceneComponent TransformComponent;
	public USplineComponent RailSplineComponent;
	public USceneComponent RailCameraMount;
	public USplineMeshComponent PreviewMesh_Rail;
	public TArray<USplineMeshComponent> PreviewRailMeshSegments;
	public UStaticMesh PreviewRailStaticMesh;
	public UStaticMeshComponent PreviewMesh_Mount;
}
