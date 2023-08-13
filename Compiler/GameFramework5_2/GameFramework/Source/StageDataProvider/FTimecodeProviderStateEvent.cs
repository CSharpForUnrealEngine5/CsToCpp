namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage event to notify of TimecodeProvider state change</summary>
[CppInclude("TimecodeProviderWatchdog.h")]
public partial struct FTimecodeProviderStateEvent {
	public string ProviderName;
	public string ProviderType;
	public FFrameRate FrameRate;
	public ETimecodeProviderSynchronizationState NewState;
}
