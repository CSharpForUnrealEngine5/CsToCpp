#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepObjectSelectionFilter.h")]
///<summary>Filter selected objects</summary>
public partial class UDataprepObjectSelectionFilter : UDataprepFilterNoFetcher {
// DataprepObjectSelectionFilter
	public TArray<string> SelectedObjectPaths;
	public int NumAssets;
	public int NumActors;
	public TArray<string> CachedNames;
}
