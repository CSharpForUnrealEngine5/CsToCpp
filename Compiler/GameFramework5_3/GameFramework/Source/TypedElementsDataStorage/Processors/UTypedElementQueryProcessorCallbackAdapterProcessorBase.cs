namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adapts processor queries callback for MASS.</summary>
[CppInclude("Processors/TypedElementProcessorAdaptors.h")]
public partial class UTypedElementQueryProcessorCallbackAdapterProcessorBase : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>Data</summary>
	public FTypedElementQueryProcessorData Data;
}
