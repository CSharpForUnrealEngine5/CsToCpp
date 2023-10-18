namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adapts observer queries callback for MASS.</summary>
[CppInclude("Processors/TypedElementProcessorAdaptors.h")]
public partial class UTypedElementQueryObserverCallbackAdapterProcessorBase : UMassObserverProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>Data</summary>
	public FTypedElementQueryProcessorData Data;
}
