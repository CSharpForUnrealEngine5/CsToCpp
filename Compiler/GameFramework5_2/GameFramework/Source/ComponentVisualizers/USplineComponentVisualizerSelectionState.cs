#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineComponentVisualizer.h")]
///<summary>Selection state data that will be captured by scoped transactions.</summary>
public partial class USplineComponentVisualizerSelectionState : UObject {
// SplineComponentVisualizerSelectionState
	public FComponentPropertyPath SplinePropertyPath;
	public TSet<int> SelectedKeys;
	public int LastKeyIndexSelected;
	public int SelectedSegmentIndex;
	public int SelectedTangentHandle;
	public ESelectedTangentHandle SelectedTangentHandleType;
	public FVector SelectedSplinePosition;
	public FQuat CachedRotation;
}
