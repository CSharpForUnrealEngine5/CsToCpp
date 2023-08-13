namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64&lt;uint8&gt;</summary>
[CppInclude("Nodes/InterchangeFactoryBaseNode.h")]
public partial class UInterchangeFactoryBaseNode : UInterchangeBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Return the reimport strategy flags.</summary>
	public EReimportStrategyFlags GetReimportStrategyFlags() { return default; }
	///<summary>Change the reimport strategy flags.</summary>
	public bool SetReimportStrategyFlags(EReimportStrategyFlags ReimportStrategyFlags) { return default; }
	///<summary>Return the custom sub-path under PackageBasePath, where the assets will be created.</summary>
	public bool GetCustomSubPath(string AttributeValue) { return default; }
	///<summary>Set the custom sub-path under PackageBasePath where the assets will be created.</summary>
	public bool SetCustomSubPath(string AttributeValue) { return default; }
	///<summary>This function allow to retrieve the number of factory dependencies for this object.</summary>
	public int GetFactoryDependenciesCount() { return default; }
	///<summary>This function allow to retrieve the dependency for this object.</summary>
	public void GetFactoryDependencies(TArray<string> OutDependencies) {}
	///<summary>This function allow to retrieve one dependency for this object.</summary>
	public void GetFactoryDependency(int Index,string OutDependency) {}
	///<summary>Add one dependency to this object.</summary>
	public bool AddFactoryDependencyUid(string DependencyUid) { return default; }
	///<summary>Remove one dependency from this object.</summary>
	public bool RemoveFactoryDependencyUid(string DependencyUid) { return default; }
	///<summary>Return the custom ReferenceObject. The UObject this factory node has created.</summary>
	public bool GetCustomReferenceObject(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Set the custom ReferenceObject. The UObject this factory node has created.</summary>
	public bool SetCustomReferenceObject(FSoftObjectPath AttributeValue) { return default; }
}
