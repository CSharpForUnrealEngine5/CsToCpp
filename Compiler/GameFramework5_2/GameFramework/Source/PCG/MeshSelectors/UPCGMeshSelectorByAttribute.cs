#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorByAttribute.h")]
public partial class UPCGMeshSelectorByAttribute : UPCGMeshSelectorBase {
	///<summary>AttributeName</summary>
	public string AttributeName;
	///<summary>TemplateDescriptor</summary>
	public FSoftISMComponentDescriptor TemplateDescriptor;
	///<summary>bUseAttributeMaterialOverrides</summary>
	public bool bUseAttributeMaterialOverrides;
	///<summary>MaterialOverrideAttributes</summary>
	public TArray<string> MaterialOverrideAttributes;
	///<summary>bOverrideCollisionProfile_DEPRECATED</summary>
	public bool bOverrideCollisionProfile_DEPRECATED;
	///<summary>CollisionProfile_DEPRECATED</summary>
	public FCollisionProfileName CollisionProfile_DEPRECATED;
	///<summary>MaterialOverrideMode_DEPRECATED</summary>
	public EPCGMeshSelectorMaterialOverrideMode MaterialOverrideMode_DEPRECATED;
	///<summary>bOverrideMaterials_DEPRECATED</summary>
	public bool bOverrideMaterials_DEPRECATED;
	///<summary>MaterialOverrides_DEPRECATED</summary>
	public TArray<TSoftObjectPtr<UMaterialInterface>> MaterialOverrides_DEPRECATED;
	///<summary>Distance at which instances begin to fade.</summary>
	public float CullStartDistance_DEPRECATED;
	///<summary>Distance at which instances are culled. Use 0 to disable.</summary>
	public float CullEndDistance_DEPRECATED;
	///<summary>WorldPositionOffsetDisableDistance_DEPRECATED</summary>
	public int WorldPositionOffsetDisableDistance_DEPRECATED;
}
