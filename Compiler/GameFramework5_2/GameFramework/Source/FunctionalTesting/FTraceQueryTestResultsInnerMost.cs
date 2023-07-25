#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceQueryTestResults.h")]
public partial struct FTraceQueryTestResultsInnerMost {
// TraceQueryTestResultsInnerMost
	public FHitResult SingleHit;
	public FTraceQueryTestNames SingleNames;
	public bool bSingleResult;
	public TArray<FHitResult> MultiHits;
	public TArray<FTraceQueryTestNames> MultiNames;
	public bool bMultiResult;
}
