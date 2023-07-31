#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Due to BulkSerialize we can&#39;t edit the struct, so we must deprecated this one and create a new one</summary>
[CppInclude("Components/HierarchicalInstancedStaticMeshComponent.h")]
public partial struct FClusterNode_DEPRECATED {
	public FVector3f BoundMin;
	public int FirstChild;
	public FVector3f BoundMax;
	public int LastChild;
	public int FirstInstance;
	public int LastInstance;
}
