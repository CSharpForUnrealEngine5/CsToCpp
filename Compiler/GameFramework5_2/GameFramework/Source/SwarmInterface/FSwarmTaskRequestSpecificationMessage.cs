#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmTaskRequestSpecificationMessage {
	public FGuid TaskGuid;
	public string Parameters;
	public byte Flags;
	public uint Cost;
	public TArray<string> Dependencies;
}
