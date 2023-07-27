#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityTest.h")]
public partial class UEditorUtilityTest : UObject {
// EditorUtilityTest
	public FEditorUtilityTestEventSignature OnTestPrepare;
	public FEditorUtilityTestEventSignature OnTestStart;
	public FEditorUtilityTestFinishedSignature OnTestFinished;
	public string Owner;
	public string Description;
	public float PreparationTimeLimit;
	public float TimeLimit;
	public  void Run() {}
	public  void PrepareTest() {}
	public  void FinishPrepareTest() {}
	public  void StartTest() {}
	public  void FinishTest(EEditorUtilityTestResult TestState,string Message) {}
	public  void ReceiveFinishedTest(EEditorUtilityTestResult TestState,EEditorUtilityTestResult FinalState) {}
	public  void AddError(string Message) {}
	public  void AddWarning(string Message) {}
	public  void AddInfo(string Message) {}
	public  void ExpectTrue(bool Condition,string ErrorMessage) {}
	public  void ExpectFalse(bool Condition,string ErrorMessage) {}
	public  EEditorUtilityTestResult GetState() { return default; }
	public  bool IsRunning() { return default; }
}
