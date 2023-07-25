#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeSynchronizationSource.h")]
///<summary>Base class for sources to be used for time synchronization.</summary>
public partial class UTimeSynchronizationSource : UObject {
// TimeSynchronizationSource
	public bool bUseForSynchronization;
	public int FrameOffset;
}
