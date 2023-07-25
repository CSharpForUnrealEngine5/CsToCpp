#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Level.h")]
///<summary>Actor container class used to duplicate actors during cells streaming in PIE</summary>
public partial class UActorContainer : UObject {
// ActorContainer
	public TMap<string,AActor> Actors;
}
