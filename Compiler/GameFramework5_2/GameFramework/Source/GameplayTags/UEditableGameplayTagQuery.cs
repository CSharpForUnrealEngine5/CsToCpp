#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagContainer.h")]
///<summary>This is an editor-only representation of a query, designed to be editable with a typical property window.</summary>
public partial class UEditableGameplayTagQuery : UObject {
// EditableGameplayTagQuery
	public string UserDescription;
	public UEditableGameplayTagQueryExpression RootExpression;
	public FGameplayTagQuery TagQueryExportText_Helper;
}
