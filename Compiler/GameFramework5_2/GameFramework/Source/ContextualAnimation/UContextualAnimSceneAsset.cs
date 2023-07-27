#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
public partial class UContextualAnimSceneAsset : UDataAsset {
// ContextualAnimSceneAsset
	public  TArray<string> GetRoles() { return default; }
	public  void GetAlignmentPointsForSecondaryRole(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,TArray<FContextualAnimPoint> OutResult) {}
	public  void GetAlignmentPointsForSecondaryRoleConsideringSelectionCriteria(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Querier,EContextualAnimCriterionToConsider CriterionToConsider,TArray<FContextualAnimPoint> OutResult) {}
	public  UAnimSequenceBase BP_FindAnimationForRole(int SectionIdx,int AnimSetIdx,string Role) { return default; }
	public  int BP_FindAnimSetIndexByAnimation(int SectionIdx,UAnimSequenceBase Animation) { return default; }
	public  FTransform BP_GetAlignmentTransformForRoleRelativeToPivot(int SectionIdx,int AnimSetIdx,string Role,float Time) { return default; }
	public  FTransform BP_GetIKTargetTransformForRoleAtTime(int SectionIdx,int AnimSetIdx,string Role,string TrackName,float Time) { return default; }
	public  void BP_GetStartAndEndTimeForWarpSection(int SectionIdx,int AnimSetIdx,string Role,string WarpSectionName,float OutStartTime,float OutEndTime) {}
	public  bool Query(string Role,FContextualAnimQueryResult OutResult,FContextualAnimQueryParams QueryParams,FTransform ToWorldTransform) { return default; }
	public UContextualAnimRolesAsset RolesAsset;
	public string PrimaryRole;
	public TArray<FContextualAnimActorPreviewData> OverridePreviewData;
	public TArray<FContextualAnimSceneSection> Sections;
	public float Radius;
	public UClass SceneInstanceClass;
	public bool bDisableCollisionBetweenActors;
	public int SampleRate;
}
