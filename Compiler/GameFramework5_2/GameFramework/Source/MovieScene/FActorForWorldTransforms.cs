#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description of an actor selected parts we can find world transforms on</summary>
[CppInclude("ActorForWorldTransforms.h")]
public partial struct FActorForWorldTransforms {
	public TWeakObjectPtr<AActor> Actor;
	public TWeakObjectPtr<USceneComponent> Component;
	public string SocketName;
}
