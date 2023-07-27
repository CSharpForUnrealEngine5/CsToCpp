#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepFilter.h")]
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
public partial class UDataprepFilter : UDataprepParameterizableObject {
// DataprepFilter
	public  UDataprepFetcher GetFetcher() { return default; }
	public bool bIsExcludingResult;
}
