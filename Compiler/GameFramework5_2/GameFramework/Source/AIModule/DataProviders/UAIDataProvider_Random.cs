namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataProviders/AIDataProvider_Random.h")]
public partial class UAIDataProvider_Random : UAIDataProvider_QueryParams {
	public static UClass StaticClass() {return default;}
	///<summary>Min</summary>
	public float Min;
	///<summary>Max</summary>
	public float Max;
	///<summary>bInteger</summary>
	public bool bInteger;
}
