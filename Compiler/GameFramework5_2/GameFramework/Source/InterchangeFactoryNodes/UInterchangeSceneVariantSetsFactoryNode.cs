namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSceneVariantSetsFactoryNode.h")]
public partial class UInterchangeSceneVariantSetsFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>This function allow to retrieve the number of translated VariantSets&#39; unique ids for this object.</summary>
	public int GetCustomVariantSetUidCount() { return default; }
	///<summary>This function allow to retrieve all the translated VariantSets&#39; unique ids for this object.</summary>
	public void GetCustomVariantSetUids(TArray<string> OutVariantUids) {}
	///<summary>This function allow to retrieve one translated VariantSet&#39;s unique id for this object.</summary>
	public void GetCustomVariantSetUid(int Index,string OutVariantUid) {}
	///<summary>Add one translated VariantSet&#39;s unique id to this object.</summary>
	public bool AddCustomVariantSetUid(string VariantUid) { return default; }
	///<summary>Remove one translated VariantSet&#39;s unique id from this object.</summary>
	public bool RemoveCustomVariantSetUid(string VariantUid) { return default; }
}
