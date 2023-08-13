namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_PlacementInfo</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_PlacementInfo {
	public string SocketName;
	public EGameplayCueNotify_AttachPolicy AttachPolicy;
	public EAttachmentRule AttachmentRule;
	public bool bOverrideRotation;
	public bool bOverrideScale;
	public FRotator RotationOverride;
	public FVector ScaleOverride;
}
