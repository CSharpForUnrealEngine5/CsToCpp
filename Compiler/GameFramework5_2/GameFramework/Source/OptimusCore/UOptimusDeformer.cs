#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Deformer Graph is an asset that is used to create and control custom deformations on</summary>
[CppInclude("OptimusDeformer.h")]
public partial class UOptimusDeformer : UMeshDeformer {
	public static UClass StaticClass() {return default;}
	///<summary>GetVariables</summary>
	public  TArray<UOptimusVariableDescription> GetVariables() { return default; }
	///<summary>GetResources</summary>
	public  TArray<UOptimusResourceDescription> GetResources() { return default; }
	///<summary>GetComponentBindings</summary>
	public  TArray<UOptimusComponentSourceBinding> GetComponentBindings() { return default; }
	///<summary>Mesh</summary>
	public USkeletalMesh Mesh;
	///<summary>The compute graphs to execute.</summary>
	public TArray<FOptimusComputeGraphInfo> ComputeGraphs;
	///<summary>ActionStack</summary>
	public UOptimusActionStack ActionStack;
	///<summary>Graphs</summary>
	public TArray<UOptimusNodeGraph> Graphs;
	///<summary>Bindings</summary>
	public UOptimusComponentSourceBindingContainer Bindings;
	///<summary>Variables</summary>
	public UOptimusVariableContainer Variables;
	///<summary>Resources</summary>
	public UOptimusResourceContainer Resources;
}
