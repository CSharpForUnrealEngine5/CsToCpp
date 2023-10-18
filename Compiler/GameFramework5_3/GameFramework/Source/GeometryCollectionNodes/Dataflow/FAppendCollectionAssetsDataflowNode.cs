namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description for this node</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FAppendCollectionAssetsDataflowNode {
	public FManagedArrayCollection Collection1;
	public FManagedArrayCollection Collection2;
	public TArray<string> GeometryGroupGuidsOut1;
	public TArray<string> GeometryGroupGuidsOut2;
}
