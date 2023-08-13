namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
[CppInclude("SelectionSystem/DataprepFilter.h")]
public partial class UDataprepFilter : UDataprepParameterizableObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetFetcher</summary>
	public UDataprepFetcher GetFetcher() { return default; }
	///<summary>Is this filter an excluding filter (a filter that produces the inverse of its normal output)</summary>
	public bool bIsExcludingResult;
}
