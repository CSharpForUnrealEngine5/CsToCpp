#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphSchema.h")]
///<summary>This structure represents a context dependent action, with sufficient information for the schema to perform it.</summary>
public partial struct FEdGraphSchemaAction {
// EdGraphSchemaAction
	public string MenuDescription;
	public string TooltipDescription;
	public string Category;
	public string Keywords;
	public int Grouping;
	public int SectionID;
	public TArray<string> MenuDescriptionArray;
	public TArray<string> FullSearchTitlesArray;
	public TArray<string> FullSearchKeywordsArray;
	public TArray<string> FullSearchCategoryArray;
	public TArray<string> LocalizedMenuDescriptionArray;
	public TArray<string> LocalizedFullSearchTitlesArray;
	public TArray<string> LocalizedFullSearchKeywordsArray;
	public TArray<string> LocalizedFullSearchCategoryArray;
	public string SearchText;
}
