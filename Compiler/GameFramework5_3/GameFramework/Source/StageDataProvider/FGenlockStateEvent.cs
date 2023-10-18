namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage event to notify of genlock custom timestep state change</summary>
[CppInclude("GenlockWatchdog.h")]
public partial struct FGenlockStateEvent {
	public ECustomTimeStepSynchronizationState NewState;
}
