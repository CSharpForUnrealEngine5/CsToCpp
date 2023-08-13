namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
public partial class UPCGGraphInterface : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Return the underlying PCG Graph for this interface.</summary>
	public UPCGGraph GetMutablePCGGraph() { return default; }
	///<summary>Return the underlying PCG Graph for this interface.</summary>
	public UPCGGraph GetConstPCGGraph() { return default; }
}
