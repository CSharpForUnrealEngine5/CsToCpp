namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGStaticMeshSpawner.h")]
public partial class UPCGStaticMeshSpawnerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SetMeshSelectorType</summary>
	public void SetMeshSelectorType(UClass InMeshSelectorType) {}
	///<summary>SetInstancePackerType</summary>
	public void SetInstancePackerType(UClass InInstancePackerType) {}
	///<summary>Defines the method of mesh selection per input data</summary>
	public UClass MeshSelectorType;
	///<summary>MeshSelectorInstance</summary>
	public UPCGMeshSelectorBase MeshSelectorInstance;
	///<summary>Defines the method of custom data packing for spawned (H)ISMCs</summary>
	public UClass InstancePackerType;
	///<summary>InstancePackerInstance</summary>
	public UPCGInstancePackerBase InstancePackerInstance;
	///<summary>Attribute name to store mesh SoftObjectPaths inside if the output pin is connected. Note: Will overwrite existing data if the attribute name already exists.</summary>
	public string OutAttributeName;
	///<summary>Meshes_DEPRECATED</summary>
	public TArray<FPCGStaticMeshSpawnerEntry> Meshes_DEPRECATED;
}
