#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_CustomRequest {
// ConcertSession_CustomRequest
	public FGuid SourceEndpointId;
	public FGuid DestinationEndpointId;
	public FConcertSessionSerializedPayload SerializedPayload;
}
