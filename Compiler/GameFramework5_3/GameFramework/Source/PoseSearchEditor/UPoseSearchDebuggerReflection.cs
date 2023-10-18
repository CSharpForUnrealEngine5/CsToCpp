namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reflection UObject being observed in the details view panel of the debugger</summary>
[CppInclude("PoseSearchDebuggerReflection.h")]
public partial class UPoseSearchDebuggerReflection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Time since last PoseSearch</summary>
	public float ElapsedPoseSearchTime;
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
}
