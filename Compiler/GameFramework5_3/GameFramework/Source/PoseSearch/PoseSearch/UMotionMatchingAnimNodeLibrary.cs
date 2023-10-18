namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations that can be run on a Motion Matching node via Anim Node Functions such as &quot;On Become Relevant&quot; and &quot;On Update&quot;.</summary>
[CppInclude("PoseSearch/MotionMatchingAnimNodeLibrary.h")]
public partial class UMotionMatchingAnimNodeLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a motion matching node context from an anim node context</summary>
	public static FMotionMatchingAnimNodeReference ConvertToMotionMatchingNode(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a motion matching node context from an anim node context (pure)</summary>
	public static void ConvertToMotionMatchingNodePure(FAnimNodeReference Node,FMotionMatchingAnimNodeReference MotionMatchingNode,bool Result) {}
	///<summary>Set the database to search on the motion matching node. This overrides the Database property on the motion matching node.</summary>
	public static void SetDatabaseToSearch(FMotionMatchingAnimNodeReference MotionMatchingNode,UPoseSearchDatabase Database,bool bForceInterruptIfNew) {}
	///<summary>Set the database to search on the motion matching node. This overrides the Database property on the motion matching node.</summary>
	public static void SetDatabasesToSearch(FMotionMatchingAnimNodeReference MotionMatchingNode,TArray<UPoseSearchDatabase> Databases,bool bForceInterruptIfNew) {}
	///<summary>Clear the effects of SetDatabaseToSearch/SetDatabasesToSearch and resume searching the Database property on the motion matching node.</summary>
	public static void ResetDatabasesToSearch(FMotionMatchingAnimNodeReference MotionMatchingNode,bool bForceInterrupt) {}
	///<summary>Ignore the continuing pose (the current clip that&#39;s playing) and force a new search.</summary>
	public static void ForceInterruptNextUpdate(FMotionMatchingAnimNodeReference MotionMatchingNode) {}
}
