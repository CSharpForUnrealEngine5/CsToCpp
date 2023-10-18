namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base implementation of MetaSound builder</summary>
[CppInclude("MetasoundBuilderSubsystem.h")]
public partial class UMetaSoundBuilderBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a graph input node with the given name, DataType, and sets the graph input to default value.</summary>
	public FMetaSoundBuilderNodeOutputHandle AddGraphInputNode(FName Name,FName DataType,FMetasoundFrontendLiteral DefaultValue,EMetaSoundBuilderResult OutResult,bool bIsConstructorInput/*=false*/) { return default; }
	///<summary>Adds a graph output node with the given name, DataType, and sets output node&#39;s input to default value.</summary>
	public FMetaSoundBuilderNodeInputHandle AddGraphOutputNode(FName Name,FName DataType,FMetasoundFrontendLiteral DefaultValue,EMetaSoundBuilderResult OutResult,bool bIsConstructorOutput/*=false*/) { return default; }
	///<summary>Adds an interface registered with the given name to the graph, adding associated input and output nodes.</summary>
	public void AddInterface(FName InterfaceName,EMetaSoundBuilderResult OutResult) {}
	///<summary>Adds a node to the graph using the provided MetaSound asset as its defining NodeClass.</summary>
	public FMetaSoundNodeHandle AddNode(object /*NodeClass*/ NodeClass,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Adds node referencing the highest native class version of the given class name to the document.</summary>
	public FMetaSoundNodeHandle AddNodeByClassName(FMetasoundFrontendClassName ClassName,int MajorVersion,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Connects node output to a node input. Does *NOT* provide loop detection for performance reasons.  Loop detection is checked on class registration when built or played.</summary>
	public void ConnectNodes(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle,FMetaSoundBuilderNodeInputHandle NodeInputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Connects two nodes using defined MetaSound Interface Bindings registered with the MetaSound Interface registry.</summary>
	public void ConnectNodesByInterfaceBindings(FMetaSoundNodeHandle FromNodeHandle,FMetaSoundNodeHandle ToNodeHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Connects a given node&#39;s outputs to all graph outputs for shared interfaces implemented on both the node&#39;s referenced class and the builder&#39;s MetaSound graph. Returns inputs of connected output nodes.</summary>
	public TArray<FMetaSoundBuilderNodeInputHandle> ConnectNodeOutputsToMatchingGraphInterfaceOutputs(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Connects a given node&#39;s inputs to all graph inputs for shared interfaces implemented on both the node&#39;s referenced class and the builder&#39;s MetaSound graph. Returns outputs of connected input nodes.</summary>
	public TArray<FMetaSoundBuilderNodeOutputHandle> ConnectNodeInputsToMatchingGraphInterfaceInputs(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Connects a given node output to the graph output with the given name.</summary>
	public void ConnectNodeOutputToGraphOutput(FName GraphOutputName,FMetaSoundBuilderNodeOutputHandle NodeOutputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Connects a given node input to the graph input with the given name.</summary>
	public void ConnectNodeInputToGraphInput(FName GraphInputName,FMetaSoundBuilderNodeInputHandle NodeInputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Returns whether node exists.</summary>
	public bool ContainsNode(FMetaSoundNodeHandle Node) { return default; }
	///<summary>Returns whether node input exists.</summary>
	public bool ContainsNodeInput(FMetaSoundBuilderNodeInputHandle Input) { return default; }
	///<summary>Returns whether node output exists.</summary>
	public bool ContainsNodeOutput(FMetaSoundBuilderNodeOutputHandle Output) { return default; }
	///<summary>Disconnects node output to a node input. Returns success if connection was removed, failed if not.</summary>
	public void DisconnectNodes(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle,FMetaSoundBuilderNodeInputHandle NodeInputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes connection to a given node input. Returns success if connection was removed, failed if not.</summary>
	public void DisconnectNodeInput(FMetaSoundBuilderNodeInputHandle NodeInputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes all connections from a given node output. Returns success if all connections were removed, failed if not.</summary>
	public void DisconnectNodeOutput(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Disconnects two nodes using defined MetaSound Interface Bindings registered with the MetaSound Interface registry. Returns success if</summary>
	public void DisconnectNodesByInterfaceBindings(FMetaSoundNodeHandle FromNodeHandle,FMetaSoundNodeHandle ToNodeHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Returns graph input node by the given name if it exists, or an invalid handle if not found.</summary>
	public FMetaSoundNodeHandle FindGraphInputNode(FName InputName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns graph output node by the given name if it exists, or an invalid handle if not found.</summary>
	public FMetaSoundNodeHandle FindGraphOutputNode(FName OutputName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node input by the given name if it exists, or an invalid handle if not found.</summary>
	public FMetaSoundBuilderNodeInputHandle FindNodeInputByName(FMetaSoundNodeHandle NodeHandle,FName InputName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node output by the given name.</summary>
	public TArray<FMetaSoundBuilderNodeInputHandle> FindNodeInputs(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node inputs by the given DataType (ex. &quot;Audio&quot;, &quot;Trigger&quot;, &quot;String&quot;, &quot;Bool&quot;, &quot;Float&quot;, &quot;Int32&quot;, etc.).</summary>
	public TArray<FMetaSoundBuilderNodeInputHandle> FindNodeInputsByDataType(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult,FName DataType) { return default; }
	///<summary>Returns node output by the given name.</summary>
	public FMetaSoundBuilderNodeOutputHandle FindNodeOutputByName(FMetaSoundNodeHandle NodeHandle,FName OutputName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns all node outputs.</summary>
	public TArray<FMetaSoundBuilderNodeOutputHandle> FindNodeOutputs(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node outputs by the given DataType (ex. &quot;Audio&quot;, &quot;Trigger&quot;, &quot;String&quot;, &quot;Bool&quot;, &quot;Float&quot;, &quot;Int32&quot;, etc.).</summary>
	public TArray<FMetaSoundBuilderNodeOutputHandle> FindNodeOutputsByDataType(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult,FName DataType) { return default; }
	///<summary>Returns input nodes associated with a given interface.</summary>
	public TArray<FMetaSoundNodeHandle> FindInterfaceInputNodes(FName InterfaceName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns output nodes associated with a given interface.</summary>
	public TArray<FMetaSoundNodeHandle> FindInterfaceOutputNodes(FName InterfaceName,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns input&#39;s parent node if the input is valid, otherwise returns invalid node handle.</summary>
	public FMetaSoundNodeHandle FindNodeInputParent(FMetaSoundBuilderNodeInputHandle InputHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns output&#39;s parent node if the input is valid, otherwise returns invalid node handle.</summary>
	public FMetaSoundNodeHandle FindNodeOutputParent(FMetaSoundBuilderNodeOutputHandle OutputHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns output&#39;s parent node if the input is valid, otherwise returns invalid node handle.</summary>
	public FMetasoundFrontendVersion FindNodeClassVersion(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node input&#39;s data if valid (including things like name and datatype).</summary>
	public void GetNodeInputData(FMetaSoundBuilderNodeInputHandle InputHandle,FName Name,FName DataType,EMetaSoundBuilderResult OutResult) {}
	///<summary>Returns node input&#39;s literal value if set on graph, otherwise fails and returns default literal.</summary>
	public FMetasoundFrontendLiteral GetNodeInputDefault(FMetaSoundBuilderNodeInputHandle InputHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node input&#39;s class literal value if set, otherwise fails and returns default literal.</summary>
	public FMetasoundFrontendLiteral GetNodeInputClassDefault(FMetaSoundBuilderNodeInputHandle InputHandle,EMetaSoundBuilderResult OutResult) { return default; }
	///<summary>Returns node output&#39;s data if valid (including things like name and datatype).</summary>
	public void GetNodeOutputData(FMetaSoundBuilderNodeOutputHandle OutputHandle,FName Name,FName DataType,EMetaSoundBuilderResult OutResult) {}
	///<summary>Return the asset referenced by this preset builder. Returns nullptr if the builder is not a preset.</summary>
	public UObject GetReferencedPresetAsset() { return default; }
	///<summary>Returns if a given interface is declared.</summary>
	public bool InterfaceIsDeclared(FName InterfaceName) { return default; }
	///<summary>Returns if a given node output and node input are connected.</summary>
	public bool NodesAreConnected(FMetaSoundBuilderNodeOutputHandle OutputHandle,FMetaSoundBuilderNodeInputHandle InputHandle) { return default; }
	///<summary>Returns if a given node input has connections.</summary>
	public bool NodeInputIsConnected(FMetaSoundBuilderNodeInputHandle InputHandle) { return default; }
	///<summary>Returns if a given node output is connected.</summary>
	public bool NodeOutputIsConnected(FMetaSoundBuilderNodeOutputHandle OutputHandle) { return default; }
	///<summary>Returns whether this is a preset.</summary>
	public bool IsPreset() { return default; }
	///<summary>Converts this preset to a fully accessible MetaSound; sets result to succeeded if it was converted successfully and failed if it was not.</summary>
	public void ConvertFromPreset(EMetaSoundBuilderResult OutResult) {}
	///<summary>Convert this builder to a MetaSound source preset with the given referenced source builder</summary>
	public void ConvertToPreset(object /*ReferencedNodeClass*/ ReferencedNodeClass,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes graph input if it exists; sets result to succeeded if it was removed and failed if it was not.</summary>
	public void RemoveGraphInput(FName Name,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes graph output if it exists; sets result to succeeded if it was removed and failed if it was not.</summary>
	public void RemoveGraphOutput(FName Name,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes the interface with the given name from the builder&#39;s MetaSound. Removes any graph inputs</summary>
	public void RemoveInterface(FName InterfaceName,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes node and any associated connections from the builder&#39;s MetaSound.</summary>
	public void RemoveNode(FMetaSoundNodeHandle NodeHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Removes node input literal default if set, reverting the value to be whatever the node class defaults the value to.</summary>
	public void RemoveNodeInputDefault(FMetaSoundBuilderNodeInputHandle InputHandle,EMetaSoundBuilderResult OutResult) {}
	///<summary>Sets the node&#39;s input default value (used if no connection to the given node input is present)</summary>
	public void SetNodeInputDefault(FMetaSoundBuilderNodeInputHandle NodeInputHandle,FMetasoundFrontendLiteral Literal,EMetaSoundBuilderResult OutResult) {}
	///<summary>Sets the input node&#39;s default value, overriding the default provided by the referenced graph if the graph is a preset.</summary>
	public void SetGraphInputDefault(FName InputName,FMetasoundFrontendLiteral Literal,EMetaSoundBuilderResult OutResult) {}
	///<summary>Builder</summary>
	public FMetaSoundFrontendDocumentBuilder Builder;
	///<summary>If true, builder is attached to an existing asset (directly making changes to its document). If false, builder is</summary>
	public bool bIsAttached;
}
