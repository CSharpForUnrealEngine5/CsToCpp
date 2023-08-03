#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_BTStopAction.h")]
public partial class UTestBTTask_BTStopAction : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>StopTiming</summary>
	public EBTTestTaskStopTiming StopTiming;
	///<summary>StopAction</summary>
	public EBTTestStopAction StopAction;
	///<summary>LogIndex</summary>
	public int LogIndex;
	///<summary>LogResult</summary>
	public EBTNodeResult LogResult;
}
