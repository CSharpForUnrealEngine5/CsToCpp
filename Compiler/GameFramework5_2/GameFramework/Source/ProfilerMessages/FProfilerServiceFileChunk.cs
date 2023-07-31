#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for copying a file through the network, as well as for synchronization.</summary>
[CppInclude("ProfilerServiceMessages.h")]
public partial struct FProfilerServiceFileChunk {
	public FGuid InstanceId;
	public string Filename;
	public string HexData;
	public TArray<byte> Header;
	public TArray<byte> ChunkHash;
}
