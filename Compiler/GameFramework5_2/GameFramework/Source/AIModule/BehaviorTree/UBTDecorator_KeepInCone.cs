namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooldown decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_KeepInCone.h")]
public partial class UBTDecorator_KeepInCone : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>max allowed time for execution of underlying node</summary>
	public float ConeHalfAngle;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector ConeOrigin;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector Observed;
	///<summary>deprecated, set value of ConeOrigin on initialization</summary>
	public bool bUseSelfAsOrigin;
	///<summary>deprecated, set value of Observed on initialization</summary>
	public bool bUseSelfAsObserved;
}
