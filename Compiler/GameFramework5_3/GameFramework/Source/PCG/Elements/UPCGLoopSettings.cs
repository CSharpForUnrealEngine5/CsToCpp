namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGLoopElement.h")]
public partial class UPCGLoopSettings : UPCGSubgraphSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Comma-separated list of pin names on which we will loop by-element in a step-wise fashion; if more than one is provided, it is expected that they all have the same number of data.</summary>
	public string LoopPins;
}
