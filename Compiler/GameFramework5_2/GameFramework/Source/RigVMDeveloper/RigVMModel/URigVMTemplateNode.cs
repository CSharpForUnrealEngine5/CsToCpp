#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Template Node represents an unresolved function.</summary>
[CppInclude("RigVMModel/Nodes/RigVMTemplateNode.h")]
public partial class URigVMTemplateNode : URigVMNode {
	///<summary>Returns the UStruct for this unit node</summary>
	public  UScriptStruct GetScriptStruct() { return default; }
	///<summary>Returns the notation of the node</summary>
	public  string GetNotation() { return default; }
	///<summary>IsSingleton</summary>
	public  bool IsSingleton() { return default; }
	///<summary>returns true if the template node is resolved</summary>
	public  bool IsResolved() { return default; }
	///<summary>returns true if the template is fully unresolved</summary>
	public  bool IsFullyUnresolved() { return default; }
	///<summary>TemplateNotation</summary>
	public string TemplateNotation;
	///<summary>ResolvedFunctionName</summary>
	public string ResolvedFunctionName;
	///<summary>Indicates a preferred permutation using the types of the arguments</summary>
	public TArray<string> PreferredPermutationTypes_DEPRECATED;
	///<summary>PreferredPermutationPairs</summary>
	public TArray<FRigVMTemplatePreferredType> PreferredPermutationPairs;
}
