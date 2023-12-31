namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Controller is the sole authority to perform changes</summary>
[CppInclude("RigVMModel/RigVMController.h")]
public partial class URigVMController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the currently edited Graph of this controller.</summary>
	public URigVMGraph GetGraph() { return default; }
	///<summary>Sets the currently edited Graph of this controller.</summary>
	public void SetGraph(URigVMGraph InGraph) {}
	///<summary>Returns the schema used by this controller</summary>
	public URigVMSchema GetSchema() { return default; }
	///<summary>Sets the schema on the controller</summary>
	public void SetSchema(URigVMSchema InSchema) {}
	///<summary>Pushes a new graph to the stack</summary>
	public bool PushGraph(URigVMGraph InGraph,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Pops the last graph off the stack</summary>
	public URigVMGraph PopGraph(bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Returns the top level graph</summary>
	public URigVMGraph GetTopLevelGraph() { return default; }
	///<summary>Returns another controller for a given graph</summary>
	public URigVMController GetControllerForGraph(URigVMGraph InGraph) { return default; }
	///<summary>Enables or disables the error reporting of this Controller.</summary>
	public void EnableReporting(bool bEnabled/*=true*/) {}
	///<summary>Returns true if reporting is enabled</summary>
	public bool IsReportingEnabled() { return default; }
	///<summary>Returns true if the controller is currently transacting</summary>
	public bool IsTransacting() { return default; }
	///<summary>GeneratePythonCommands</summary>
	public TArray<string> GeneratePythonCommands() { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph.</summary>
	public URigVMUnitNode AddUnitNode(UScriptStruct InScriptStruct,FName InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph given its struct object path name.</summary>
	public URigVMUnitNode AddUnitNodeFromStructPath(string InScriptStructPath,FName InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph.</summary>
	public URigVMUnitNode AddUnitNodeWithDefaults(UScriptStruct InScriptStruct,string InDefaults,FName InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph.</summary>
	public bool SetUnitNodeDefaults(URigVMUnitNode InNode,string InDefaults,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Variable Node to the edited Graph.</summary>
	public URigVMVariableNode AddVariableNode(FName InVariableName,string InCPPType,UObject InCPPTypeObject,bool bIsGetter,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Variable Node to the edited Graph given a struct object path name.</summary>
	public URigVMVariableNode AddVariableNodeFromObjectPath(FName InVariableName,string InCPPType,string InCPPTypeObjectPath,bool bIsGetter,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Refreshes the variable node with the new data</summary>
	public void RefreshVariableNode(FName InNodeName,FName InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo,bool bSetupOrphanPins/*=true*/) {}
	///<summary>Refreshes the variable node with the new data</summary>
	public URigVMVariableNode ReplaceParameterNodeWithVariable(FName InNodeName,FName InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo) { return default; }
	///<summary>Turns a resolved templated node(s) back into its template.</summary>
	public bool UnresolveTemplateNodes(TArray<FName> InNodeNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Upgrades a set of nodes with each corresponding next known version</summary>
	public TArray<URigVMNode> UpgradeNodes(TArray<FName> InNodeNames,bool bRecursive/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Parameter Node to the edited Graph.</summary>
	public URigVMParameterNode AddParameterNode(FName InParameterName,string InCPPType,UObject InCPPTypeObject,bool bIsInput,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Parameter Node to the edited Graph given a struct object path name.</summary>
	public URigVMParameterNode AddParameterNodeFromObjectPath(FName InParameterName,string InCPPType,string InCPPTypeObjectPath,bool bIsInput,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Comment Node to the edited Graph.</summary>
	public URigVMCommentNode AddCommentNode(string InCommentText,FVector2D InPosition/*=FVector2D.ZeroVector*/,FVector2D InSize/*=new FVector2D(400.0f,300.0f)*/,FLinearColor InColor/*=FLinearColor.Black*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Reroute Node on an existing Link to the edited Graph.</summary>
	public URigVMRerouteNode AddRerouteNodeOnLink(URigVMLink InLink,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Reroute Node on an existing Link to the edited Graph given the Link&#39;s string representation.</summary>
	public URigVMRerouteNode AddRerouteNodeOnLinkPath(string InLinkPinPathRepresentation,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Reroute Node on an existing Pin to the editor Graph.</summary>
	public URigVMRerouteNode AddRerouteNodeOnPin(string InPinPath,bool bAsInput,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a free Reroute Node</summary>
	public URigVMRerouteNode AddFreeRerouteNode(string InCPPType,FName InCPPTypeObjectPath,bool bIsConstant,FName InCustomWidgetName,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Adds a branch node to the graph.</summary>
	public URigVMNode AddBranchNode(FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds an if node to the graph.</summary>
	public URigVMNode AddIfNode(string InCPPType,FName InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>AddIfNodeFromStruct</summary>
	public URigVMNode AddIfNodeFromStruct(UScriptStruct InScriptStruct,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Adds a select node to the graph.</summary>
	public URigVMNode AddSelectNode(string InCPPType,FName InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>AddSelectNodeFromStruct</summary>
	public URigVMNode AddSelectNodeFromStruct(UScriptStruct InScriptStruct,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Adds a template node to the graph.</summary>
	public URigVMTemplateNode AddTemplateNode(FName InNotation,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Returns all registered unit structs</summary>
	public static TArray<UScriptStruct> GetRegisteredUnitStructs() { return default; }
	///<summary>Returns all registered template notations</summary>
	public static TArray<string> GetRegisteredTemplates() { return default; }
	///<summary>Returns all supported unit structs for a given template notation</summary>
	public static TArray<UScriptStruct> GetUnitStructsForTemplate(FName InNotation) { return default; }
	///<summary>Returns the template for a given function (or an empty string)</summary>
	public static string GetTemplateForUnitStruct(UScriptStruct InFunction,string InMethodName/*=TEXT("Execute")*/) { return default; }
	///<summary>Resolves a wildcard pin on any node</summary>
	public bool ResolveWildCardPin(string InPinPath,string InCPPType,FName InCPPTypeObjectPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph as an injected node</summary>
	public URigVMInjectionInfo AddInjectedNode(string InPinPath,bool bAsInput,UScriptStruct InScriptStruct,FName InMethodName,FName InInputPinName,FName InOutputPinName,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Function / Struct Node to the edited Graph as an injected node</summary>
	public URigVMInjectionInfo AddInjectedNodeFromStructPath(string InPinPath,bool bAsInput,string InScriptStructPath,FName InMethodName,FName InInputPinName,FName InOutputPinName,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Removes an injected node</summary>
	public bool RemoveInjectedNode(string InPinPath,bool bAsInput,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Ejects the last injected node on a pin</summary>
	public URigVMNode EjectNodeFromPin(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds an enum node to the graph</summary>
	public URigVMEnumNode AddEnumNode(FName InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a Array Node to the edited Graph.</summary>
	public URigVMNode AddArrayNode(ERigVMOpCode InOpCode,string InCPPType,UObject InCPPTypeObject,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsPatching/*=false*/) { return default; }
	///<summary>Adds a Array Node to the edited Graph given a struct object path name.</summary>
	public URigVMNode AddArrayNodeFromObjectPath(ERigVMOpCode InOpCode,string InCPPType,string InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsPatching/*=false*/) { return default; }
	///<summary>Adds an entry invocation node</summary>
	public URigVMInvokeEntryNode AddInvokeEntryNode(FName InEntryName,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a decorator to a node</summary>
	public FName AddDecorator(FName InNodeName,FName InDecoratorTypeObjectPath,FName InDecoratorName/*=NAME_None*/,string InDefaultValue/*=TEXT("")*/,int InPinIndex/*=-1*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes a decorator from a node</summary>
	public bool RemoveDecorator(FName InNodeName,FName InDecoratorName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Un-does the last action on the stack.</summary>
	public bool Undo() { return default; }
	///<summary>Re-does the last action on the stack.</summary>
	public bool Redo() { return default; }
	///<summary>Opens an undo bracket / scoped transaction for</summary>
	public bool OpenUndoBracket(string InTitle) { return default; }
	///<summary>Closes an undo bracket / scoped transaction.</summary>
	public bool CloseUndoBracket() { return default; }
	///<summary>Cancels an undo bracket / scoped transaction.</summary>
	public bool CancelUndoBracket() { return default; }
	///<summary>Exports the given nodes as text</summary>
	public string ExportNodesToText(TArray<FName> InNodeNames,bool bIncludeExteriorLinks/*=false*/) { return default; }
	///<summary>Exports the selected nodes as text</summary>
	public string ExportSelectedNodesToText(bool bIncludeExteriorLinks/*=false*/) { return default; }
	///<summary>Exports the given nodes as text</summary>
	public bool CanImportNodesFromText(string InText) { return default; }
	///<summary>Exports the given nodes as text</summary>
	public TArray<FName> ImportNodesFromText(string InText,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommands/*=false*/) { return default; }
	///<summary>Copies a function declaration into this graph&#39;s local function library</summary>
	public URigVMLibraryNode LocalizeFunctionFromPath(string InHostPath,FName InFunctionName,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>LocalizeFunction</summary>
	public URigVMLibraryNode LocalizeFunction(FRigVMGraphFunctionIdentifier InFunctionDefinition,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Copies a series of function declaratioms into this graph&#39;s local function library</summary>
	public TMap<FRigVMGraphFunctionIdentifier,URigVMLibraryNode> LocalizeFunctions(TArray<FRigVMGraphFunctionIdentifier> InFunctionDefinitions,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Turns a series of nodes into a Collapse node</summary>
	public URigVMCollapseNode CollapseNodes(TArray<FName> InNodeNames,string InCollapseNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsAggregate/*=false*/) { return default; }
	///<summary>Turns a library node into its contained nodes</summary>
	public TArray<URigVMNode> ExpandLibraryNode(FName InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Turns a collapse node into a function node</summary>
	public FName PromoteCollapseNodeToFunctionReferenceNode(FName InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,string InExistingFunctionDefinitionPath/*=TEXT("")*/) { return default; }
	///<summary>Turns a collapse node into a function node</summary>
	public FName PromoteFunctionReferenceNodeToCollapseNode(FName InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bRemoveFunctionDefinition/*=false*/) { return default; }
	///<summary>Removes a node from the graph</summary>
	public bool RemoveNode(URigVMNode InNode,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes a node from the graph given the node&#39;s name.</summary>
	public bool RemoveNodeByName(FName InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes a list of nodes from the graph</summary>
	public bool RemoveNodes(TArray<URigVMNode> InNodes,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes a list of nodes from the graph given the names</summary>
	public bool RemoveNodesByName(TArray<FName> InNodeNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Renames a node in the graph</summary>
	public bool RenameNode(URigVMNode InNode,FName InNewName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Selects a single node in the graph.</summary>
	public bool SelectNode(URigVMNode InNode,bool bSelect/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Selects a single node in the graph by name.</summary>
	public bool SelectNodeByName(FName InNodeName,bool bSelect/*=true*/,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Deselects all currently selected nodes in the graph.</summary>
	public bool ClearNodeSelection(bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Selects the nodes given the selection</summary>
	public bool SetNodeSelection(TArray<FName> InNodeNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the position of a node in the graph.</summary>
	public bool SetNodePosition(URigVMNode InNode,FVector2D InPosition,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the position of a node in the graph by name.</summary>
	public bool SetNodePositionByName(FName InNodeName,FVector2D InPosition,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the size of a node in the graph.</summary>
	public bool SetNodeSize(URigVMNode InNode,FVector2D InSize,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the size of a node in the graph by name.</summary>
	public bool SetNodeSizeByName(FName InNodeName,FVector2D InSize,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the color of a node in the graph.</summary>
	public bool SetNodeColor(URigVMNode InNode,FLinearColor InColor,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the color of a node in the graph by name.</summary>
	public bool SetNodeColorByName(FName InNodeName,FLinearColor InColor,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	///<summary>Sets the category of a node in the graph.</summary>
	public bool SetNodeCategory(URigVMCollapseNode InNode,string InCategory,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the category of a node in the graph.</summary>
	public bool SetNodeCategoryByName(FName InNodeName,string InCategory,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	///<summary>Sets the keywords of a node in the graph.</summary>
	public bool SetNodeKeywords(URigVMCollapseNode InNode,string InKeywords,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the keywords of a node in the graph.</summary>
	public bool SetNodeKeywordsByName(FName InNodeName,string InKeywords,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	///<summary>Sets the function description of a node in the graph.</summary>
	public bool SetNodeDescription(URigVMCollapseNode InNode,string InDescription,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the keywords of a node in the graph.</summary>
	public bool SetNodeDescriptionByName(FName InNodeName,string InDescription,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	///<summary>Sets the comment text and properties of a comment node in the graph.</summary>
	public bool SetCommentText(URigVMNode InNode,string InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the comment text and properties of a comment node in the graph by name.</summary>
	public bool SetCommentTextByName(FName InNodeName,string InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Renames a variable in the graph.</summary>
	public bool RenameVariable(FName InOldName,FName InNewName,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Renames a parameter in the graph.</summary>
	public bool RenameParameter(FName InOldName,FName InNewName,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Sets the pin to be expanded or not</summary>
	public bool SetPinExpansion(string InPinPath,bool bIsExpanded,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the pin to be watched (or not)</summary>
	public bool SetPinIsWatched(string InPinPath,bool bIsWatched,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Returns the default value of a pin given its pinpath.</summary>
	public string GetPinDefaultValue(string InPinPath) { return default; }
	///<summary>Sets the default value of a pin given its pinpath.</summary>
	public bool SetPinDefaultValue(string InPinPath,string InDefaultValue,bool bResizeArrays/*=true*/,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Resets the default value of a pin given its pinpath.</summary>
	public bool ResetPinDefaultValue(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>AddAggregatePin</summary>
	public string AddAggregatePin(string InNodeName,string InPinName,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>RemoveAggregatePin</summary>
	public bool RemoveAggregatePin(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds an array element pin to the end of an array pin.</summary>
	public string AddArrayPin(string InArrayPinPath,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Duplicates an array element pin.</summary>
	public string DuplicateArrayPin(string InArrayElementPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Inserts an array element pin into an array pin.</summary>
	public string InsertArrayPin(string InArrayPinPath,int InIndex/*=-1*/,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes an array element pin from an array pin.</summary>
	public bool RemoveArrayPin(string InArrayElementPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes all (but one) array element pin from an array pin.</summary>
	public bool ClearArrayPin(string InArrayPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the size of the array pin</summary>
	public bool SetArrayPinSize(string InArrayPinPath,int InSize,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Binds a pin to a variable (or removes the binding given NAME_None)</summary>
	public bool BindPinToVariable(string InPinPath,string InNewBoundVariablePath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes the binging of a pin to a variable</summary>
	public bool UnbindPinFromVariable(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Turns a variable node into one or more bindings</summary>
	public bool MakeBindingsFromVariableNode(FName InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Turns a binding to a variable node</summary>
	public bool MakeVariableNodeFromBinding(string InPinPath,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Promotes a pin to a variable</summary>
	public bool PromotePinToVariable(string InPinPath,bool bCreateVariableNode,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a link to the graph.</summary>
	public bool AddLink(string InOutputPinPath,string InInputPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,ERigVMPinDirection InUserDirection/*=ERigVMPinDirection.Output*/,bool bCreateCastNode/*=false*/) { return default; }
	///<summary>Removes a link from the graph.</summary>
	public bool BreakLink(string InOutputPinPath,string InInputPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes all links on a given pin from the graph.</summary>
	public bool BreakAllLinks(string InPinPath,bool bAsInput/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds an exposed pin to the graph controlled by this</summary>
	public FName AddExposedPin(FName InPinName,ERigVMPinDirection InDirection,string InCPPType,FName InCPPTypeObjectPath,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes an exposed pin from the graph controlled by this</summary>
	public bool RemoveExposedPin(FName InPinName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Renames an exposed pin in the graph controlled by this</summary>
	public bool RenameExposedPin(FName InOldPinName,FName InNewPinName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Changes the type of an exposed pin in the graph controlled by this</summary>
	public bool ChangeExposedPinType(FName InPinName,string InCPPType,FName InCPPTypeObjectPath,bool bSetupUndoRedo,bool bSetupOrphanPins/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the index for an exposed pin. This can be used to move the pin up and down on the node.</summary>
	public bool SetExposedPinIndex(FName InPinName,int InNewIndex,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Adds a function reference / invocation to the graph</summary>
	public URigVMFunctionReferenceNode AddFunctionReferenceNodeFromDescription(FRigVMGraphFunctionHeader InFunctionDefinition,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>AddExternalFunctionReferenceNode</summary>
	public URigVMFunctionReferenceNode AddExternalFunctionReferenceNode(string InHostPath,FName InFunctionName,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>AddFunctionReferenceNode</summary>
	public URigVMFunctionReferenceNode AddFunctionReferenceNode(URigVMLibraryNode InFunctionDefinition,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the remapped variable on a function reference node</summary>
	public bool SetRemappedVariable(URigVMFunctionReferenceNode InFunctionRefNode,FName InInnerVariableName,FName InOuterVariableName,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Adds a function definition to a function library graph</summary>
	public URigVMLibraryNode AddFunctionToLibrary(FName InFunctionName,bool bMutable,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Removes a function from a function library graph</summary>
	public bool RemoveFunctionFromLibrary(FName InFunctionName,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Renames a function in the function library</summary>
	public bool RenameFunction(FName InOldFunctionName,FName InNewFunctionName,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Mark a function as public/private in the function library</summary>
	public bool MarkFunctionAsPublic(FName InFunctionName,bool bInIsPublic,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Returns true if a function is marked as public in the function library</summary>
	public bool IsFunctionPublic(FName InFunctionName) { return default; }
	///<summary>Add a local variable to the graph</summary>
	public FRigVMGraphVariableDescription AddLocalVariable(FName InVariableName,string InCPPType,UObject InCPPTypeObject,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Add a local variable to the graph given a struct object path name.</summary>
	public FRigVMGraphVariableDescription AddLocalVariableFromObjectPath(FName InVariableName,string InCPPType,string InCPPTypeObjectPath,string InDefaultValue,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Remove a local variable from the graph</summary>
	public bool RemoveLocalVariable(FName InVariableName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Rename a local variable from the graph</summary>
	public bool RenameLocalVariable(FName InVariableName,FName InNewVariableName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>Sets the type of the local variable</summary>
	public bool SetLocalVariableType(FName InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>SetLocalVariableTypeFromObjectPath</summary>
	public bool SetLocalVariableTypeFromObjectPath(FName InVariableName,string InCPPType,string InCPPTypeObjectPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>SetLocalVariableDefaultValue</summary>
	public bool SetLocalVariableDefaultValue(FName InVariableName,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	///<summary>creates the options struct for a given workflow</summary>
	public URigVMUserWorkflowOptions MakeOptionsForWorkflow(UObject InSubject,FRigVMUserWorkflow InWorkflow) { return default; }
	///<summary>performs all actions representing the workflow</summary>
	public bool PerformUserWorkflow(FRigVMUserWorkflow InWorkflow,URigVMUserWorkflowOptions InOptions,bool bSetupUndoRedo/*=true*/) { return default; }
	///<summary>Helper function to disable a series of checks that can be ignored during a unit test</summary>
	public void SetIsRunningUnitTest(bool bIsRunning) {}
	///<summary>ModifiedEventDynamic</summary>
	public FRigVMGraphModifiedDynamicEvent ModifiedEventDynamic;
	///<summary>Graphs</summary>
	public TArray<URigVMGraph> Graphs;
	///<summary>SchemaPtr</summary>
	public URigVMSchema SchemaPtr;
}
