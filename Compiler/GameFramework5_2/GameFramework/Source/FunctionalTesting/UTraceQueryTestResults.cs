namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceQueryTestResults.h")]
public partial class UTraceQueryTestResults : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Results for channel trace</summary>
	public FTraceQueryTestResultsInner ChannelResults;
	///<summary>Results for object trace</summary>
	public FTraceQueryTestResultsInner ObjectResults;
	///<summary>Results for profile trace</summary>
	public FTraceQueryTestResultsInner ProfileResults;
	///<summary>BatchOptions</summary>
	public FTraceChannelTestBatchOptions BatchOptions;
	///<summary>Output string value</summary>
	public string ToString() { return default; }
}
