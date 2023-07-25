#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_ConeCheck.h")]
///<summary>Cone check decorator node.</summary>
public partial class UBTDecorator_ConeCheck : UBTDecorator {
// BTDecorator_ConeCheck
	public float ConeHalfAngle;
	public FBlackboardKeySelector ConeOrigin;
	public FBlackboardKeySelector ConeDirection;
	public FBlackboardKeySelector Observed;
}
