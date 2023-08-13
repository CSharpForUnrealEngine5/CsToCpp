namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_DeltaMessage {
	public int DestinationStreamPort;
	public short BatchCode;
	public int MessageCode;
	public byte Kind;
	public bool CompressedPayload;
	public TArray<byte> Payload;
}
