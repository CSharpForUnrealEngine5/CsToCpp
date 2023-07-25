#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmJobStateMessage {
// SwarmJobStateMessage
	public FGuid Guid;
	public byte State;
	public string Message;
	public int ExitCode;
	public double RunningTime;
}
