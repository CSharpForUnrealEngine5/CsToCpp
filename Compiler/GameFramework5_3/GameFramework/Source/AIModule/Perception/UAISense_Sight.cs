namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Sight.h")]
public partial class UAISense_Sight : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>MaxTracesPerTick</summary>
	public int MaxTracesPerTick;
	///<summary>Maximum number of asynchronous traces that can be requested in a single update call</summary>
	public int MaxAsyncTracesPerTick;
	///<summary>MinQueriesPerTimeSliceCheck</summary>
	public int MinQueriesPerTimeSliceCheck;
	///<summary>MaxTimeSlicePerTick</summary>
	public double MaxTimeSlicePerTick;
	///<summary>HighImportanceQueryDistanceThreshold</summary>
	public float HighImportanceQueryDistanceThreshold;
	///<summary>MaxQueryImportance</summary>
	public float MaxQueryImportance;
	///<summary>SightLimitQueryImportance</summary>
	public float SightLimitQueryImportance;
	///<summary>Defines the amount of async trace queries to prevent based on the number of pending queries at the start of an update.</summary>
	public float PendingQueriesBudgetReductionRatio;
	///<summary>Defines if we are allowed to use asynchronous trace queries when there is no IAISightTargetInterface for a Target</summary>
	public bool bUseAsynchronousTraceForDefaultSightQueries;
}
