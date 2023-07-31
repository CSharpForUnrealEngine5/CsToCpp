#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single redirect from a deleted tag to the new tag that should replace it</summary>
[CppInclude("GameplayTagRedirectors.h")]
public partial struct FGameplayTagRedirect {
	public string OldTagName;
	public string NewTagName;
}
