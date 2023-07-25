#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineBase.h")]
public partial class UInterchangePipelineBase : UObject {
// InterchangePipelineBase
	public void ScriptedExecutePreImportPipeline(UObject BaseNodeContainer,TArray<UObject> SourceDatas) {}
	public void ScriptedExecutePipeline(UObject BaseNodeContainer,TArray<UObject> SourceDatas) {}
	public void ScriptedExecutePostFactoryPipeline(UObject BaseNodeContainer,string FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	public void ScriptedExecutePostImportPipeline(UObject BaseNodeContainer,string FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	public void ScriptedExecuteExportPipeline(UObject BaseNodeContainer) {}
	public bool ScriptedCanExecuteOnAnyThread(EInterchangePipelineTask PipelineTask) { return default; }
	public void ScriptedSetReimportSourceIndex(UClass ReimportObjectClass,int SourceFileIndex) {}
	public bool DoesPropertyStatesExist(string PropertyPath) { return default; }
	public FInterchangePipelinePropertyStates FindOrAddPropertyStates(string PropertyPath) { return default; }
	public UInterchangeResultsContainer Results;
	public TMap<string,FInterchangePipelinePropertyStates> PropertiesStates;
}
