#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message broadcasted periodically by the monitor to discover new providers</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageProviderDiscoveryMessage {
	public FStageInstanceDescriptor Descriptor;
}
