namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmJobStateMessage {
	public FGuid Guid;
	public byte State;
	public string Message;
	public int ExitCode;
	public double RunningTime;
}
