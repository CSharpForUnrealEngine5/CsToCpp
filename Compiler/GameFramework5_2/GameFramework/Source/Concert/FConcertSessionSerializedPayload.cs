namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
public partial struct FConcertSessionSerializedPayload {
	public string PayloadTypeName;
	public EConcertPayloadSerializationMethod SerializationMethod;
	public EConcertCompressionDetails PayloadCompressionDetails;
	public int PayloadSize;
	public FConcertByteArray PayloadBytes;
}
