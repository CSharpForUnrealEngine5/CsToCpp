#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSceneVariantSetsFactoryNode.h")]
public partial class UInterchangeSceneVariantSetsFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeSceneVariantSetsFactoryNode
	public  UClass GetObjectClass() { return default; }
	public  int GetCustomVariantSetUidCount() { return default; }
	public  void GetCustomVariantSetUids(TArray<string> OutVariantUids) {}
	public  void GetCustomVariantSetUid(int Index,string OutVariantUid) {}
	public  bool AddCustomVariantSetUid(string VariantUid) { return default; }
	public  bool RemoveCustomVariantSetUid(string VariantUid) { return default; }
}
