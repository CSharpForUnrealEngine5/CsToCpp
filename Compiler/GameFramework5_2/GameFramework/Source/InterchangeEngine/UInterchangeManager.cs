#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial class UInterchangeManager : UObject {
// InterchangeManager
	public UObject GetInterchangeManagerScripted() { return default; }
	public bool ImportAsset(string ContentPath,UObject SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	public bool ImportScene(string ContentPath,UObject SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	public bool ExportAsset(UObject Asset,bool bIsAutomated/*=false*/) { return default; }
	public bool ExportScene(UObject World,bool bIsAutomated/*=false*/) { return default; }
	public UObject CreateSourceData(string InFileName) { return default; }
	public UClass GetRegisteredFactoryClass(UClass ClassToMake) { return default; }
	public TSet<UClass> RegisteredTranslatorsClass;
	public TMap<UClass,UClass> RegisteredFactoryClasses;
	public TMap<UClass,UInterchangeWriterBase> RegisteredWriters;
}
