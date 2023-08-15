namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hierarchy of nodes</summary>
[CppInclude("NodeHierarchy.h")]
public partial struct FNodeHierarchyData {
	public TArray<FNodeObject> Nodes;
	public TArray<FTransform> Transforms;
	public TMap<FName,int> NodeNameToIndexMapping;
}
