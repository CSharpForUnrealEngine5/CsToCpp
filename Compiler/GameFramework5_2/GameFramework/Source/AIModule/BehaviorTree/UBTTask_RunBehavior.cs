namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RunBehavior task allows pushing subtrees on execution stack.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_RunBehavior.h")]
public partial class UBTTask_RunBehavior : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>behavior to run</summary>
	public UBehaviorTree BehaviorAsset;
}
