#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SharedMemoryMediaSource.h")]
///<summary>Media source for SharedMemory streams.</summary>
public partial class USharedMemoryMediaSource : UMediaSource {
// SharedMemoryMediaSource
	public string UniqueName;
	public ESharedMemoryMediaSourceMode Mode;
	public bool bZeroLatency;
}
