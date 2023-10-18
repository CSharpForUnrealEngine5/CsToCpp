namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For persistence, every node in a graph is given a unique index.</summary>
[CppInclude("Graph/GraphHandle.h")]
public partial struct FGraphHandle {
	public long UniqueIndex;
	public TWeakObjectPtr<UGraphElement> Element;
}
