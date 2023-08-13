namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooldown decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_DoesPathExist.h")]
public partial class UBTDecorator_DoesPathExist : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKeyA;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKeyB;
	///<summary>deprecated, set value of blackboard key A on initialization</summary>
	public bool bUseSelf;
	///<summary>PathQueryType</summary>
	public EPathExistanceQueryType PathQueryType;
	///<summary>&quot;None&quot; will result in default filter being used</summary>
	public UClass FilterClass;
}
