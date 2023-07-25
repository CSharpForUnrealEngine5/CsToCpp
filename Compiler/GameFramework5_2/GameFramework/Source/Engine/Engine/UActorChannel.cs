#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ActorChannel.h")]
///<summary>A channel for exchanging actor and its subobject's properties and RPCs.</summary>
public partial class UActorChannel : UChannel {
// ActorChannel
	public AActor Actor;
	public TArray<UObject> CreateSubObjects;
}
