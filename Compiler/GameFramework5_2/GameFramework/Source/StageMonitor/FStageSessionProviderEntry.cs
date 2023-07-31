#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Entry corresponding to a provider we are monitoring</summary>
[CppInclude("IStageMonitorSession.h")]
public partial struct FStageSessionProviderEntry {
	public FGuid Identifier;
	public FStageInstanceDescriptor Descriptor;
}
