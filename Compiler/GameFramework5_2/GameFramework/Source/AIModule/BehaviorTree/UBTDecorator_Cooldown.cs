#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cooldown decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_Cooldown.h")]
public partial class UBTDecorator_Cooldown : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>max allowed time for execution of underlying node</summary>
	public float CoolDownTime;
}
