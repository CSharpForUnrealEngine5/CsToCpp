#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sent to let the receiver know something is coming. For now only sent from client to server.</summary>
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertPackageTransmissionStartEvent {
	public FGuid TransmissionId;
	public FConcertPackageInfo PackageInfo;
	public ulong PackageNumBytes;
}
