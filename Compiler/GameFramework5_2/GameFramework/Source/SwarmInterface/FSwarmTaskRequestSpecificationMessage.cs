#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmTaskRequestSpecificationMessage {
// SwarmTaskRequestSpecificationMessage
	public FGuid TaskGuid;
	public string Parameters;
	public byte Flags;
	public uint Cost;
	public TArray<string> Dependencies;
}
