namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple struct for a table row in the gameplay tag table and element in the ini list</summary>
[CppInclude("GameplayTagsManager.h")]
public partial struct FGameplayTagTableRow {
	public FName Tag;
	public string DevComment;
}
