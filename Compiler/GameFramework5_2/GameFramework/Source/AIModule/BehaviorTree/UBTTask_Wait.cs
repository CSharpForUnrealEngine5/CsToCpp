#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wait task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_Wait.h")]
public partial class UBTTask_Wait : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>wait time in seconds</summary>
	public float WaitTime;
	///<summary>allows adding random time to wait time</summary>
	public float RandomDeviation;
}
