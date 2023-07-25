#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_CustomEvent {
// ConcertSession_CustomEvent
	public FGuid SourceEndpointId;
	public TArray<FGuid> DestinationEndpointIds;
	public FConcertSessionSerializedPayload SerializedPayload;
}
