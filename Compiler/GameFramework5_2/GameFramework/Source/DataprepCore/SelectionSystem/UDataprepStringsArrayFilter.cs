#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepStringsArrayFilter.h")]
public partial class UDataprepStringsArrayFilter : UDataprepFilter {
// DataprepStringsArrayFilter
	public EDataprepStringMatchType StringMatchingCriteria;
	public string UserString;
	public UDataprepStringFilterMatchingArray UserStringArray;
	public bool bMatchInArray;
	public UDataprepStringsArrayFetcher StringsArrayFetcher;
}
