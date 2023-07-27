#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CalibrationPointComponent.h")]
///<summary>One or more instances of this component can be added to an actor (e.g. a static mesh actor blueprint),</summary>
public partial class UCalibrationPointComponent : UProceduralMeshComponent {
// CalibrationPointComponent
	public TMap<string,FVector> SubPoints;
	public bool bVisualizePointsInEditor;
	public float PointVisualizationScale;
	public byte VisualizationShape;
	public  bool GetWorldLocation(string InPointName,FVector OutLocation) { return default; }
	public  bool NamespacedSubpointName(string InSubpointName,string OutNamespacedName) { return default; }
	public  void GetNamespacedPointNames(TArray<string> OutNamespacedNames) {}
	public  void RebuildVertices() {}
}
