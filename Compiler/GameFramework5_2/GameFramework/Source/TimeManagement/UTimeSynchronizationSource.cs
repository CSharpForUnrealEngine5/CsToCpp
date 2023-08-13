namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for sources to be used for time synchronization.</summary>
[CppInclude("TimeSynchronizationSource.h")]
public partial class UTimeSynchronizationSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not this source should be considered when establishing synchronization.</summary>
	public bool bUseForSynchronization;
	///<summary>An additional offset in frames (relative to this source&#39;s frame rate) that should used.</summary>
	public int FrameOffset;
}
