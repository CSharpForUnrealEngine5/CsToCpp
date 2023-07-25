#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
///<summary>Sent to let the receiver know something is coming. For now only sent from client to server.</summary>
public partial struct FConcertPackageTransmissionStartEvent {
// ConcertPackageTransmissionStartEvent
	public FGuid TransmissionId;
	public FConcertPackageInfo PackageInfo;
	public ulong PackageNumBytes;
}
