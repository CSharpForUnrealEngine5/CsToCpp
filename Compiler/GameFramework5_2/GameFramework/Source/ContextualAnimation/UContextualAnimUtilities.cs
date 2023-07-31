#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimUtilities.h")]
public partial class UContextualAnimUtilities : UBlueprintFunctionLibrary {
	///<summary>BP_DrawDebugPose</summary>
	public static void BP_DrawDebugPose(UObject WorldContextObject,UAnimSequenceBase Animation,float Time,FTransform LocalToWorldTransform,FLinearColor Color,float LifeTime,float Thickness) {}
	///<summary>BP_CreateContextualAnimSceneBindings</summary>
	public static bool BP_CreateContextualAnimSceneBindings(UContextualAnimSceneAsset SceneAsset,TMap<string,FContextualAnimSceneBindingContext> Params,FContextualAnimSceneBindings OutBindings) { return default; }
	///<summary>BP_CreateContextualAnimSceneBindingsForTwoActors</summary>
	public static bool BP_CreateContextualAnimSceneBindingsForTwoActors(UContextualAnimSceneAsset SceneAsset,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Secondary,FContextualAnimSceneBindings OutBindings) { return default; }
	///<summary>Montage Blueprint Interface</summary>
	public static void BP_Montage_GetSectionStartAndEndTime(UAnimMontage Montage,int SectionIndex,float OutStartTime,float OutEndTime) {}
	///<summary>BP_Montage_GetSectionTimeLeftFromPos</summary>
	public static float BP_Montage_GetSectionTimeLeftFromPos(UAnimMontage Montage,float Position) { return default; }
	///<summary>BP_Montage_GetSectionLength</summary>
	public static float BP_Montage_GetSectionLength(UAnimMontage Montage,int SectionIndex) { return default; }
	///<summary>SceneBindings Blueprint Interface</summary>
	public static void BP_SceneBindings_CalculateAnimSetPivots(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimSetPivot> OutPivots) {}
	///<summary>BP_SceneBindings_AddOrUpdateWarpTargetsForBindings</summary>
	public static void BP_SceneBindings_AddOrUpdateWarpTargetsForBindings(FContextualAnimSceneBindings Bindings) {}
	///<summary>BP_SceneBindings_GetBindings</summary>
	public static TArray<FContextualAnimSceneBinding> BP_SceneBindings_GetBindings(FContextualAnimSceneBindings Bindings) { return default; }
	///<summary>BP_SceneBindings_GetBindingByRole</summary>
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByRole(FContextualAnimSceneBindings Bindings,string Role) { return default; }
	///<summary>BP_SceneBindings_GetBindingByActor</summary>
	public static FContextualAnimSceneBinding BP_SceneBindings_GetBindingByActor(FContextualAnimSceneBindings Bindings,AActor Actor) { return default; }
	///<summary>BP_SceneBinding_GetAnimationFromBinding</summary>
	public static UAnimSequenceBase BP_SceneBinding_GetAnimationFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBinding_GetRoleFromBinding</summary>
	public static string BP_SceneBinding_GetRoleFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBindings_GetSceneAsset</summary>
	public static UContextualAnimSceneAsset BP_SceneBindings_GetSceneAsset(FContextualAnimSceneBindings Bindings) { return default; }
	///<summary>BP_SceneBindings_GetSectionAndAnimSetIndices</summary>
	public static void BP_SceneBindings_GetSectionAndAnimSetIndices(FContextualAnimSceneBindings Bindings,int SectionIdx,int AnimSetIdx) {}
	///<summary>BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole(FContextualAnimSceneBindings Bindings,string Role,string RelativeToRole,float Time) { return default; }
	///<summary>BP_SceneBindings_GetAlignmentTransformForRoleRelativeToPivot</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToPivot(FContextualAnimSceneBindings Bindings,string Role,FContextualAnimSetPivot Pivot,float Time) { return default; }
	///<summary>BP_SceneBindings_GetAlignmentTransformFromBinding</summary>
	public static FTransform BP_SceneBindings_GetAlignmentTransformFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,FContextualAnimSetPivot Pivot) { return default; }
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
	///<summary>FContextualAnimSceneBinding Blueprint Interface</summary>
	public static AActor BP_SceneBinding_GetActor(FContextualAnimSceneBinding Binding) { return default; }
	///<summary>BP_SceneBinding_GetSkeletalMesh</summary>
	public static USkeletalMeshComponent BP_SceneBinding_GetSkeletalMesh(FContextualAnimSceneBinding Binding) { return default; }
}
