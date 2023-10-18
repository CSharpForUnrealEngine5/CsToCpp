namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGSubgraph.h")]
public partial class UPCGSubgraphSettings : UPCGBaseSubgraphSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SubgraphInstance</summary>
	public UPCGGraphInstance SubgraphInstance;
	///<summary>SubgraphOverride</summary>
	public UPCGGraphInterface SubgraphOverride;
	///<summary>Subgraph_DEPRECATED</summary>
	public UPCGGraph Subgraph_DEPRECATED;
}
