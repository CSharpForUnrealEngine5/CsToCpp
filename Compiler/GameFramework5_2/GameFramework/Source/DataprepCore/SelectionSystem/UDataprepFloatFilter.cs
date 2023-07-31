#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepFloatFilter.h")]
public partial class UDataprepFloatFilter : UDataprepFilter {
	///<summary>The source of float selected by the user</summary>
	public UDataprepFloatFetcher FloatFetcher;
	///<summary>The matching criteria used when checking if a fetched value can pass the filter</summary>
	public EDataprepFloatMatchType FloatMatchingCriteria;
	///<summary>The value to use for the comparison against the fetched value</summary>
	public float EqualValue;
	///<summary>The value used for the tolerance when doing a nearly equal</summary>
	public float Tolerance;
}
