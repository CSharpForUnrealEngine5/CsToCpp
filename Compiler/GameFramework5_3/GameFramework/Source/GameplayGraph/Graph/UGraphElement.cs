namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/GraphElement.h")]
public partial class UGraphElement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ElementType</summary>
	public EGraphElementType ElementType;
	///<summary>Will match the UniqueIndex in the UGraphHandle that references this element.</summary>
	public long UniqueIndex;
	///<summary>ParentGraph</summary>
	public TWeakObjectPtr<UGraph> ParentGraph;
}
