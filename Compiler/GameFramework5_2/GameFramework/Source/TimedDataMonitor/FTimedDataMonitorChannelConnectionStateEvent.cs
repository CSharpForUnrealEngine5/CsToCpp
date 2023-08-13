namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial struct FTimedDataMonitorChannelConnectionStateEvent {
	public ETimedDataInputState NewState;
	public string InputName;
	public string ChannelName;
}
