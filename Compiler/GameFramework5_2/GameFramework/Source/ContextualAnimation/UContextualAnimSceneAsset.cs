#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
public partial class UContextualAnimSceneAsset : UDataAsset {
	///<summary>GetRoles</summary>
	public  TArray<string> GetRoles() { return default; }
	///<summary>GetAlignmentPointsForSecondaryRole</summary>
	public  void GetAlignmentPointsForSecondaryRole(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,TArray<FContextualAnimPoint> OutResult) {}
	///<summary>GetAlignmentPointsForSecondaryRoleConsideringSelectionCriteria</summary>
	public  void GetAlignmentPointsForSecondaryRoleConsideringSelectionCriteria(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Querier,EContextualAnimCriterionToConsider CriterionToConsider,TArray<FContextualAnimPoint> OutResult) {}
	///<summary>Blueprint Interface</summary>
	public  UAnimSequenceBase BP_FindAnimationForRole(int SectionIdx,int AnimSetIdx,string Role) { return default; }
	///<summary>BP_FindAnimSetIndexByAnimation</summary>
	public  int BP_FindAnimSetIndexByAnimation(int SectionIdx,UAnimSequenceBase Animation) { return default; }
	///<summary>BP_GetAlignmentTransformForRoleRelativeToPivot</summary>
	public  FTransform BP_GetAlignmentTransformForRoleRelativeToPivot(int SectionIdx,int AnimSetIdx,string Role,float Time) { return default; }
	///<summary>BP_GetIKTargetTransformForRoleAtTime</summary>
	public  FTransform BP_GetIKTargetTransformForRoleAtTime(int SectionIdx,int AnimSetIdx,string Role,string TrackName,float Time) { return default; }
	///<summary>BP_GetStartAndEndTimeForWarpSection</summary>
	public  void BP_GetStartAndEndTimeForWarpSection(int SectionIdx,int AnimSetIdx,string Role,string WarpSectionName,float OutStartTime,float OutEndTime) {}
	///<summary>@TODO: Kept around only to do not break existing content. It will go away in the future.</summary>
	public  bool Query(string Role,FContextualAnimQueryResult OutResult,FContextualAnimQueryParams QueryParams,FTransform ToWorldTransform) { return default; }
	///<summary>RolesAsset</summary>
	public UContextualAnimRolesAsset RolesAsset;
	///<summary>PrimaryRole</summary>
	public string PrimaryRole;
	///<summary>OverridePreviewData</summary>
	public TArray<FContextualAnimActorPreviewData> OverridePreviewData;
	///<summary>Sections</summary>
	public TArray<FContextualAnimSceneSection> Sections;
	///<summary>Radius</summary>
	public float Radius;
	///<summary>SceneInstanceClass</summary>
	public UClass SceneInstanceClass;
	///<summary>bDisableCollisionBetweenActors</summary>
	public bool bDisableCollisionBetweenActors;
	///<summary>Sample rate (frames per second) used when sampling the animations to generate alignment and IK tracks</summary>
	public int SampleRate;
}
