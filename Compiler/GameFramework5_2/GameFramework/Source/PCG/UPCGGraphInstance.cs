namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
public partial class UPCGGraphInstance : UPCGGraphInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Graph</summary>
	public UPCGGraphInterface Graph;
	///<summary>ParametersOverrides</summary>
	public FPCGOverrideInstancedPropertyBag ParametersOverrides;
}
