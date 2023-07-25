#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeVariantSetNode.h")]
///<summary>Class to represent a set of VariantSet nodes</summary>
public partial class UInterchangeSceneVariantSetsNode : UInterchangeBaseNode {
// InterchangeSceneVariantSetsNode
	public int GetCustomVariantSetUidCount() { return default; }
	public void GetCustomVariantSetUids(TArray<string> OutVariantUids) {}
	public void GetCustomVariantSetUid(int Index,string OutVariantUid) {}
	public bool AddCustomVariantSetUid(string VariantUid) { return default; }
	public bool RemoveCustomVariantSetUid(string VariantUid) { return default; }
}
