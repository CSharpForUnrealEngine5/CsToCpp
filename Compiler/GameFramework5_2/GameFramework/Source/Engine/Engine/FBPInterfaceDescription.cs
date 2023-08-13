namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing information about what interfaces are implemented in this blueprint</summary>
[CppInclude("Engine/Blueprint.h")]
public partial struct FBPInterfaceDescription {
	public UClass Interface;
	public TArray<UEdGraph> Graphs;
}
