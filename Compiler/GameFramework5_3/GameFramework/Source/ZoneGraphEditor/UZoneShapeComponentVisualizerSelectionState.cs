namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selection state data that will be captured by scoped transactions.</summary>
[CppInclude("ZoneShapeComponentVisualizer.h")]
public partial class UZoneShapeComponentVisualizerSelectionState : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Property path from the parent actor to the component</summary>
	public FComponentPropertyPath ShapePropertyPath;
	///<summary>Index of keys we have selected</summary>
	public TSet<int> SelectedPoints;
	///<summary>Index of the last key we selected</summary>
	public int LastPointIndexSelected;
	///<summary>Index of segment we have selected</summary>
	public int SelectedSegmentIndex;
	///<summary>Position on selected segment</summary>
	public FVector SelectedSegmentPoint;
	///<summary>Interpolation value along the selected segment</summary>
	public float SelectedSegmentT;
	///<summary>Index of tangent handle we have selected</summary>
	public int SelectedControlPoint;
	///<summary>The type of the selected tangent handle</summary>
	public FZoneShapeControlPointType SelectedControlPointType;
}
