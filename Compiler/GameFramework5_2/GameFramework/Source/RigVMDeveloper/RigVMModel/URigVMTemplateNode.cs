#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMTemplateNode.h")]
///<summary>The Template Node represents an unresolved function.</summary>
public partial class URigVMTemplateNode : URigVMNode {
// RigVMTemplateNode
	public UObject GetScriptStruct() { return default; }
	public string GetNotation() { return default; }
	public bool IsSingleton() { return default; }
	public bool IsResolved() { return default; }
	public bool IsFullyUnresolved() { return default; }
	public string TemplateNotation;
	public string ResolvedFunctionName;
	public TArray<string> PreferredPermutationTypes_DEPRECATED;
	public TArray<FRigVMTemplatePreferredType> PreferredPermutationPairs;
}
