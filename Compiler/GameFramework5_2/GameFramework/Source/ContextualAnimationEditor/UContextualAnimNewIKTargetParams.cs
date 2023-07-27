#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimEditorTypes.h")]
///<summary>Object used to construct the New IK Target Widget</summary>
public partial class UContextualAnimNewIKTargetParams : UObject {
// ContextualAnimNewIKTargetParams
	public string SourceRole;
	public FBoneReference SourceBone;
	public EContextualAnimIKTargetProvider Provider;
	public string TargetRole;
	public FBoneReference TargetBone;
	public string GoalName;
	public int SectionIdx;
	public  TArray<string> GetTargetRoleOptions() { return default; }
	public TWeakObjectPtr<UContextualAnimSceneAsset> SceneAssetPtr;
	public TArray<string> CachedRoles;
}
