namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingInstances.h")]
public partial class UAnimSharingTransitionInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>FromComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> FromComponent;
	///<summary>ToComponent</summary>
	public TWeakObjectPtr<USkeletalMeshComponent> ToComponent;
	///<summary>BlendTime</summary>
	public float BlendTime;
	///<summary>bBlendBool</summary>
	public bool bBlendBool;
}
