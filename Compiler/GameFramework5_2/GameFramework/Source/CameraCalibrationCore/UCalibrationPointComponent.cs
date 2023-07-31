#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>One or more instances of this component can be added to an actor (e.g. a static mesh actor blueprint),</summary>
[CppInclude("CalibrationPointComponent.h")]
public partial class UCalibrationPointComponent : UProceduralMeshComponent {
	///<summary>A way to group many points in a single component</summary>
	public TMap<string,FVector> SubPoints;
	///<summary>Draws a visual representation of the calibration points</summary>
	public bool bVisualizePointsInEditor;
	///<summary>Scales up/down the size of the point visualization meshes</summary>
	public float PointVisualizationScale;
	///<summary>Shape used to visualize the calibration (sub)points</summary>
	public ECalibrationPointVisualization VisualizationShape;
	///<summary>Returns the World location of the subpoint (or the component) specified by name</summary>
	public  bool GetWorldLocation(string InPointName,FVector OutLocation) { return default; }
	///<summary>Namespaces the given subpoint name. Does not check that the subpoint exists.</summary>
	public  bool NamespacedSubpointName(string InSubpointName,string OutNamespacedName) { return default; }
	///<summary>Gathers the namespaced names of the subpoints and the component itself.</summary>
	public  void GetNamespacedPointNames(TArray<string> OutNamespacedNames) {}
	///<summary>Rebuilds the point visualization.</summary>
	public  void RebuildVertices() {}
}
