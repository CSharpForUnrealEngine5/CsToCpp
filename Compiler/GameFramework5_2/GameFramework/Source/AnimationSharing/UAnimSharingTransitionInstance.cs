#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingTransitionInstance : UAnimInstance {
	///<summary>FromComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> FromComponent;
	///<summary>ToComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> ToComponent;
	///<summary>BlendTime</summary>
	public float BlendTime;
	///<summary>bBlendBool</summary>
	public bool bBlendBool;
}
