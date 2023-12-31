namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AIDataProvider_QueryParams is used with environment queries</summary>
[CppInclude("DataProviders/AIDataProvider_QueryParams.h")]
public partial class UAIDataProvider_QueryParams : UAIDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Arbitrary name this query parameter will be exposed as to outside world (like BT nodes)</summary>
	public FName ParamName;
	///<summary>FloatValue</summary>
	public float FloatValue;
	///<summary>IntValue</summary>
	public int IntValue;
	///<summary>BoolValue</summary>
	public bool BoolValue;
}
