#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_BlendSpacePlayer.h")]
///<summary>@TODO: Comment</summary>
public partial struct FAnimNode_BlendSpacePlayer {
// AnimNode_BlendSpacePlayer
	public string GroupName;
	public byte GroupRole;
	public EAnimSyncMethod Method;
	public bool bIgnoreForRelevancyTest;
	public float X;
	public float Y;
	public float PlayRate;
	public bool bLoop;
	public bool bResetPlayTimeWhenBlendSpaceChanges;
	public float StartPosition;
	public UBlendSpace BlendSpace;
}
