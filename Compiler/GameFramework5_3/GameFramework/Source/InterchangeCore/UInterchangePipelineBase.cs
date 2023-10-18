namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineBase.h")]
public partial class UInterchangePipelineBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ScriptedExecutePreImportPipeline</summary>
	public void ScriptedExecutePreImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer,TArray<UInterchangeSourceData> SourceDatas) {}
	///<summary>ScriptedExecutePipeline, is call after the translation and before we parse the graph to call the factory.</summary>
	public void ScriptedExecutePipeline(UInterchangeBaseNodeContainer BaseNodeContainer,TArray<UInterchangeSourceData> SourceDatas) {}
	///<summary>ScriptedExecutePostFactoryPipeline is call after the factory create the unreal asset but before calling PostEditChange.</summary>
	public void ScriptedExecutePostFactoryPipeline(UInterchangeBaseNodeContainer BaseNodeContainer,string FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	///<summary>ScriptedExecutePostImportPipeline is call after we completely import an asset, PostEditChange is already called.</summary>
	public void ScriptedExecutePostImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer,string FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	///<summary>Non virtual helper to allow blueprint to implement event base function let the interchange know if it can run asynchronously.</summary>
	public void ScriptedExecuteExportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer) {}
	///<summary>Non virtual helper to allow blueprint to implement event base function let the interchange know if it can run asynchronously.</summary>
	public bool ScriptedCanExecuteOnAnyThread(EInterchangePipelineTask PipelineTask) { return default; }
	///<summary>Non virtual helper to allow blueprint to implement event base function.</summary>
	public void ScriptedSetReimportSourceIndex(UClass ReimportObjectClass,int SourceFileIndex) {}
	///<summary>Return true if the property has valid states, false if no states was set for the property</summary>
	public bool DoesPropertyStatesExist(FName PropertyPath) { return default; }
	///<summary>Return a mutable property states Reference. Add the property states if it doesnt exist.</summary>
	public FInterchangePipelinePropertyStates FindOrAddPropertyStates(FName PropertyPath) { return default; }
	///<summary>Results</summary>
	public UInterchangeResultsContainer Results;
	///<summary>Map of property path and lock status. Any properties that have a true lock status will be readonly when showing the import dialog.</summary>
	public TMap<FName,FInterchangePipelinePropertyStates> PropertiesStates;
}
