#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
///<summary>Class representing an instance of an Optimus Mesh Deformer.</summary>
public partial class UOptimusDeformerInstance : UMeshDeformerInstance {
// OptimusDeformerInstance
	public bool SetBoolVariable(string InVariableName,bool InValue) { return default; }
	public bool SetIntVariable(string InVariableName,int InValue) { return default; }
	public bool SetFloatVariable(string InVariableName,double InValue) { return default; }
	public bool SetVectorVariable(string InVariableName,FVector InValue) { return default; }
	public bool SetVector4Variable(string InVariableName,FVector4 InValue) { return default; }
	public bool SetTransformVariable(string InVariableName,FTransform InValue) { return default; }
	public TArray<UObject> GetVariables() { return default; }
	public bool EnqueueTriggerGraph(string InTriggerGraphName) { return default; }
	public TWeakObjectPtr<UMeshComponent> MeshComponent;
	public TWeakObjectPtr<UOptimusDeformerInstanceSettings> InstanceSettings;
	public TArray<FOptimusDeformerInstanceExecInfo> ComputeGraphExecInfos;
	public UOptimusVariableContainer Variables;
}
