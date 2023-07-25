#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Sight.h")]
public partial class UAISense_Sight : UAISense {
// AISense_Sight
	public int MaxTracesPerTick;
	public int MaxAsyncTracesPerTick;
	public int MinQueriesPerTimeSliceCheck;
	public double MaxTimeSlicePerTick;
	public float HighImportanceQueryDistanceThreshold;
	public float MaxQueryImportance;
	public float SightLimitQueryImportance;
	public float PendingQueriesBudgetReductionRatio;
	public bool bUseAsynchronousTraceForDefaultSightQueries;
}
