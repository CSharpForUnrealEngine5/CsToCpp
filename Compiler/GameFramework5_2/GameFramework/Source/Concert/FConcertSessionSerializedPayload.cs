#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
