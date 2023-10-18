namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single gameplay tag, which represents a hierarchical name of the form x.y that is registered in the GameplayTagsManager</summary>
[CppInclude("GameplayTagContainer.h")]
public partial struct FGameplayTag {
	public FName TagName;
}
