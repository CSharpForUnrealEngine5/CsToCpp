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
	///<summary>MeshSelectorParameters</summary>
	public UPCGMeshSelectorBase MeshSelectorParameters;
	///<summary>Defines the method of custom data packing for spawned (H)ISMCs</summary>
	public UClass InstanceDataPackerType;
	///<summary>InstanceDataPackerParameters</summary>
	public UPCGInstanceDataPackerBase InstanceDataPackerParameters;
	///<summary>Attribute name to store mesh SoftObjectPaths inside if the output pin is connected. Note: Will overwrite existing data if the attribute name already exists.</summary>
	public FName OutAttributeName;
	///<summary>Sets the BoundsMin and BoundsMax attributes of each point to reflect the StaticMesh spawned at its location</summary>
	public bool bApplyMeshBoundsToPoints;
	///<summary>TargetActor</summary>
	public TSoftObjectPtr<AActor> TargetActor;
	///<summary>Meshes_DEPRECATED</summary>
	public TArray<FPCGStaticMeshSpawnerEntry> Meshes_DEPRECATED;
}
