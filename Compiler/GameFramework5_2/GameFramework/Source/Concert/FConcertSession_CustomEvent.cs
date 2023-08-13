namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_CustomEvent {
	public FGuid SourceEndpointId;
	public TArray<FGuid> DestinationEndpointIds;
	public FConcertSessionSerializedPayload SerializedPayload;
}
