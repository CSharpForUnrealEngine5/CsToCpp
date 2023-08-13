namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Media source for SharedMemory streams.</summary>
[CppInclude("SharedMemoryMediaSource.h")]
public partial class USharedMemoryMediaSource : UMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Shared memory will be found by using this name. Should match the media output setting.</summary>
	public string UniqueName;
	///<summary>Mode of operation when receiving data.</summary>
	public ESharedMemoryMediaSourceMode Mode;
	///<summary>Zero latency option to wait for the cross gpu texture rendered on the same frame. May adversely affect fps. Only applicable in Framelocked mode.</summary>
	public bool bZeroLatency;
}
