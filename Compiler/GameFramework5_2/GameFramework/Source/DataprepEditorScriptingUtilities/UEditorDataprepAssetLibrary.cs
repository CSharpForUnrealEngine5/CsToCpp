#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorDataprepAssetLibrary.h")]
///<summary>Utility class to do most expose most of the common functionalities of the dataprep editor plugin (Visual Dataprep).</summary>
public partial class UEditorDataprepAssetLibrary : UBlueprintFunctionLibrary {
// EditorDataprepAssetLibrary
	public bool ExecuteDataprep(UObject DataprepAssetInterface,EDataprepReportMethod LogReportingMethod,EDataprepReportMethod ProgressReportingMethod) { return default; }
	public int GetProducersCount(UObject DataprepAssetInterface) { return default; }
	public UObject GetProducer(UObject DataprepAssetInterface,int Index) { return default; }
	public void RemoveProducer(UObject DataprepAssetInterface,int Index) {}
	public UObject AddProducer(UObject DataprepAssetInterface,UClass ProducerClass) { return default; }
	public UObject AddProducerAutomated(UObject DataprepAssetInterface,UClass ProducerClass) { return default; }
	public int GetActionCount(UObject DataprepAsset) { return default; }
	public void RemoveAction(UObject DataprepAsset,int Index) {}
	public UObject AddAction(UObject DataprepAsset) { return default; }
	public UObject AddActionByDuplication(UObject DataprepAsset,UObject ActionToDuplicate) { return default; }
	public void SwapActions(UObject DataprepAsset,int FirstActionIndex,int SecondActionIndex) {}
	public UObject GetAction(UObject DataprepAsset,int Index) { return default; }
	public UObject GetConsumer(UObject DataprepAssetInterface) { return default; }
	public int GetStepsCount(UObject DataprepAction) { return default; }
	public UObject AddStep(UObject DataprepAction,UClass StepType) { return default; }
	public UObject AddStepByDuplication(UObject DataprepAction,UObject StepObject) { return default; }
	public void RemoveStep(UObject DataprepAction,int Index) {}
	public void MoveStep(UObject DataprepAction,int StepIndex,int DestinationIndex) {}
	public void SwapSteps(UObject DataprepAction,int FirstIndex,int SecondIndex) {}
	public UObject GetStepObject(UObject DataprepAction,int Index) { return default; }
}
