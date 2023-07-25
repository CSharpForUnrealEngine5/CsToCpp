#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenlockWatchdog.h")]
///<summary>Stage event to notify of genlock custom timestep state change</summary>
public partial struct FGenlockStateEvent {
// GenlockStateEvent
	public ECustomTimeStepSynchronizationState NewState;
}
