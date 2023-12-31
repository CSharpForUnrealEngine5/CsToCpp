namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an actor if it has all or any of the specified tags.</summary>
[CppInclude("Builtin/ActorHasTagFilter.h")]
public partial class UActorHasTagFilter : UActorSelectorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>How to match AllowedTags in each actor.</summary>
	public ETagCheckingBehavior TagCheckingBehavior;
	///<summary>The tags to check the actor for.</summary>
	public TSet<FName> AllowedTags;
	///<summary>Which of the actors we should check the tags on.</summary>
	public EActorToCheck ActorToCheck;
}
