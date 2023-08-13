namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure describing necessary data to record the results of a physics simulation for rigids.</summary>
[CppInclude("GeometryCollection/RecordedTransformTrack.h")]
public partial struct FRecordedFrame {
	public TArray<FTransform> Transforms;
	public TArray<int> TransformIndices;
	public TArray<int> PreviousTransformIndices;
	public TArray<bool> DisabledFlags;
	public TArray<FSolverCollisionData> Collisions;
	public TArray<FSolverBreakingData> Breakings;
	public TSet<FSolverTrailingData> Trailings;
	public float Timestamp;
}
