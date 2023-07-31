#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RunBehavior task allows pushing subtrees on execution stack.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_RunBehavior.h")]
public partial class UBTTask_RunBehavior : UBTTaskNode {
	///<summary>behavior to run</summary>
	public UBehaviorTree BehaviorAsset;
}
