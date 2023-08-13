namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unique handle that can be used to distinguish timers that have identical delegates.</summary>
[CppInclude("Engine/TimerHandle.h")]
public partial struct FTimerHandle {
	public ulong Handle;
}
