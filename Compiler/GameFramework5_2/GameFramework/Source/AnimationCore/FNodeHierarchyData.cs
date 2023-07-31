#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hierarchy of nodes</summary>
[CppInclude("NodeHierarchy.h")]
public partial struct FNodeHierarchyData {
	public TArray<FNodeObject> Nodes;
	public TArray<FTransform> Transforms;
	public TMap<string,int> NodeNameToIndexMapping;
}
