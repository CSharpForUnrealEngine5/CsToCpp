#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorByAttribute.h")]
public partial class UPCGMeshSelectorByAttribute : UPCGMeshSelectorBase {
// PCGMeshSelectorByAttribute
	public string AttributeName;
	public FSoftISMComponentDescriptor TemplateDescriptor;
	public bool bUseAttributeMaterialOverrides;
	public TArray<string> MaterialOverrideAttributes;
	public bool bOverrideCollisionProfile_DEPRECATED;
	public FCollisionProfileName CollisionProfile_DEPRECATED;
	public EPCGMeshSelectorMaterialOverrideMode MaterialOverrideMode_DEPRECATED;
	public bool bOverrideMaterials_DEPRECATED;
	public TArray<TSoftObjectPtr<UMaterialInterface>> MaterialOverrides_DEPRECATED;
	public float CullStartDistance_DEPRECATED;
	public float CullEndDistance_DEPRECATED;
	public int WorldPositionOffsetDisableDistance_DEPRECATED;
}
