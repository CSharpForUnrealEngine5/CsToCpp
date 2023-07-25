#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceQueryTestResults.h")]
public partial class UTraceQueryTestResults : UObject {
// TraceQueryTestResults
	public FTraceQueryTestResultsInner ChannelResults;
	public FTraceQueryTestResultsInner ObjectResults;
	public FTraceQueryTestResultsInner ProfileResults;
	public FTraceChannelTestBatchOptions BatchOptions;
	public string ToString() { return default; }
}
