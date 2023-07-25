#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorForWorldTransforms.h")]
///<summary>Description of an actor selected parts we can find world transforms on</summary>
public partial struct FActorForWorldTransforms {
// ActorForWorldTransforms
	public TWeakObjectPtr<AActor> Actor;
	public TWeakObjectPtr<USceneComponent> Component;
	public string SocketName;
}
