#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Parallel composite node.</summary>
[CppInclude("BehaviorTree/Composites/BTComposite_SimpleParallel.h")]
public partial class UBTComposite_SimpleParallel : UBTCompositeNode {
	public static UClass StaticClass() {return default;}
	///<summary>how background tree should be handled when main task finishes execution</summary>
	public EBTParallelMode FinishMode;
}
