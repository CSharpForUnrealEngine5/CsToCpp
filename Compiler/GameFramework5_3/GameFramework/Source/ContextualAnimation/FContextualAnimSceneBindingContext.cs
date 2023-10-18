namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FContextualAnimSceneBindingContext</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimSceneBindingContext {
	public TWeakObjectPtr<AActor> Actor;
	public TWeakObjectPtr<UContextualAnimSceneActorComponent> CachedSceneActorComp;
	public TWeakObjectPtr<UAnimInstance> CachedAnimInstance;
	public TWeakObjectPtr<USkeletalMeshComponent> CachedSkeletalMesh;
}
