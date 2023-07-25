#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NodeHierarchy.h")]
///<summary>Hierarchy of nodes</summary>
public partial struct FNodeHierarchyData {
// NodeHierarchyData
	public TArray<FNodeObject> Nodes;
	public TArray<FTransform> Transforms;
	public TMap<string,int> NodeNameToIndexMapping;
}
