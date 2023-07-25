#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepFilter.h")]
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
public partial class UDataprepFilterNoFetcher : UDataprepParameterizableObject {
// DataprepFilterNoFetcher
	public string GetDisplayFilterName() { return default; }
	public string GetNodeDisplayFilterName() { return default; }
	public string GetTooltipText() { return default; }
	public string GetAdditionalKeyword() { return default; }
	public bool bIsExcludingResult;
}
