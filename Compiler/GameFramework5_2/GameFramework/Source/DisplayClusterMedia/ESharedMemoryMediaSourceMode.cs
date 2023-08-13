namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SharedMemoryMediaSource.h")]
///<summary>Mode of operation when receiving data.</summary>
public enum ESharedMemoryMediaSourceMode {
	Framelocked=0,
	Genlocked=1,
	Freerun=2,
}
