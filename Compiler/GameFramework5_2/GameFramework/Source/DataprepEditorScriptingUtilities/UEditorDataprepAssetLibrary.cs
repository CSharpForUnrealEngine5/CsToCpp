#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorDataprepAssetLibrary.h")]
///<summary>Utility class to do most expose most of the common functionalities of the dataprep editor plugin (Visual Dataprep).</summary>
public partial class UEditorDataprepAssetLibrary : UBlueprintFunctionLibrary {
// EditorDataprepAssetLibrary
	public static bool ExecuteDataprep(UDataprepAssetInterface DataprepAssetInterface,EDataprepReportMethod LogReportingMethod,EDataprepReportMethod ProgressReportingMethod) { return default; }
	public static int GetProducersCount(UDataprepAssetInterface DataprepAssetInterface) { return default; }
	public static UDataprepContentProducer GetProducer(UDataprepAssetInterface DataprepAssetInterface,int Index) { return default; }
	public static void RemoveProducer(UDataprepAssetInterface DataprepAssetInterface,int Index) {}
	public static UDataprepContentProducer AddProducer(UDataprepAssetInterface DataprepAssetInterface,UClass ProducerClass) { return default; }
	public static UDataprepContentProducer AddProducerAutomated(UDataprepAssetInterface DataprepAssetInterface,UClass ProducerClass) { return default; }
	public static int GetActionCount(UDataprepAsset DataprepAsset) { return default; }
	public static void RemoveAction(UDataprepAsset DataprepAsset,int Index) {}
	public static UDataprepActionAsset AddAction(UDataprepAsset DataprepAsset) { return default; }
	public static UDataprepActionAsset AddActionByDuplication(UDataprepAsset DataprepAsset,UDataprepActionAsset ActionToDuplicate) { return default; }
	public static void SwapActions(UDataprepAsset DataprepAsset,int FirstActionIndex,int SecondActionIndex) {}
	public static UDataprepActionAsset GetAction(UDataprepAsset DataprepAsset,int Index) { return default; }
	public static UDataprepContentConsumer GetConsumer(UDataprepAssetInterface DataprepAssetInterface) { return default; }
	public static int GetStepsCount(UDataprepActionAsset DataprepAction) { return default; }
	public static UDataprepParameterizableObject AddStep(UDataprepActionAsset DataprepAction,UClass StepType) { return default; }
	public static UDataprepParameterizableObject AddStepByDuplication(UDataprepActionAsset DataprepAction,UDataprepParameterizableObject StepObject) { return default; }
	public static void RemoveStep(UDataprepActionAsset DataprepAction,int Index) {}
	public static void MoveStep(UDataprepActionAsset DataprepAction,int StepIndex,int DestinationIndex) {}
	public static void SwapSteps(UDataprepActionAsset DataprepAction,int FirstIndex,int SecondIndex) {}
	public static UDataprepParameterizableObject GetStepObject(UDataprepActionAsset DataprepAction,int Index) { return default; }
}
