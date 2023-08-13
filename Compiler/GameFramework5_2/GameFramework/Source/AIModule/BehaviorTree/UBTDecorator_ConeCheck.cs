namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cone check decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_ConeCheck.h")]
public partial class UBTDecorator_ConeCheck : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>Angle between cone direction and code cone edge, or a half of the total cone angle</summary>
	public float ConeHalfAngle;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector ConeOrigin;
	///<summary>&quot;None&quot; means &quot;use ConeOrigin&#39;s direction&quot;</summary>
	public FBlackboardKeySelector ConeDirection;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector Observed;
}
