#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/RecordedTransformTrack.h")]
///<summary>Structure describing necessary data to record the results of a physics simulation for rigids.</summary>
public partial struct FRecordedFrame {
// RecordedFrame
	public TArray<FTransform> Transforms;
	public TArray<int> TransformIndices;
	public TArray<int> PreviousTransformIndices;
	public TArray<bool> DisabledFlags;
	public TArray<FSolverCollisionData> Collisions;
	public TArray<FSolverBreakingData> Breakings;
	public TSet<FSolverTrailingData> Trailings;
	public float Timestamp;
}
