#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchDebuggerReflection.h")]
///<summary>Reflection UObject being observed in the details view panel of the debugger</summary>
public partial class UPoseSearchDebuggerReflection : UObject {
// PoseSearchDebuggerReflection
	public string CurrentDatabaseName;
	public float ElapsedPoseJumpTime;
	public string AssetPlayerAssetName;
	public float AssetPlayerTime;
	public float LastDeltaTime;
	public float SimLinearVelocity;
	public float SimAngularVelocity;
	public float AnimLinearVelocity;
	public float AnimAngularVelocity;
	public FPoseSearchDebuggerFeatureDrawOptions QueryDrawOptions;
	public FPoseSearchDebuggerFeatureDrawOptions SelectedPoseDrawOptions;
	public bool bDrawActiveSkeleton;
	public bool bDrawSelectedSkeleton;
	public TArray<float> QueryPoseVector;
	public TArray<float> ActivePoseVector;
	public TArray<float> SelectedPoseVector;
	public TArray<float> CostVector;
}
