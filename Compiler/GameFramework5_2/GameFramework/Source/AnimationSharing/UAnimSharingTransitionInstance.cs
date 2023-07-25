#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingTransitionInstance : UAnimInstance {
// AnimSharingTransitionInstance
	public TWeakObjectPtr<USkeletalMeshComponent> FromComponent;
	public TWeakObjectPtr<USkeletalMeshComponent> ToComponent;
	public float BlendTime;
	public bool bBlendBool;
}
