#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorBase.h")]
public partial struct FPCGMeshInstanceList {
// PCGMeshInstanceList
	public FSoftISMComponentDescriptor Descriptor;
	public TArray<FTransform> Instances;
	public TArray<long> InstancesMetadataEntry;
}
