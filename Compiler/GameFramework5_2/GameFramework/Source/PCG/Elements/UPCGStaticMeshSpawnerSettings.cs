#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGStaticMeshSpawner.h")]
public partial class UPCGStaticMeshSpawnerSettings : UPCGSettings {
// PCGStaticMeshSpawnerSettings
	public  void SetMeshSelectorType(UClass InMeshSelectorType) {}
	public  void SetInstancePackerType(UClass InInstancePackerType) {}
	public UClass MeshSelectorType;
	public UPCGMeshSelectorBase MeshSelectorInstance;
	public UClass InstancePackerType;
	public UPCGInstancePackerBase InstancePackerInstance;
	public string OutAttributeName;
	public TArray<FPCGStaticMeshSpawnerEntry> Meshes_DEPRECATED;
}
