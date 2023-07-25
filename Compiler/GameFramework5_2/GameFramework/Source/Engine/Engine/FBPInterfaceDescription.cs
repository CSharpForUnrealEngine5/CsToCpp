#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Struct containing information about what interfaces are implemented in this blueprint</summary>
public partial struct FBPInterfaceDescription {
// BPInterfaceDescription
	public UClass Interface;
	public TArray<UEdGraph> Graphs;
}
