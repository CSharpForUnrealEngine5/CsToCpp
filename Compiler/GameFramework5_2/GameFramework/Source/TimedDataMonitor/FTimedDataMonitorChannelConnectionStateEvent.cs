#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial struct FTimedDataMonitorChannelConnectionStateEvent {
// TimedDataMonitorChannelConnectionStateEvent
	public ETimedDataInputState NewState;
	public string InputName;
	public string ChannelName;
}
