namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object used to construct the New IK Target Widget</summary>
[CppInclude("ContextualAnimEditorTypes.h")]
public partial class UContextualAnimNewIKTargetParams : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SourceRole</summary>
	public FName SourceRole;
	///<summary>SourceBone</summary>
	public FBoneReference SourceBone;
	///<summary>Provider</summary>
	public EContextualAnimIKTargetProvider Provider;
	///<summary>TargetRole</summary>
	public FName TargetRole;
	///<summary>TargetBone</summary>
	public FBoneReference TargetBone;
	///<summary>GoalName</summary>
	public FName GoalName;
	///<summary>SectionIdx</summary>
	public int SectionIdx;
	///<summary>GetTargetRoleOptions</summary>
	public TArray<string> GetTargetRoleOptions() { return default; }
	///<summary>SceneAssetPtr</summary>
	public TWeakObjectPtr<UContextualAnimSceneAsset> SceneAssetPtr;
	///<summary>CachedRoles</summary>
	public TArray<FName> CachedRoles;
}
