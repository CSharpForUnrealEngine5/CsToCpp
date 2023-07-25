#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_DoesPathExist.h")]
///<summary>Cooldown decorator node.</summary>
public partial class UBTDecorator_DoesPathExist : UBTDecorator {
// BTDecorator_DoesPathExist
	public FBlackboardKeySelector BlackboardKeyA;
	public FBlackboardKeySelector BlackboardKeyB;
	public bool bUseSelf;
	public byte PathQueryType;
	public UClass FilterClass;
}
