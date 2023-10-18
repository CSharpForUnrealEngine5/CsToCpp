namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structure represents a context dependent action, with sufficient information for the schema to perform it.</summary>
[CppInclude("EdGraph/EdGraphSchema.h")]
public partial struct FEdGraphSchemaAction {
	public FText MenuDescription;
	public FText TooltipDescription;
	public FText Category;
	public FText Keywords;
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
