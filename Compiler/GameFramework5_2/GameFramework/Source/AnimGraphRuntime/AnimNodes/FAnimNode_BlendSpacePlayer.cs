#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@TODO: Comment</summary>
[CppInclude("AnimNodes/AnimNode_BlendSpacePlayer.h")]
public partial struct FAnimNode_BlendSpacePlayer {
	public string GroupName;
	public EAnimGroupRole GroupRole;
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
