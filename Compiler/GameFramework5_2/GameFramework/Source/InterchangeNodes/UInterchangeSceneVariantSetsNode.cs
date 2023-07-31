#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to represent a set of VariantSet nodes</summary>
[CppInclude("InterchangeVariantSetNode.h")]
public partial class UInterchangeSceneVariantSetsNode : UInterchangeBaseNode {
	///<summary>This function allow to retrieve the number of VariantSets for this object.</summary>
	public  int GetCustomVariantSetUidCount() { return default; }
	///<summary>This function allow to retrieve all the VariantSets&#39; unique ids for this object.</summary>
	public  void GetCustomVariantSetUids(TArray<string> OutVariantUids) {}
	///<summary>This function allow to retrieve one VariantSet&#39;s unique id for this object.</summary>
	public  void GetCustomVariantSetUid(int Index,string OutVariantUid) {}
	///<summary>Add one VariantSet&#39;s unique id to this object.</summary>
	public  bool AddCustomVariantSetUid(string VariantUid) { return default; }
	///<summary>Remove one VariantSet&#39;s unique id from this object.</summary>
	public  bool RemoveCustomVariantSetUid(string VariantUid) { return default; }
}
