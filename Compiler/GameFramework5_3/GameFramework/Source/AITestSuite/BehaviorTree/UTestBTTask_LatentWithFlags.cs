namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_LatentWithFlags.h")]
public partial class UTestBTTask_LatentWithFlags : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>LogIndexExecuteStart</summary>
	public int LogIndexExecuteStart;
	///<summary>LogIndexExecuting</summary>
	public int LogIndexExecuting;
	///<summary>LogIndexExecuteFinish</summary>
	public int LogIndexExecuteFinish;
	///<summary>LogIndexAbortStart</summary>
	public int LogIndexAbortStart;
	///<summary>LogIndexAborting</summary>
	public int LogIndexAborting;
	///<summary>LogIndexAbortFinish</summary>
	public int LogIndexAbortFinish;
	///<summary>Num of ticks before &#39;execute start&#39; and `set execute flag` and then the same num of ticks before `execute finish`</summary>
	public int ExecuteHalfTicks;
	///<summary>Num of ticks before &#39;abort start&#39; and `set abort flag` and then the same num of ticks before `abort finish`</summary>
	public int AbortHalfTicks;
	///<summary>KeyNameExecute</summary>
	public FName KeyNameExecute;
	///<summary>KeyNameAbort</summary>
	public FName KeyNameAbort;
	///<summary>ChangeFlagBehavior</summary>
	public EBTTestChangeFlagBehavior ChangeFlagBehavior;
	///<summary>LogResult</summary>
	public EBTNodeResult LogResult;
}
