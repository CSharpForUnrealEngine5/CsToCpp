#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/BTTask_StopGameplayBehavior.h")]
public partial class UBTTask_StopGameplayBehavior : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>If None (the default) will stop any and all gameplay behaviors instigated by the agent</summary>
	public UClass BehaviorToStop;
}
