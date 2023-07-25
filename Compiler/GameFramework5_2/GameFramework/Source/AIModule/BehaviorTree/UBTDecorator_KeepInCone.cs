#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_KeepInCone.h")]
///<summary>Cooldown decorator node.</summary>
public partial class UBTDecorator_KeepInCone : UBTDecorator {
// BTDecorator_KeepInCone
	public float ConeHalfAngle;
	public FBlackboardKeySelector ConeOrigin;
	public FBlackboardKeySelector Observed;
	public bool bUseSelfAsOrigin;
	public bool bUseSelfAsObserved;
}
