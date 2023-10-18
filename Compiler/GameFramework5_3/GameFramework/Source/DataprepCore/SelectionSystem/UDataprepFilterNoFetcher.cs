namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
[CppInclude("SelectionSystem/DataprepFilter.h")]
public partial class UDataprepFilterNoFetcher : UDataprepParameterizableObject {
	public static UClass StaticClass() {return default;}
	///<summary>Allows to change the name of the filter for the ui if needed.</summary>
	public FText GetDisplayFilterName() { return default; }
	///<summary>The name displayed on node title.</summary>
	public FText GetNodeDisplayFilterName() { return default; }
	///<summary>Allows to change the tooltip of the filter for the ui if needed.</summary>
	public FText GetTooltipText() { return default; }
	///<summary>Allows to add more keywords for when a user is searching for the filter in the ui.</summary>
	public FText GetAdditionalKeyword() { return default; }
	///<summary>Is this filter an excluding filter (a filter that produces the inverse of its normal output)</summary>
	public bool bIsExcludingResult;
}
