namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mass verifies that queries that are used by processors are on the processor themselves. It does this by taking the address of the query</summary>
[CppInclude("Processors/TypedElementProcessorAdaptors.h")]
public partial class UTypedElementQueryObserverCallbackAdapterProcessorWith1Subquery : UTypedElementQueryObserverCallbackAdapterProcessorBase {
	public static UClass StaticClass() {return default;}
	///<summary>NativeSubqueries</summary>
	public FMassEntityQuery NativeSubqueries;
}
