#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimUtilities.h")]
public partial class UContextualAnimUtilities : UBlueprintFunctionLibrary {
// ContextualAnimUtilities
	public void BP_DrawDebugPose(UObject WorldContextObject,UObject Animation,float Time,FTransform LocalToWorldTransform,FLinearColor Color,float LifeTime,float Thickness) {}
	public bool BP_CreateContextualAnimSceneBindings(UObject SceneAsset,TMap<string,FContextualAnimSceneBindingContext> Params,FContextualAnimSceneBindings OutBindings) { return default; }
	public bool BP_CreateContextualAnimSceneBindingsForTwoActors(UObject SceneAsset,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Secondary,FContextualAnimSceneBindings OutBindings) { return default; }
	public void BP_Montage_GetSectionStartAndEndTime(UObject Montage,int SectionIndex,float OutStartTime,float OutEndTime) {}
	public float BP_Montage_GetSectionTimeLeftFromPos(UObject Montage,float Position) { return default; }
	public float BP_Montage_GetSectionLength(UObject Montage,int SectionIndex) { return default; }
	public void BP_SceneBindings_CalculateAnimSetPivots(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimSetPivot> OutPivots) {}
	public void BP_SceneBindings_AddOrUpdateWarpTargetsForBindings(FContextualAnimSceneBindings Bindings) {}
	public TArray<FContextualAnimSceneBinding> BP_SceneBindings_GetBindings(FContextualAnimSceneBindings Bindings) { return default; }
	public FContextualAnimSceneBinding BP_SceneBindings_GetBindingByRole(FContextualAnimSceneBindings Bindings,string Role) { return default; }
	public FContextualAnimSceneBinding BP_SceneBindings_GetBindingByActor(FContextualAnimSceneBindings Bindings,UObject Actor) { return default; }
	public UObject BP_SceneBinding_GetAnimationFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	public string BP_SceneBinding_GetRoleFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	public UObject BP_SceneBindings_GetSceneAsset(FContextualAnimSceneBindings Bindings) { return default; }
	public void BP_SceneBindings_GetSectionAndAnimSetIndices(FContextualAnimSceneBindings Bindings,int SectionIdx,int AnimSetIdx) {}
	public FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole(FContextualAnimSceneBindings Bindings,string Role,string RelativeToRole,float Time) { return default; }
	public FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToPivot(FContextualAnimSceneBindings Bindings,string Role,FContextualAnimSetPivot Pivot,float Time) { return default; }
	public FTransform BP_SceneBindings_GetAlignmentTransformFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,FContextualAnimSetPivot Pivot) { return default; }
	public FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActor(UObject Actor) { return default; }
	public FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActorWithExternalTransform(UObject Actor,FTransform ExternalTransform) { return default; }
	public UObject BP_SceneBindingContext_GetActor(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public FTransform BP_SceneBindingContext_GetTransform(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public FVector BP_SceneBindingContext_GetVelocity(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public UObject BP_SceneBinding_GetActor(FContextualAnimSceneBinding Binding) { return default; }
	public UObject BP_SceneBinding_GetSkeletalMesh(FContextualAnimSceneBinding Binding) { return default; }
}
