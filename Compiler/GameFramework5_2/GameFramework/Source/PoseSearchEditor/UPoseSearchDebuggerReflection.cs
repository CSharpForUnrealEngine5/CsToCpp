#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reflection UObject being observed in the details view panel of the debugger</summary>
[CppInclude("PoseSearchDebuggerReflection.h")]
public partial class UPoseSearchDebuggerReflection : UObject {
	///<summary>CurrentDatabaseName</summary>
	public string CurrentDatabaseName;
	///<summary>Time since last PoseSearch jump</summary>
	public float ElapsedPoseJumpTime;
	///<summary>AssetPlayerAssetName</summary>
	public string AssetPlayerAssetName;
	///<summary>AssetPlayerTime</summary>
	public float AssetPlayerTime;
	///<summary>LastDeltaTime</summary>
	public float LastDeltaTime;
	///<summary>SimLinearVelocity</summary>
	public float SimLinearVelocity;
	///<summary>SimAngularVelocity</summary>
	public float SimAngularVelocity;
	///<summary>AnimLinearVelocity</summary>
	public float AnimLinearVelocity;
	///<summary>AnimAngularVelocity</summary>
	public float AnimAngularVelocity;
	///<summary>QueryDrawOptions</summary>
	public FPoseSearchDebuggerFeatureDrawOptions QueryDrawOptions;
	///<summary>SelectedPoseDrawOptions</summary>
	public FPoseSearchDebuggerFeatureDrawOptions SelectedPoseDrawOptions;
	///<summary>bDrawActiveSkeleton</summary>
	public bool bDrawActiveSkeleton;
	///<summary>bDrawSelectedSkeleton</summary>
	public bool bDrawSelectedSkeleton;
	///<summary>QueryPoseVector</summary>
	public TArray<float> QueryPoseVector;
	///<summary>ActivePoseVector</summary>
	public TArray<float> ActivePoseVector;
	///<summary>SelectedPoseVector</summary>
	public TArray<float> SelectedPoseVector;
	///<summary>CostVector</summary>
	public TArray<float> CostVector;
}
