#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityTest.h")]
public partial class UEditorUtilityTest : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the test is ready to prepare</summary>
	public FEditorUtilityTestEventSignature OnTestPrepare;
	///<summary>Called when the test is started</summary>
	public FEditorUtilityTestEventSignature OnTestStart;
	///<summary>Called when the test is finished. Use it to clean up</summary>
	public FEditorUtilityTestFinishedSignature OnTestFinished;
	///<summary>The owner is the group or person responsible for the test. Generally you should use a group name</summary>
	public string Owner;
	///<summary>A description of the test, like what is this test trying to determine.</summary>
	public string Description;
	///<summary>The Test&#39;s time limit for preparation, this is the time it has to trigger IsReadyToStart(). &#39;0&#39; means no limit.</summary>
	public float PreparationTimeLimit;
	///<summary>Test&#39;s total run time limit. &#39;0&#39; means no limit</summary>
	public float TimeLimit;
	///<summary>Blueprint Utility Editor entry point</summary>
	public  void Run() {}
	///<summary>Use to setup test before running, must call FinishPrepareTest at the end to actual start the test.</summary>
	public  void PrepareTest() {}
	///<summary>Tell the blueprint VM to start the test (to use at the end of Prepare Test event).</summary>
	public  void FinishPrepareTest() {}
	///<summary>Actual run the test, must call FinishTest at then end of test with a state to signify the test is done.</summary>
	public  void StartTest() {}
	///<summary>Tell the VM the test is finished with specify state.</summary>
	public  void FinishTest(EEditorUtilityTestResult TestState,string Message) {}
	///<summary>Use to add clean up steps, the call is blocking.</summary>
	public  void ReceiveFinishedTest(EEditorUtilityTestResult TestState,EEditorUtilityTestResult FinalState) {}
	///<summary>Add Error</summary>
	public  void AddError(string Message) {}
	///<summary>Add Warning</summary>
	public  void AddWarning(string Message) {}
	///<summary>Add Info</summary>
	public  void AddInfo(string Message) {}
	///<summary>Add error if expected condition is false</summary>
	public  void ExpectTrue(bool Condition,string ErrorMessage) {}
	///<summary>Add error if expected condition is true</summary>
	public  void ExpectFalse(bool Condition,string ErrorMessage) {}
	///<summary>Get test state</summary>
	public  EEditorUtilityTestResult GetState() { return default; }
	///<summary>Is test ruuning</summary>
	public  bool IsRunning() { return default; }
}
