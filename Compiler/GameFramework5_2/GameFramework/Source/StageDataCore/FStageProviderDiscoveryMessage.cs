#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMessages.h")]
///<summary>Message broadcasted periodically by the monitor to discover new providers</summary>
public partial struct FStageProviderDiscoveryMessage {
// StageProviderDiscoveryMessage
	public FStageInstanceDescriptor Descriptor;
}
