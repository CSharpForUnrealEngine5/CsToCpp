#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/ActorHasTagFilter.h")]
///<summary>Allows an actor if it has all or any of the specified tags.</summary>
public partial class UActorHasTagFilter : UActorSelectorFilter {
// ActorHasTagFilter
	public byte TagCheckingBehavior;
	public TSet<string> AllowedTags;
	public byte ActorToCheck;
}
