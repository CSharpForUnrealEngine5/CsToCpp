#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProfilerServiceMessages.h")]
///<summary>Implements a message for copying a file through the network, as well as for synchronization.</summary>
public partial struct FProfilerServiceFileChunk {
// ProfilerServiceFileChunk
	public FGuid InstanceId;
	public string Filename;
	public string HexData;
	public TArray<byte> Header;
	public TArray<byte> ChunkHash;
}
