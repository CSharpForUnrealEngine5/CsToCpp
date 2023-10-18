namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper / intermediate for asset player graphical nodes</summary>
[CppInclude("AnimGraphNode_AssetPlayerBase.h")]
public partial class UAnimGraphNode_AssetPlayerBase : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Deprecated - sync group data is held on the contained FAnimNode_Base</summary>
	public FAnimationGroupReference SyncGroup_DEPRECATED;
}
