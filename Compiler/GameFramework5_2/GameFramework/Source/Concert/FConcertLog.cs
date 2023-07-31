#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportEvents.h")]
public partial struct FConcertLog {
	public ulong Frame;
	public FGuid MessageId;
	public ushort MessageOrderIndex;
	public ushort ChannelId;
	public FDateTime Timestamp;
	public EConcertLogMessageAction MessageAction;
	public string MessageTypeName;
	public FGuid OriginEndpointId;
	public FGuid DestinationEndpointId;
	public string CustomPayloadTypename;
	public int CustomPayloadUncompressedByteSize;
	public string StringPayload;
	public FConcertSessionSerializedPayload SerializedPayload;
}
