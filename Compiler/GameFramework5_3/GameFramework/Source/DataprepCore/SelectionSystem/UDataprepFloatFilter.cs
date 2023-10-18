namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepFloatFilter.h")]
public partial class UDataprepFloatFilter : UDataprepFilter {
	public static UClass StaticClass() {return default;}
	///<summary>The source of float selected by the user</summary>
	public UDataprepFloatFetcher FloatFetcher;
	///<summary>The matching criteria used when checking if a fetched value can pass the filter</summary>
	public EDataprepFloatMatchType FloatMatchingCriteria;
	///<summary>The value to use for the comparison against the fetched value</summary>
	public float EqualValue;
	///<summary>The value used for the tolerance when doing a nearly equal</summary>
	public float Tolerance;
}
