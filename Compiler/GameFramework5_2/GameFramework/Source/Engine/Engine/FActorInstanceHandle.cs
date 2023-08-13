namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handle to a unique object. This may specify a full weigh actor or it may only specify the light weight instance that represents the same object.</summary>
[CppInclude("Engine/ActorInstanceHandle.h")]
public partial struct FActorInstanceHandle {
	public TWeakObjectPtr<AActor> Actor;
}
