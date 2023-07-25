#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeVariantSetNode.h")]
///<summary>Class to represent a set of variants</summary>
public partial class UInterchangeVariantSetNode : UInterchangeBaseNode {
// InterchangeVariantSetNode
	public bool GetCustomDisplayText(string AttributeValue) { return default; }
	public bool SetCustomDisplayText(string AttributeValue) { return default; }
	public bool GetCustomVariantsPayloadKey(string PayloadKey) { return default; }
	public bool SetCustomVariantsPayloadKey(string PayloadKey) { return default; }
	public int GetCustomDependencyUidCount() { return default; }
	public void GetCustomDependencyUids(TArray<string> OutDependencyUids) {}
	public void GetCustomDependencyUid(int Index,string OutDependencyUid) {}
	public bool AddCustomDependencyUid(string DependencyUid) { return default; }
	public bool RemoveCustomDependencyUid(string DependencyUid) { return default; }
}
