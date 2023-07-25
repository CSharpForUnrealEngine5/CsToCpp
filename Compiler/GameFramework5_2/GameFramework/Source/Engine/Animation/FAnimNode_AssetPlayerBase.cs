#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_AssetPlayerBase.h")]
///<summary>Base class for any asset playing anim node</summary>
public partial struct FAnimNode_AssetPlayerBase {
// AnimNode_AssetPlayerBase
	public int GroupIndex_DEPRECATED;
	public EAnimSyncGroupScope GroupScope_DEPRECATED;
	public float BlendWeight;
	public float InternalTimeAccumulator;
}
