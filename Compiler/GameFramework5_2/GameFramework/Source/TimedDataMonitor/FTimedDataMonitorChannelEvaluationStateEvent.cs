namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial struct FTimedDataMonitorChannelEvaluationStateEvent {
	public ETimedDataMonitorEvaluationState NewState;
	public string InputName;
	public string ChannelName;
}
