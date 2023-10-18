namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Template Node represents an unresolved function.</summary>
[CppInclude("RigVMModel/Nodes/RigVMTemplateNode.h")]
public partial class URigVMTemplateNode : URigVMNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the UStruct for this unit node</summary>
	public virtual UScriptStruct GetScriptStruct() { return default; }
	///<summary>Returns the notation of the node</summary>
	public virtual FName GetNotation() { return default; }
	///<summary>IsSingleton</summary>
	public virtual bool IsSingleton() { return default; }
	///<summary>returns true if the template node is resolved</summary>
	public bool IsResolved() { return default; }
	///<summary>returns true if the template is fully unresolved</summary>
	public bool IsFullyUnresolved() { return default; }
	///<summary>TemplateNotation</summary>
	public FName TemplateNotation;
	///<summary>ResolvedFunctionName</summary>
	public string ResolvedFunctionName;
	///<summary>Indicates a preferred permutation using the types of the arguments</summary>
	public TArray<string> PreferredPermutationTypes_DEPRECATED;
	///<summary>PreferredPermutationPairs_DEPRECATED</summary>
	public TArray<FRigVMTemplatePreferredType> PreferredPermutationPairs_DEPRECATED;
}
