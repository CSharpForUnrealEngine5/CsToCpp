#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial class UInterchangeManager : UObject {
	///<summary>Return the interchange manager singleton pointer.</summary>
	public static UInterchangeManager GetInterchangeManagerScripted() { return default; }
	///<summary>Call this to start an import asset process, the caller must specify a source data.</summary>
	public  bool ImportAsset(string ContentPath,UInterchangeSourceData SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	///<summary>Call this to start an import scene process, the caller must specify a source data.</summary>
	public  bool ImportScene(string ContentPath,UInterchangeSourceData SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	///<summary>Call this to start an export asset process, the caller must specify a source data.</summary>
	public  bool ExportAsset(UObject Asset,bool bIsAutomated/*=false*/) { return default; }
	///<summary>Call this to start an export scene process, the caller must specify a source data</summary>
	public  bool ExportScene(UObject World,bool bIsAutomated/*=false*/) { return default; }
	///<summary>* Script helper to create a source data object pointing on a file on disk</summary>
	public static UInterchangeSourceData CreateSourceData(string InFileName) { return default; }
	///<summary>Script helper to get a registered factory for a specified class</summary>
	public  UClass GetRegisteredFactoryClass(UClass ClassToMake) { return default; }
	///<summary>Caching the registered translator classes to avoid double registration fast</summary>
	public TSet<UClass> RegisteredTranslatorsClass;
	///<summary>The manager will create only one factory per type</summary>
	public TMap<UClass,UClass> RegisteredFactoryClasses;
	///<summary>The manager will create only one writer per type</summary>
	public TMap<UClass,UInterchangeWriterBase> RegisteredWriters;
}
