#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to represent a set of variants</summary>
[CppInclude("InterchangeVariantSetNode.h")]
public partial class UInterchangeVariantSetNode : UInterchangeBaseNode {
	///<summary>This function allow to retrieve the text which is displayed in the UI for this VariantSet.</summary>
	public  bool GetCustomDisplayText(string AttributeValue) { return default; }
	///<summary>This function allow to set the text to be displayed in the UI for this VariantSet.</summary>
	public  bool SetCustomDisplayText(string AttributeValue) { return default; }
	///<summary>Get the payload key needed to retrieve the variants for this VariantSet.</summary>
	public  bool GetCustomVariantsPayloadKey(string PayloadKey) { return default; }
	///<summary>Set the payload key needed to retrieve the variants for this VariantSet.</summary>
	public  bool SetCustomVariantsPayloadKey(string PayloadKey) { return default; }
	///<summary>This function allow to retrieve the number of translated node&#39;s unique ids for this VariantSet.</summary>
	public  int GetCustomDependencyUidCount() { return default; }
	///<summary>This function allow to retrieve all the translated node&#39;s unique ids for this VariantSet.</summary>
	public  void GetCustomDependencyUids(TArray<string> OutDependencyUids) {}
	///<summary>This function allow to retrieve a specific translated node&#39;s unique id for this VariantSet.</summary>
	public  void GetCustomDependencyUid(int Index,string OutDependencyUid) {}
	///<summary>Add one translated node&#39;s unique id to this VariantSet.</summary>
	public  bool AddCustomDependencyUid(string DependencyUid) { return default; }
	///<summary>Remove one translated node&#39;s unique id from this VariantSet.</summary>
	public  bool RemoveCustomDependencyUid(string DependencyUid) { return default; }
}
