namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULandscapeSplinesComponent</summary>
[CppInclude("LandscapeSplinesComponent.h")]
public partial class ULandscapeSplinesComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Resolution of the spline, in distance per point</summary>
	public float SplineResolution;
	///<summary>Color to use to draw the splines</summary>
	public FColor SplineColor;
	///<summary>Sprite used to draw control points</summary>
	public UTexture2D ControlPointSprite;
	///<summary>Mesh used to draw splines that have no mesh</summary>
	public UStaticMesh SplineEditorMesh;
	///<summary>Whether we are in-editor and showing spline editor meshes</summary>
	public bool bShowSplineEditorMesh;
	///<summary>ControlPoints</summary>
	public TArray<ULandscapeSplineControlPoint> ControlPoints;
	///<summary>Segments</summary>
	public TArray<ULandscapeSplineSegment> Segments;
	///<summary>Serialized</summary>
	public TMap<TSoftObjectPtr<UWorld>,FForeignWorldSplineData> ForeignWorldSplineDataMap;
	///<summary>References to components owned by landscape splines in other levels</summary>
	public TArray<UMeshComponent> CookedForeignMeshComponents;
	///<summary>Get a list of spline mesh components representing this landscape spline (Editor only)</summary>
	public TArray<USplineMeshComponent> GetSplineMeshComponents() { return default; }
}
