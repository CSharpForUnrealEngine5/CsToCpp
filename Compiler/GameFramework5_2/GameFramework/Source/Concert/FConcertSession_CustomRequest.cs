namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertSession_CustomRequest {
	public FGuid SourceEndpointId;
	public FGuid DestinationEndpointId;
	public FConcertSessionSerializedPayload SerializedPayload;
}
