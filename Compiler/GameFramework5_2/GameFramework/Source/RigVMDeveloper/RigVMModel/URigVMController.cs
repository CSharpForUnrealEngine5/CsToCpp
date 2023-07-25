#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMController.h")]
///<summary>The Controller is the sole authority to perform changes</summary>
public partial class URigVMController : UObject {
// RigVMController
	public UObject GetGraph() { return default; }
	public void SetGraph(UObject InGraph) {}
	public void PushGraph(UObject InGraph,bool bSetupUndoRedo/*=true*/) {}
	public UObject PopGraph(bool bSetupUndoRedo/*=true*/) { return default; }
	public UObject GetTopLevelGraph() { return default; }
	public void EnableReporting(bool bEnabled/*=true*/) {}
	public bool IsReportingEnabled() { return default; }
	public TArray<string> GeneratePythonCommands() { return default; }
	public UObject AddUnitNode(UObject InScriptStruct,string InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddUnitNodeFromStructPath(string InScriptStructPath,string InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddUnitNodeWithDefaults(UObject InScriptStruct,string InDefaults,string InMethodName/*=TEXT("Execute")*/,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetUnitNodeDefaults(UObject InNode,string InDefaults,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddVariableNode(string InVariableName,string InCPPType,UObject InCPPTypeObject,bool bIsGetter,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddVariableNodeFromObjectPath(string InVariableName,string InCPPType,string InCPPTypeObjectPath,bool bIsGetter,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public void RefreshVariableNode(string InNodeName,string InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo,bool bSetupOrphanPins/*=true*/) {}
	public UObject ReplaceParameterNodeWithVariable(string InNodeName,string InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo) { return default; }
	public bool UnresolveTemplateNodes(TArray<string> InNodeNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TArray<UObject> UpgradeNodes(TArray<string> InNodeNames,bool bRecursive/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddParameterNode(string InParameterName,string InCPPType,UObject InCPPTypeObject,bool bIsInput,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddParameterNodeFromObjectPath(string InParameterName,string InCPPType,string InCPPTypeObjectPath,bool bIsInput,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddCommentNode(string InCommentText,FVector2D InPosition/*=FVector2D.ZeroVector*/,FVector2D InSize/*=new FVector2D(400.0f,300.0f)*/,FLinearColor InColor/*=FLinearColor.Black*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddRerouteNodeOnLink(UObject InLink,bool bShowAsFullNode,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddRerouteNodeOnLinkPath(string InLinkPinPathRepresentation,bool bShowAsFullNode,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddRerouteNodeOnPin(string InPinPath,bool bAsInput,bool bShowAsFullNode,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddFreeRerouteNode(bool bShowAsFullNode,string InCPPType,string InCPPTypeObjectPath,bool bIsConstant,string InCustomWidgetName,string InDefaultValue,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	public UObject AddBranchNode(FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddIfNode(string InCPPType,string InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddIfNodeFromStruct(UObject InScriptStruct,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	public UObject AddSelectNode(string InCPPType,string InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddSelectNodeFromStruct(UObject InScriptStruct,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	public UObject AddTemplateNode(string InNotation,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TArray<UObject> GetRegisteredUnitStructs() { return default; }
	public TArray<string> GetRegisteredTemplates() { return default; }
	public TArray<UObject> GetUnitStructsForTemplate(string InNotation) { return default; }
	public string GetTemplateForUnitStruct(UObject InFunction,string InMethodName/*=TEXT("Execute")*/) { return default; }
	public bool ResolveWildCardPin(string InPinPath,string InCPPType,string InCPPTypeObjectPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddInjectedNode(string InPinPath,bool bAsInput,UObject InScriptStruct,string InMethodName,string InInputPinName,string InOutputPinName,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddInjectedNodeFromStructPath(string InPinPath,bool bAsInput,string InScriptStructPath,string InMethodName,string InInputPinName,string InOutputPinName,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool RemoveInjectedNode(string InPinPath,bool bAsInput,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject EjectNodeFromPin(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddEnumNode(string InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddArrayNode(ERigVMOpCode InOpCode,string InCPPType,UObject InCPPTypeObject,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsPatching/*=false*/) { return default; }
	public UObject AddArrayNodeFromObjectPath(ERigVMOpCode InOpCode,string InCPPType,string InCPPTypeObjectPath,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsPatching/*=false*/) { return default; }
	public UObject AddInvokeEntryNode(string InEntryName,FVector2D InPosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool Undo() { return default; }
	public bool Redo() { return default; }
	public bool OpenUndoBracket(string InTitle) { return default; }
	public bool CloseUndoBracket() { return default; }
	public bool CancelUndoBracket() { return default; }
	public string ExportNodesToText(TArray<string> InNodeNames) { return default; }
	public string ExportSelectedNodesToText() { return default; }
	public bool CanImportNodesFromText(string InText) { return default; }
	public TArray<string> ImportNodesFromText(string InText,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommands/*=false*/) { return default; }
	public UObject LocalizeFunctionFromPath(string InHostPath,string InFunctionName,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject LocalizeFunction(FRigVMGraphFunctionIdentifier InFunctionDefinition,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public TMap<FRigVMGraphFunctionIdentifier,UObject> LocalizeFunctions(TArray<FRigVMGraphFunctionIdentifier> InFunctionDefinitions,bool bLocalizeDependentPrivateFunctions/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject CollapseNodes(TArray<string> InNodeNames,string InCollapseNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bIsAggregate/*=false*/) { return default; }
	public TArray<UObject> ExpandLibraryNode(string InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string PromoteCollapseNodeToFunctionReferenceNode(string InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,string InExistingFunctionDefinitionPath/*=TEXT("")*/) { return default; }
	public string PromoteFunctionReferenceNodeToCollapseNode(string InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bRemoveFunctionDefinition/*=false*/) { return default; }
	public bool RemoveNode(UObject InNode,bool bSetupUndoRedo/*=true*/,bool bRecursive/*=false*/,bool bPrintPythonCommand/*=false*/,bool bRelinkPins/*=false*/) { return default; }
	public bool RemoveNodeByName(string InNodeName,bool bSetupUndoRedo/*=true*/,bool bRecursive/*=false*/,bool bPrintPythonCommand/*=false*/,bool bRelinkPins/*=false*/) { return default; }
	public bool RenameNode(UObject InNode,string InNewName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SelectNode(UObject InNode,bool bSelect/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SelectNodeByName(string InNodeName,bool bSelect/*=true*/,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool ClearNodeSelection(bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeSelection(TArray<string> InNodeNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodePosition(UObject InNode,FVector2D InPosition,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodePositionByName(string InNodeName,FVector2D InPosition,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeSize(UObject InNode,FVector2D InSize,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeSizeByName(string InNodeName,FVector2D InSize,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeColor(UObject InNode,FLinearColor InColor,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeColorByName(string InNodeName,FLinearColor InColor,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	public bool SetNodeCategory(UObject InNode,string InCategory,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeCategoryByName(string InNodeName,string InCategory,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	public bool SetNodeKeywords(UObject InNode,string InKeywords,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeKeywordsByName(string InNodeName,string InKeywords,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	public bool SetNodeDescription(UObject InNode,string InDescription,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetNodeDescriptionByName(string InNodeName,string InDescription,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/) { return default; }
	public bool SetCommentText(UObject InNode,string InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetCommentTextByName(string InNodeName,string InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetRerouteCompactness(UObject InNode,bool bShowAsFullNode,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetRerouteCompactnessByName(string InNodeName,bool bShowAsFullNode,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool RenameVariable(string InOldName,string InNewName,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool RenameParameter(string InOldName,string InNewName,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool SetPinExpansion(string InPinPath,bool bIsExpanded,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetPinIsWatched(string InPinPath,bool bIsWatched,bool bSetupUndoRedo/*=true*/) { return default; }
	public string GetPinDefaultValue(string InPinPath) { return default; }
	public bool SetPinDefaultValue(string InPinPath,string InDefaultValue,bool bResizeArrays/*=true*/,bool bSetupUndoRedo/*=true*/,bool bMergeUndoAction/*=false*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool ResetPinDefaultValue(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string AddAggregatePin(string InNodeName,string InPinName,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RemoveAggregatePin(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string AddArrayPin(string InArrayPinPath,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string DuplicateArrayPin(string InArrayElementPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string InsertArrayPin(string InArrayPinPath,int InIndex/*=-1*/,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RemoveArrayPin(string InArrayElementPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool ClearArrayPin(string InArrayPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetArrayPinSize(string InArrayPinPath,int InSize,string InDefaultValue/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool BindPinToVariable(string InPinPath,string InNewBoundVariablePath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool UnbindPinFromVariable(string InPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool MakeBindingsFromVariableNode(string InNodeName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool MakeVariableNodeFromBinding(string InPinPath,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool PromotePinToVariable(string InPinPath,bool bCreateVariableNode,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool AddLink(string InOutputPinPath,string InInputPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,ERigVMPinDirection InUserDirection/*=ERigVMPinDirection.Output*/,bool bCreateCastNode/*=false*/) { return default; }
	public bool BreakLink(string InOutputPinPath,string InInputPinPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool BreakAllLinks(string InPinPath,bool bAsInput/*=true*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public string AddExposedPin(string InPinName,ERigVMPinDirection InDirection,string InCPPType,string InCPPTypeObjectPath,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RemoveExposedPin(string InPinName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RenameExposedPin(string InOldPinName,string InNewPinName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool ChangeExposedPinType(string InPinName,string InCPPType,string InCPPTypeObjectPath,bool bSetupUndoRedo,bool bSetupOrphanPins/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetExposedPinIndex(string InPinName,int InNewIndex,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddFunctionReferenceNodeFromDescription(FRigVMGraphFunctionHeader InFunctionDefinition,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/,bool bAllowPrivateFunctions/*=false*/) { return default; }
	public UObject AddExternalFunctionReferenceNode(string InHostPath,string InFunctionName,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject AddFunctionReferenceNode(UObject InFunctionDefinition,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,string InNodeName/*=TEXT("")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetRemappedVariable(UObject InFunctionRefNode,string InInnerVariableName,string InOuterVariableName,bool bSetupUndoRedo/*=true*/) { return default; }
	public UObject AddFunctionToLibrary(string InFunctionName,bool bMutable,FVector2D InNodePosition/*=FVector2D.ZeroVector*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RemoveFunctionFromLibrary(string InFunctionName,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool RenameFunction(string InOldFunctionName,string InNewFunctionName,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool MarkFunctionAsPublic(string InFunctionName,bool bInIsPublic,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool IsFunctionPublic(string InFunctionName) { return default; }
	public FRigVMGraphVariableDescription AddLocalVariable(string InVariableName,string InCPPType,UObject InCPPTypeObject,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public FRigVMGraphVariableDescription AddLocalVariableFromObjectPath(string InVariableName,string InCPPType,string InCPPTypeObjectPath,string InDefaultValue,bool bSetupUndoRedo/*=true*/) { return default; }
	public bool RemoveLocalVariable(string InVariableName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool RenameLocalVariable(string InVariableName,string InNewVariableName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetLocalVariableType(string InVariableName,string InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetLocalVariableTypeFromObjectPath(string InVariableName,string InCPPType,string InCPPTypeObjectPath,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public bool SetLocalVariableDefaultValue(string InVariableName,string InDefaultValue,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=false*/) { return default; }
	public UObject MakeOptionsForWorkflow(UObject InSubject,FRigVMUserWorkflow InWorkflow) { return default; }
	public bool PerformUserWorkflow(FRigVMUserWorkflow InWorkflow,UObject InOptions,bool bSetupUndoRedo/*=true*/) { return default; }
	public void SetIsRunningUnitTest(bool bIsRunning) {}
	public FRigVMGraphModifiedDynamicEvent ModifiedEventDynamic;
	public TArray<URigVMGraph> Graphs;
	public URigVMActionStack ActionStack;
}
