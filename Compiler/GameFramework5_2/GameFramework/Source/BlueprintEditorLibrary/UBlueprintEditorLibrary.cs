namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorLibrary.h")]
public partial class UBlueprintEditorLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Replace any references of variables with the OldVarName to references of those with the NewVarName if possible</summary>
	public static void ReplaceVariableReferences(UBlueprint Blueprint,FName OldVarName,FName NewVarName) {}
	///<summary>Finds the event graph of the given blueprint. Null if it doesn&#39;t have one. This will only return</summary>
	public static UEdGraph FindEventGraph(UBlueprint Blueprint) { return default; }
	///<summary>Finds the graph with the given name on the blueprint. Null if it doesn&#39;t have one.</summary>
	public static UEdGraph FindGraph(UBlueprint Blueprint,FName GraphName) { return default; }
	///<summary>Replace any old operator nodes (float + float, vector + float, int + vector, etc)</summary>
	public static void UpgradeOperatorNodes(UBlueprint Blueprint) {}
	///<summary>Compiles the given blueprint.</summary>
	public static void CompileBlueprint(UBlueprint Blueprint) {}
	///<summary>Adds a function to the given blueprint</summary>
	public static UEdGraph AddFunctionGraph(UBlueprint Blueprint,string FuncName/*=new FString(TEXT("NewFunction"))*/) { return default; }
	///<summary>Deletes the function of the given name on this blueprint. Does NOT replace function call sites.</summary>
	public static void RemoveFunctionGraph(UBlueprint Blueprint,FName FuncName) {}
	///<summary>Remove any nodes in this blueprint that have no connections made to them.</summary>
	public static void RemoveUnusedNodes(UBlueprint Blueprint) {}
	///<summary>Removes the given graph from the blueprint if possible</summary>
	public static void RemoveGraph(UBlueprint Blueprint,UEdGraph Graph) {}
	///<summary>Attempts to rename the given graph with a new name</summary>
	public static void RenameGraph(UEdGraph Graph,string NewNameStr/*=new FString(TEXT("NewGraph"))*/) {}
	///<summary>Gets the UBlueprint version of the given object if possible.</summary>
	public static UBlueprint GetBlueprintAsset(UObject Object) { return default; }
	///<summary>Attempt to refresh any open blueprint editors for the given asset</summary>
	public static void RefreshOpenEditorsForBlueprint(UBlueprint BP) {}
	///<summary>Refresh any open blueprint editors</summary>
	public static void RefreshAllOpenBlueprintEditors() {}
	///<summary>Attempts to reparent the given blueprint to the new chosen parent class.</summary>
	public static void ReparentBlueprint(UBlueprint Blueprint,UClass NewParentClass) {}
	///<summary>Deletes any unused blueprint created variables the given blueprint.</summary>
	public static int RemoveUnusedVariables(UBlueprint Blueprint) { return default; }
	///<summary>Gets the class generated when this blueprint is compiled</summary>
	public static UClass GeneratedClass(UBlueprint BlueprintObj) { return default; }
	///<summary>Sets &quot;Expose On Spawn&quot; to true/false on a Blueprint variable</summary>
	public static void SetBlueprintVariableExposeOnSpawn(UBlueprint Blueprint,FName VariableName,bool bExposeOnSpawn) {}
	///<summary>Sets &quot;Expose To Cinematics&quot; to true/false on a Blueprint variable</summary>
	public static void SetBlueprintVariableExposeToCinematics(UBlueprint Blueprint,FName VariableName,bool bExposeToCinematics) {}
	///<summary>Sets &quot;Instance Editable&quot; to true/false on a Blueprint variable</summary>
	public static void SetBlueprintVariableInstanceEditable(UBlueprint Blueprint,FName VariableName,bool bInstanceEditable) {}
}
