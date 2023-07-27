#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial class UInterchangeManager : UObject {
// InterchangeManager
	public static UInterchangeManager GetInterchangeManagerScripted() { return default; }
	public  bool ImportAsset(string ContentPath,UInterchangeSourceData SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	public  bool ImportScene(string ContentPath,UInterchangeSourceData SourceData,FImportAssetParameters ImportAssetParameters) { return default; }
	public  bool ExportAsset(UObject Asset,bool bIsAutomated/*=false*/) { return default; }
	public  bool ExportScene(UObject World,bool bIsAutomated/*=false*/) { return default; }
	public static UInterchangeSourceData CreateSourceData(string InFileName) { return default; }
	public  UClass GetRegisteredFactoryClass(UClass ClassToMake) { return default; }
	public TSet<UClass> RegisteredTranslatorsClass;
	public TMap<UClass,UClass> RegisteredFactoryClasses;
	public TMap<UClass,UInterchangeWriterBase> RegisteredWriters;
}
