namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/QuicMessagingSettings.h")]
///<summary>Defines the Quic message format available (how the message data is encoded).</summary>
public enum EQuicMessageFormat {
	None=0,
	Json=1,
	TaggedProperty=2,
	CborPlatformEndianness=3,
	CborStandardEndianness=4,
}
