namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to do most expose most of the common functionalities of the dataprep editor plugin (Visual Dataprep).</summary>
[CppInclude("EditorDataprepAssetLibrary.h")]
public partial class UEditorDataprepAssetLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Runs the Dataprep asset&#39;s producers, execute its recipe and finally runs the consumer to output the results.</summary>
	public static bool ExecuteDataprep(UDataprepAssetInterface DataprepAssetInterface,EDataprepReportMethod LogReportingMethod,EDataprepReportMethod ProgressReportingMethod) { return default; }
	///<summary>Get number of the producer of a dataprep asset</summary>
	public static int GetProducersCount(UDataprepAssetInterface DataprepAssetInterface) { return default; }
	///<summary>Get a producer from a dataprep asset.</summary>
	public static UDataprepContentProducer GetProducer(UDataprepAssetInterface DataprepAssetInterface,int Index) { return default; }
	///<summary>Remove a producer from a dataprep asset</summary>
	public static void RemoveProducer(UDataprepAssetInterface DataprepAssetInterface,int Index) {}
	///<summary>Add a producer to a dataprep asset (The producer will act as if was call from the dataprep editor, use the automated version if you don&#39;t want any ui)</summary>
	public static UDataprepContentProducer AddProducer(UDataprepAssetInterface DataprepAssetInterface,UClass ProducerClass) { return default; }
	///<summary>Add a producer to a dataprep asset</summary>
	public static UDataprepContentProducer AddProducerAutomated(UDataprepAssetInterface DataprepAssetInterface,UClass ProducerClass) { return default; }
	///<summary>Get number of actions of a dataprep asset</summary>
	public static int GetActionCount(UDataprepAsset DataprepAsset) { return default; }
	///<summary>Remove an action from a dataprep asset</summary>
	public static void RemoveAction(UDataprepAsset DataprepAsset,int Index) {}
	///<summary>Add an action to a dataprep asset</summary>
	public static UDataprepActionAsset AddAction(UDataprepAsset DataprepAsset) { return default; }
	///<summary>Add an action to a dataprep asset</summary>
	public static UDataprepActionAsset AddActionByDuplication(UDataprepAsset DataprepAsset,UDataprepActionAsset ActionToDuplicate) { return default; }
	///<summary>Swap the actions of a dataprep asset</summary>
	public static void SwapActions(UDataprepAsset DataprepAsset,int FirstActionIndex,int SecondActionIndex) {}
	///<summary>Get an action from a dataprep asset.</summary>
	public static UDataprepActionAsset GetAction(UDataprepAsset DataprepAsset,int Index) { return default; }
	///<summary>Access the consumer of a dataprep asset</summary>
	public static UDataprepContentConsumer GetConsumer(UDataprepAssetInterface DataprepAssetInterface) { return default; }
	///<summary>Get the number of steps for a dataprep action</summary>
	public static int GetStepsCount(UDataprepActionAsset DataprepAction) { return default; }
	///<summary>Add a step to a dataprep action</summary>
	public static UDataprepParameterizableObject AddStep(UDataprepActionAsset DataprepAction,UClass StepType) { return default; }
	///<summary>Add a step to a dataprep action by duplicating the step object</summary>
	public static UDataprepParameterizableObject AddStepByDuplication(UDataprepActionAsset DataprepAction,UDataprepParameterizableObject StepObject) { return default; }
	///<summary>Remove a step from the action</summary>
	public static void RemoveStep(UDataprepActionAsset DataprepAction,int Index) {}
	///<summary>Move a step of the dataprep action</summary>
	public static void MoveStep(UDataprepActionAsset DataprepAction,int StepIndex,int DestinationIndex) {}
	///<summary>Swap the steps of a dataprep action</summary>
	public static void SwapSteps(UDataprepActionAsset DataprepAction,int FirstIndex,int SecondIndex) {}
	///<summary>Return the object of a step from the dataprep action</summary>
	public static UDataprepParameterizableObject GetStepObject(UDataprepActionAsset DataprepAction,int Index) { return default; }
}
