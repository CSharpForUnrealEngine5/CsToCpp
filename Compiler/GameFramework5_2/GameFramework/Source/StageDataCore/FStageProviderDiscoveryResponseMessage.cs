#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response to a received discovery message sent by providers</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageProviderDiscoveryResponseMessage {
	public FStageInstanceDescriptor Descriptor;
}
