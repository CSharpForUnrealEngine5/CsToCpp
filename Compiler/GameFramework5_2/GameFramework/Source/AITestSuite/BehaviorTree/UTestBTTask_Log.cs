namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_Log.h")]
public partial class UTestBTTask_Log : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>LogIndex</summary>
	public int LogIndex;
	///<summary>LogFinished</summary>
	public int LogFinished;
	///<summary>ExecutionTicks</summary>
	public int ExecutionTicks;
	///<summary>LogTickIndex</summary>
	public int LogTickIndex;
	///<summary>LogResult</summary>
	public EBTNodeResult LogResult;
}
