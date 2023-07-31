#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for any asset playing anim node</summary>
[CppInclude("Animation/AnimNode_AssetPlayerBase.h")]
public partial struct FAnimNode_AssetPlayerBase {
	public int GroupIndex_DEPRECATED;
	public EAnimSyncGroupScope GroupScope_DEPRECATED;
	public float BlendWeight;
	public float InternalTimeAccumulator;
}
