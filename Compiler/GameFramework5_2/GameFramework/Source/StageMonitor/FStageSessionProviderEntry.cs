#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IStageMonitorSession.h")]
///<summary>Entry corresponding to a provider we are monitoring</summary>
public partial struct FStageSessionProviderEntry {
// StageSessionProviderEntry
	public FGuid Identifier;
	public FStageInstanceDescriptor Descriptor;
}
