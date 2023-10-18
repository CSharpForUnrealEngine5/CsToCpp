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
	public FName MessageTypeName;
	public FGuid OriginEndpointId;
	public FGuid DestinationEndpointId;
	public FName CustomPayloadTypename;
	public int CustomPayloadUncompressedByteSize;
	public string StringPayload;
	public FConcertSessionSerializedPayload SerializedPayload;
}
