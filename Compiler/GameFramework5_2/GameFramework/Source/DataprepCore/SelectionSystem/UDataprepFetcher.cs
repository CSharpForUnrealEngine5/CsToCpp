namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Dataprep fetcher is a base class for Dataprep Selection system.</summary>
[CppInclude("SelectionSystem/DataprepFetcher.h")]
public partial class UDataprepFetcher : UDataprepParameterizableObject {
	public static UClass StaticClass() {return default;}
	///<summary>Allows to change the name of the fetcher for the ui if needed.</summary>
	public FText GetDisplayFetcherName() { return default; }
	///<summary>The name displayed on node title.</summary>
	public FText GetNodeDisplayFetcherName() { return default; }
	///<summary>Allows to change the tooltip of the fetcher for the ui if needed.</summary>
	public FText GetTooltipText() { return default; }
	///<summary>Allows to add more keywords for when a user is searching for the fetcher in the ui.</summary>
	public FText GetAdditionalKeyword() { return default; }
}
