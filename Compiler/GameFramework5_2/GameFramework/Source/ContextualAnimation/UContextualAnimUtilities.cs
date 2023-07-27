#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimUtilities.h")]
public partial class UContextualAnimUtilities : UBlueprintFunctionLibrary {
// ContextualAnimUtilities
	public static void BP_DrawDebugPose(UObject WorldContextObject,UAnimSequenceBase Animation,float Time,FTransform LocalToWorldTransform,FLinearColor Color,float LifeTime,float Thickness) {}
	public static bool BP_CreateContextualAnimSceneBindings(UContextualAnimSceneAsset SceneAsset,TMap<string,FContextualAnimSceneBindingContext> Params,FContextualAnimSceneBindings OutBindings) { return default; }
	public static bool BP_CreateContextualAnimSceneBindingsForTwoActors(UContextualAnimSceneAsset SceneAsset,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Secondary,FContextualAnimSceneBindings OutBindings) { return default; }
	public static void BP_Montage_GetSectionStartAndEndTime(UAnimMontage Montage,int SectionIndex,float OutStartTime,float OutEndTime) {}
	public static float BP_Montage_GetSectionTimeLeftFromPos(UAnimMontage Montage,float Position) { return default; }
	public static float BP_Montage_GetSectionLength(UAnimMontage Montage,int SectionIndex) { return default; }
	public static void BP_SceneBindings_CalculateAnimSetPivots(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimSetPivot> OutPivots) {}
	public static void BP_SceneBindings_AddOrUpdateWarpTargetsForBindings(FContextualAnimSceneBindings Bindings) {}
	public static TArray<FContextualAnimSceneBinding> BP_SceneBindings_GetBindings(FContextualAnimSceneBindings Bindings) { return default; }
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByRole(FContextualAnimSceneBindings Bindings,string Role) { return default; }
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByActor(FContextualAnimSceneBindings Bindings,AActor Actor) { return default; }
	public static UAnimSequenceBase BP_SceneBinding_GetAnimationFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	public static string BP_SceneBinding_GetRoleFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	public static UContextualAnimSceneAsset BP_SceneBindings_GetSceneAsset(FContextualAnimSceneBindings Bindings) { return default; }
	public static void BP_SceneBindings_GetSectionAndAnimSetIndices(FContextualAnimSceneBindings Bindings,int SectionIdx,int AnimSetIdx) {}
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole(FContextualAnimSceneBindings Bindings,string Role,string RelativeToRole,float Time) { return default; }
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToPivot(FContextualAnimSceneBindings Bindings,string Role,FContextualAnimSetPivot Pivot,float Time) { return default; }
	public static FTransform BP_SceneBindings_GetAlignmentTransformFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,FContextualAnimSetPivot Pivot) { return default; }
	public static FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActor(AActor Actor) { return default; }
	public static FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActorWithExternalTransform(AActor Actor,FTransform ExternalTransform) { return default; }
	public static AActor BP_SceneBindingContext_GetActor(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public static FTransform BP_SceneBindingContext_GetTransform(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public static FVector BP_SceneBindingContext_GetVelocity(FContextualAnimSceneBindingContext BindingContext) { return default; }
	public static AActor BP_SceneBinding_GetActor(FContextualAnimSceneBinding Binding) { return default; }
	public static USkeletalMeshComponent BP_SceneBinding_GetSkeletalMesh(FContextualAnimSceneBinding Binding) { return default; }
}
