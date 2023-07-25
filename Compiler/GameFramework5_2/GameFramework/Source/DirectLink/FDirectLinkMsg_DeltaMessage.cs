#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_DeltaMessage {
// DirectLinkMsg_DeltaMessage
	public int DestinationStreamPort;
	public short BatchCode;
	public int MessageCode;
	public byte Kind;
	public bool CompressedPayload;
	public TArray<byte> Payload;
}
