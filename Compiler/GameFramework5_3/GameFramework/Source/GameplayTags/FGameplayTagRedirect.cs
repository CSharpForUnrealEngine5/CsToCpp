namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single redirect from a deleted tag to the new tag that should replace it</summary>
[CppInclude("GameplayTagRedirectors.h")]
public partial struct FGameplayTagRedirect {
	public FName OldTagName;
	public FName NewTagName;
}
