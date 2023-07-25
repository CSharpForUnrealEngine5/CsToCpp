#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ActorInstanceHandle.h")]
///<summary>Handle to a unique object. This may specify a full weigh actor or it may only specify the light weight instance that represents the same object.</summary>
public partial struct FActorInstanceHandle {
// ActorInstanceHandle
	public TWeakObjectPtr<AActor> Actor;
}
