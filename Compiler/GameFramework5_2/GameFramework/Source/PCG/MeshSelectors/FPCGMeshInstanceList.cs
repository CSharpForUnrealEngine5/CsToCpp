#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorBase.h")]
public partial struct FPCGMeshInstanceList {
	public FSoftISMComponentDescriptor Descriptor;
	public TArray<FTransform> Instances;
	public TArray<long> InstancesMetadataEntry;
}
