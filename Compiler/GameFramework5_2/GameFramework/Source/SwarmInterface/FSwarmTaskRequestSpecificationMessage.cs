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
