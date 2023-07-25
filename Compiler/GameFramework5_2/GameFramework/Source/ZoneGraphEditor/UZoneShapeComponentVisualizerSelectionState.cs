#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneShapeComponentVisualizer.h")]
///<summary>Selection state data that will be captured by scoped transactions.</summary>
public partial class UZoneShapeComponentVisualizerSelectionState : UObject {
// ZoneShapeComponentVisualizerSelectionState
	public FComponentPropertyPath ShapePropertyPath;
	public TSet<int> SelectedPoints;
	public int LastPointIndexSelected;
	public int SelectedSegmentIndex;
	public FVector SelectedSegmentPoint;
	public float SelectedSegmentT;
	public int SelectedControlPoint;
	public FZoneShapeControlPointType SelectedControlPointType;
}
