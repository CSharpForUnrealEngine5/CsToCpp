namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter selected objects</summary>
[CppInclude("SelectionSystem/DataprepObjectSelectionFilter.h")]
public partial class UDataprepObjectSelectionFilter : UDataprepFilterNoFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>Partial paths of objects.</summary>
	public TArray<string> SelectedObjectPaths;
	///<summary>NumAssets</summary>
	public int NumAssets;
	///<summary>NumActors</summary>
	public int NumActors;
	///<summary>Cache some of the names of selected objects, up to some limit, for preview purpose</summary>
	public TArray<string> CachedNames;
}
