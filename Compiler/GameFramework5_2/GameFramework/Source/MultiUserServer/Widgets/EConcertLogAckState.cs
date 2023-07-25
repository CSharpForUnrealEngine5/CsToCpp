#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/Clients/Logging/ConcertLogEntry.h")]
public enum EConcertLogAckState {
	NotNeeded=0,
	Ack=1,
	InProgress=2,
	AckReceived=3,
	AckFailure=4,
}
