#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_PlacementInfo</summary>
public partial struct FGameplayCueNotify_PlacementInfo {
// GameplayCueNotify_PlacementInfo
	public string SocketName;
	public EGameplayCueNotify_AttachPolicy AttachPolicy;
	public EAttachmentRule AttachmentRule;
	public bool bOverrideRotation;
	public bool bOverrideScale;
	public FRotator RotationOverride;
	public FVector ScaleOverride;
}
