#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepStringFilter.h")]
public partial class UDataprepStringFilter : UDataprepFilter {
// DataprepStringFilter
	public EDataprepStringMatchType StringMatchingCriteria;
	public string UserString;
	public UDataprepStringFilterMatchingArray UserStringArray;
	public bool bMatchInArray;
	public UDataprepStringFetcher StringFetcher;
}
