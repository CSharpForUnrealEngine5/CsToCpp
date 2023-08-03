#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for marshaling compute graph parameters and variables.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceGraph.h")]
public partial class UOptimusGraphDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>MeshComponent</summary>
	public UMeshComponent MeshComponent;
	///<summary>DeformerInstance</summary>
	public UOptimusDeformerInstance DeformerInstance;
	///<summary>Variables</summary>
	public TArray<FOptimusGraphVariableDescription> Variables;
}
