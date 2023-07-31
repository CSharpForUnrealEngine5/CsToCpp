#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_Trace.h")]
public partial class UEnvQueryTest_Trace : UEnvQueryTest {
	///<summary>trace data</summary>
	public FEnvTraceData TraceData;
	///<summary>trace direction</summary>
	public FAIDataProviderBoolValue TraceFromContext;
	///<summary>Z offset from item</summary>
	public FAIDataProviderFloatValue ItemHeightOffset;
	///<summary>Z offset from querier</summary>
	public FAIDataProviderFloatValue ContextHeightOffset;
	///<summary>context: other end of trace test</summary>
	public UClass Context;
}
