#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/HierarchicalInstancedStaticMeshComponent.h")]
public partial struct FClusterNode {
// ClusterNode
	public FVector3f BoundMin;
	public int FirstChild;
	public FVector3f BoundMax;
	public int LastChild;
	public int FirstInstance;
	public int LastInstance;
	public FVector3f MinInstanceScale;
	public FVector3f MaxInstanceScale;
}
