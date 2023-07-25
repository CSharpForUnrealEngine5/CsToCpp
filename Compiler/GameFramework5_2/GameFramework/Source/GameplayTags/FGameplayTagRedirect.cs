#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagRedirectors.h")]
///<summary>A single redirect from a deleted tag to the new tag that should replace it</summary>
public partial struct FGameplayTagRedirect {
// GameplayTagRedirect
	public string OldTagName;
	public string NewTagName;
}
