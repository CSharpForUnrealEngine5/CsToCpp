#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_LatentWithFlags.h")]
public partial class UTestBTTask_LatentWithFlags : UBTTaskNode {
// TestBTTask_LatentWithFlags
	public int LogIndexExecuteStart;
	public int LogIndexExecuting;
	public int LogIndexExecuteFinish;
	public int LogIndexAbortStart;
	public int LogIndexAborting;
	public int LogIndexAbortFinish;
	public int ExecuteHalfTicks;
	public int AbortHalfTicks;
	public string KeyNameExecute;
	public string KeyNameAbort;
	public byte LogResult;
}
