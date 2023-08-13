namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepStringFilter.h")]
public partial class UDataprepStringFilter : UDataprepFilter {
	public static UClass StaticClass() {return default;}
	///<summary>The matching criteria used when checking if a fetched value can pass the filter</summary>
	public EDataprepStringMatchType StringMatchingCriteria;
	///<summary>The string used when doing the comparison</summary>
	public string UserString;
	///<summary>UserStringArray</summary>
	public UDataprepStringFilterMatchingArray UserStringArray;
	///<summary>bMatchInArray</summary>
	public bool bMatchInArray;
	///<summary>The source of string selected by the user</summary>
	public UDataprepStringFetcher StringFetcher;
}
