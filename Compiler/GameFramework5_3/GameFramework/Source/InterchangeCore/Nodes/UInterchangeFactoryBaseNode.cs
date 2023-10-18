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
	///<summary>Return true if this node should skip the factory import process, false otherwise.</summary>
	public bool ShouldSkipNodeImport() { return default; }
	///<summary>Add the skip node attribute. Use this function to cancel the creation of the unreal asset, see ShouldSkipNodeImport for more documentation.</summary>
	public bool SetSkipNodeImport() { return default; }
	///<summary>Remove the skip node attribute. See ShouldSkipNodeImport for more documentation.</summary>
	public bool UnsetSkipNodeImport() { return default; }
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
	///<summary>Return whether or not an object should be created even if it has been deleted in the editor.</summary>
	public bool ShouldForceNodeReimport() { return default; }
	///<summary>Allow the creation of the unreal object even if it has been previously deleted in the editor.</summary>
	public bool SetForceNodeReimport() { return default; }
	///<summary>Disallow the creation of the unreal object if it has been previously deleted in the editor.</summary>
	public bool UnsetForceNodeReimport() { return default; }
}
