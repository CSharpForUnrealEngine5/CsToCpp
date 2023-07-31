#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial struct FTimedDataMonitorChannelEvaluationStateEvent {
	public ETimedDataMonitorEvaluationState NewState;
	public string InputName;
	public string ChannelName;
}
