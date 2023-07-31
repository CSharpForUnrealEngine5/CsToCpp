#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Dataprep fetcher is a base class for Dataprep Selection system.</summary>
[CppInclude("SelectionSystem/DataprepFetcher.h")]
public partial class UDataprepFetcher : UDataprepParameterizableObject {
	///<summary>Allows to change the name of the fetcher for the ui if needed.</summary>
	public  string GetDisplayFetcherName() { return default; }
	///<summary>The name displayed on node title.</summary>
	public  string GetNodeDisplayFetcherName() { return default; }
	///<summary>Allows to change the tooltip of the fetcher for the ui if needed.</summary>
	public  string GetTooltipText() { return default; }
	///<summary>Allows to add more keywords for when a user is searching for the fetcher in the ui.</summary>
	public  string GetAdditionalKeyword() { return default; }
}
