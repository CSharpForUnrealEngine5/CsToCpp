#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeFactoryBaseNode.h")]
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64<uint8></summary>
public partial class UInterchangeFactoryBaseNode : UInterchangeBaseNode {
// InterchangeFactoryBaseNode
	public  EReimportStrategyFlags GetReimportStrategyFlags() { return default; }
	public  bool SetReimportStrategyFlags(EReimportStrategyFlags ReimportStrategyFlags) { return default; }
	public  bool GetCustomSubPath(string AttributeValue) { return default; }
	public  bool SetCustomSubPath(string AttributeValue) { return default; }
	public  int GetFactoryDependenciesCount() { return default; }
	public  void GetFactoryDependencies(TArray<string> OutDependencies) {}
	public  void GetFactoryDependency(int Index,string OutDependency) {}
	public  bool AddFactoryDependencyUid(string DependencyUid) { return default; }
	public  bool RemoveFactoryDependencyUid(string DependencyUid) { return default; }
	public  bool GetCustomReferenceObject(FSoftObjectPath AttributeValue) { return default; }
	public  bool SetCustomReferenceObject(FSoftObjectPath AttributeValue) { return default; }
}
