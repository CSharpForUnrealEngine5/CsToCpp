namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_HaveListMessage {
	public int SourceStreamPort;
	public int SyncCycle;
	public int MessageCode;
	public byte Kind;
	public TArray<byte> Payload;
	public TArray<int> NodeIds;
	public TArray<int> Hashes;
}
