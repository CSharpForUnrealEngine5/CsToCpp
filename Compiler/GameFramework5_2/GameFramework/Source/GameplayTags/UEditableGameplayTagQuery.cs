namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is an editor-only representation of a query, designed to be editable with a typical property window.</summary>
[CppInclude("GameplayTagContainer.h")]
public partial class UEditableGameplayTagQuery : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>User-supplied description, shown in property details. Auto-generated description is shown if not supplied.</summary>
	public string UserDescription;
	///<summary>The base expression of this query.</summary>
	public UEditableGameplayTagQueryExpression RootExpression;
	///<summary>Property to hold a gameplay tag query so we can use the exporttext path to get a string representation.</summary>
	public FGameplayTagQuery TagQueryExportText_Helper;
}
