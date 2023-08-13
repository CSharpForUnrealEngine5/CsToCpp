namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepIntegerFilter.h")]
public partial class UDataprepIntegerFilter : UDataprepFilter {
	public static UClass StaticClass() {return default;}
	///<summary>The source of int selected by the user</summary>
	public UDataprepIntegerFetcher IntFetcher;
	///<summary>The matching criteria used when checking if a fetched value can pass the filter</summary>
	public EDataprepIntegerMatchType IntegerMatchingCriteria;
	///<summary>The value to use when doing the comparison against the fetched value</summary>
	public int EqualValue;
	///<summary>A value used for the in-between check</summary>
	public int FromValue;
	///<summary>A value used for the in-between check</summary>
	public int ToValue;
}
