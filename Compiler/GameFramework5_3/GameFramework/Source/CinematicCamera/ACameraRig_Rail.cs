namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraRig_Rail.h")]
public partial class ACameraRig_Rail : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Defines current position of the mount point along the rail, in terms of normalized distance from the beginning of the rail.</summary>
	public float CurrentPositionOnRail;
	///<summary>Determines whether the orientation of the mount should be in the direction of the rail.</summary>
	public bool bLockOrientationToRail;
	///<summary>Determines whether or not to show the rail mesh preview.</summary>
	public bool bShowRailVisualization;
	///<summary>Determines the scale of the rail mesh preview</summary>
	public float PreviewMeshScale;
	///<summary>Returns the spline component that defines the rail path</summary>
	public USplineComponent GetRailSplineComponent() { return default; }
	///<summary>Root component to give the whole actor a transform.</summary>
	public USceneComponent TransformComponent;
	///<summary>Spline component to define the rail path.</summary>
	public USplineComponent RailSplineComponent;
	///<summary>Component to define the attach point for cameras. Moves along the rail.</summary>
	public USceneComponent RailCameraMount;
	///<summary>Preview meshes for visualization</summary>
	public USplineMeshComponent PreviewMesh_Rail;
	///<summary>PreviewRailMeshSegments</summary>
	public TArray<USplineMeshComponent> PreviewRailMeshSegments;
	///<summary>PreviewRailStaticMesh</summary>
	public UStaticMesh PreviewRailStaticMesh;
	///<summary>PreviewMesh_Mount</summary>
	public UStaticMeshComponent PreviewMesh_Mount;
}
