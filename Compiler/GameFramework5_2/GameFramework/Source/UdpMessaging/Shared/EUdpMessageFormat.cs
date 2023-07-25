#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/UdpMessagingSettings.h")]
///<summary>Defines the UDP message format available (how the message data is encoded).</summary>
public enum EUdpMessageFormat {
	None=0,
	Json=1,
	TaggedProperty=2,
	CborPlatformEndianness=3,
	CborStandardEndianness=4,
}
