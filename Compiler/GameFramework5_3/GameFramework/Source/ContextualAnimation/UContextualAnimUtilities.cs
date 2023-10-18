namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimUtilities.h")]
public partial class UContextualAnimUtilities : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>BP_DrawDebugPose</summary>
	public static void BP_DrawDebugPose(UObject WorldContextObject,UAnimSequenceBase Animation,float Time,FTransform LocalToWorldTransform,FLinearColor Color,float LifeTime,float Thickness) {}
	///<summary>BP_CreateContextualAnimSceneBindings</summary>
	public static bool BP_CreateContextualAnimSceneBindings(UContextualAnimSceneAsset SceneAsset,TMap<FName,FContextualAnimSceneBindingContext> Params,FContextualAnimSceneBindings OutBindings) { return default; }
	///<summary>BP_CreateContextualAnimSceneBindingsForTwoActors</summary>
	public static bool BP_CreateContextualAnimSceneBindingsForTwoActors(UContextualAnimSceneAsset SceneAsset,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Secondary,FContextualAnimSceneBindings OutBindings) { return default; }
	///<summary>Montage Blueprint Interface</summary>
	public static void BP_Montage_GetSectionStartAndEndTime(UAnimMontage Montage,int SectionIndex,float OutStartTime,float OutEndTime) {}
	///<summary>BP_Montage_GetSectionTimeLeftFromPos</summary>
	public static float BP_Montage_GetSectionTimeLeftFromPos(UAnimMontage Montage,float Position) { return default; }
	///<summary>BP_Montage_GetSectionLength</summary>
	public static float BP_Montage_GetSectionLength(UAnimMontage Montage,int SectionIndex) { return default; }
	///<summary>SceneBindings Blueprint Interface</summary>
	public static void BP_SceneBindings_CalculateWarpPoints(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimWarpPoint> OutWarpPoints) {}
	///<summary>BP_SceneBindings_AddOrUpdateWarpTargetsForBindings</summary>
	public static void BP_SceneBindings_AddOrUpdateWarpTargetsForBindings(FContextualAnimSceneBindings Bindings) {}
	///<summary>BP_SceneBindings_GetBindings</summary>
	public static TArray<FContextualAnimSceneBinding> BP_SceneBindings_GetBindings(FContextualAnimSceneBindings Bindings) { return default; }
	///<summary>BP_SceneBindings_GetBindingByRole</summary>
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByRole(FContextualAnimSceneBindings Bindings,FName Role) { return default; }
	///<summary>BP_SceneBindings_GetBindingByActor</summary>
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByActor(FContextualAnimSceneBindings Bindings,AActor Actor) { return default; }
	///<summary>BP_SceneBinding_GetAnimationFromBinding</summary>
	public static UAnimSequenceBase BP_SceneBinding_GetAnimationFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBinding_GetRoleFromBinding</summary>
	public static FName BP_SceneBinding_GetRoleFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBindings_GetSceneAsset</summary>
	public static UContextualAnimSceneAsset BP_SceneBindings_GetSceneAsset(FContextualAnimSceneBindings Bindings) { return default; }
	///<summary>BP_SceneBindings_GetSectionAndAnimSetIndices</summary>
	public static void BP_SceneBindings_GetSectionAndAnimSetIndices(FContextualAnimSceneBindings Bindings,int SectionIdx,int AnimSetIdx) {}
	///<summary>BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole(FContextualAnimSceneBindings Bindings,FName Role,FName RelativeToRole,float Time) { return default; }
	///<summary>BP_SceneBindings_GetAlignmentTransformForRoleRelativeToWarpPoint</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToWarpPoint(FContextualAnimSceneBindings Bindings,FName Role,FContextualAnimWarpPoint WarpPoint,float Time) { return default; }
	///<summary>BP_SceneBindings_GetAlignmentTransformFromBinding</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,FContextualAnimWarpPoint WarpPoint) { return default; }
	///<summary>FContextualAnimSceneBindingContext Blueprint Interface</summary>
	public static FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActor(AActor Actor) { return default; }
	///<summary>BP_SceneBindingContext_MakeFromActorWithExternalTransform</summary>
	public static FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActorWithExternalTransform(AActor Actor,FTransform ExternalTransform) { return default; }
	///<summary>BP_SceneBindingContext_GetActor</summary>
	public static AActor BP_SceneBindingContext_GetActor(FContextualAnimSceneBindingContext BindingContext) { return default; }
	///<summary>BP_SceneBindingContext_GetTransform</summary>
	public static FTransform BP_SceneBindingContext_GetTransform(FContextualAnimSceneBindingContext BindingContext) { return default; }
	///<summary>BP_SceneBindingContext_GetVelocity</summary>
	public static FVector BP_SceneBindingContext_GetVelocity(FContextualAnimSceneBindingContext BindingContext) { return default; }
	///<summary>BP_SceneBindingContext_GetGameplayTags</summary>
	public static FGameplayTagContainer BP_SceneBindingContext_GetGameplayTags(FContextualAnimSceneBindingContext BindingContext) { return default; }
	///<summary>BP_SceneBindingContext_HasMatchingGameplayTag</summary>
	public static bool BP_SceneBindingContext_HasMatchingGameplayTag(FContextualAnimSceneBindingContext BindingContext,FGameplayTag TagToCheck) { return default; }
	///<summary>BP_SceneBindingContext_HasAllMatchingGameplayTags</summary>
	public static bool BP_SceneBindingContext_HasAllMatchingGameplayTags(FContextualAnimSceneBindingContext BindingContext,FGameplayTagContainer TagContainer) { return default; }
	///<summary>BP_SceneBindingContext_HasAnyMatchingGameplayTags</summary>
	public static bool BP_SceneBindingContext_HasAnyMatchingGameplayTags(FContextualAnimSceneBindingContext BindingContext,FGameplayTagContainer TagContainer) { return default; }
	///<summary>FContextualAnimSceneBinding Blueprint Interface</summary>
	public static AActor BP_SceneBinding_GetActor(FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBinding_GetSkeletalMesh</summary>
	public static USkeletalMeshComponent BP_SceneBinding_GetSkeletalMesh(FContextualAnimSceneBinding Binding) { return default; }
}
