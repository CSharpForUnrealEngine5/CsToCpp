#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selection state data that will be captured by scoped transactions.</summary>
[CppInclude("SplineComponentVisualizer.h")]
public partial class USplineComponentVisualizerSelectionState : UObject {
	///<summary>Property path from the parent actor to the component</summary>
	public FComponentPropertyPath SplinePropertyPath;
	///<summary>Indices of keys we have selected</summary>
	public TSet<int> SelectedKeys;
	///<summary>Index of the last key we selected</summary>
	public int LastKeyIndexSelected;
	///<summary>Index of segment we have selected</summary>
	public int SelectedSegmentIndex;
	///<summary>Index of tangent handle we have selected</summary>
	public int SelectedTangentHandle;
	///<summary>The type of the selected tangent handle</summary>
	public ESelectedTangentHandle SelectedTangentHandleType;
	///<summary>Position on spline we have selected</summary>
	public FVector SelectedSplinePosition;
	///<summary>Cached rotation for this point</summary>
	public FQuat CachedRotation;
}
