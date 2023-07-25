#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HierarchicalInstancedStaticMeshComponent.h")]
///<summary>Due to BulkSerialize we can't edit the struct, so we must deprecated this one and create a new one</summary>
public partial struct FClusterNode_DEPRECATED {
// ClusterNode_DEPRECATED
	public FVector3f BoundMin;
	public int FirstChild;
	public FVector3f BoundMax;
	public int LastChild;
	public int FirstInstance;
	public int LastInstance;
}
