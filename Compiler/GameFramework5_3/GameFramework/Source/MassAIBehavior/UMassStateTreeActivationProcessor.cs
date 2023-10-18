namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor to send the activation signal to the state tree which will execute the first tick</summary>
[CppInclude("MassStateTreeProcessors.h")]
public partial class UMassStateTreeActivationProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
}
