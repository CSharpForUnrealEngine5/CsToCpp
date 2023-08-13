namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class representing an instance of an Optimus Mesh Deformer.</summary>
[CppInclude("OptimusDeformerInstance.h")]
public partial class UOptimusDeformerInstance : UMeshDeformerInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Set the value of a boolean variable.</summary>
	public bool SetBoolVariable(string InVariableName,bool InValue) { return default; }
	///<summary>Set the value of an integer variable.</summary>
	public bool SetIntVariable(string InVariableName,int InValue) { return default; }
	///<summary>Set the value of a float variable.</summary>
	public bool SetFloatVariable(string InVariableName,double InValue) { return default; }
	///<summary>Set the value of a 3-vector variable.</summary>
	public bool SetVectorVariable(string InVariableName,FVector InValue) { return default; }
	///<summary>Set the value of a 4-vector variable.</summary>
	public bool SetVector4Variable(string InVariableName,FVector4 InValue) { return default; }
	///<summary>Set the value of a transform variable.</summary>
	public bool SetTransformVariable(string InVariableName,FTransform InValue) { return default; }
	///<summary>Get an array containing all the variables.</summary>
	public TArray<UOptimusVariableDescription> GetVariables() { return default; }
	///<summary>Trigger a named trigger graph to run on the next tick</summary>
	public bool EnqueueTriggerGraph(string InTriggerGraphName) { return default; }
	///<summary>The Mesh Component that owns this Mesh Deformer Instance.</summary>
	public TWeakObjectPtr<UMeshComponent> MeshComponent;
	///<summary>The settings for this Mesh Deformer Instance.</summary>
	public TWeakObjectPtr<UOptimusDeformerInstanceSettings> InstanceSettings;
	///<summary>An array of state. One for each graph owned by the deformer.</summary>
	public TArray<FOptimusDeformerInstanceExecInfo> ComputeGraphExecInfos;
	///<summary>Storage for variable data.</summary>
	public UOptimusVariableContainer Variables;
}
