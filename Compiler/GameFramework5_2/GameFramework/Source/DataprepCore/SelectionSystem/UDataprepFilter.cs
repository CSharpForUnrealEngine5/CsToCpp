#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
[CppInclude("SelectionSystem/DataprepFilter.h")]
public partial class UDataprepFilter : UDataprepParameterizableObject {
	///<summary>GetFetcher</summary>
	public  UDataprepFetcher GetFetcher() { return default; }
	///<summary>Is this filter an excluding filter (a filter that produces the inverse of its normal output)</summary>
	public bool bIsExcludingResult;
}
