namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTest.h")]
public partial class AFunctionalTest : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>TestLabel</summary>
	public string TestLabel;
	///<summary>The author is the group or person responsible for the test.  Generally you should use a group name</summary>
	public string Author;
	///<summary>A description of the test, like what is this test trying to determine.</summary>
	public string Description;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Allows a test to be disabled.  If a test is disabled, it will not appear in the set of</summary>
	public bool bIsEnabled;
	///<summary>Determines how LogErrors are handled during this test.</summary>
	public EFunctionalTestLogHandling LogErrorHandling;
	///<summary>Determines how LogWarnings are handled during this test.</summary>
	public EFunctionalTestLogHandling LogWarningHandling;
	///<summary>Allows you to specify another actor to view the test from.  Usually this is a camera you place</summary>
	public AActor ObservationPoint;
	///<summary>A random number stream that you can use during testing.  This number stream will be consistent</summary>
	public FRandomStream RandomNumbersStream;
	///<summary>Result</summary>
	public EFunctionalTestResult Result;
	///<summary>The Test&#39;s time limit for preparation, this is the time it has to return true when checking IsReady(). &#39;0&#39; means no limit.</summary>
	public float PreparationTimeLimit;
	///<summary>Test&#39;s time limit. &#39;0&#39; means no limit</summary>
	public float TimeLimit;
	///<summary>TimesUpMessage</summary>
	public FText TimesUpMessage;
	///<summary>If test is limited by time this is the result that will be returned when time runs out</summary>
	public EFunctionalTestResult TimesUpResult;
	///<summary>Called when the test is ready to prepare</summary>
	public FFunctionalTestEventSignature OnTestPrepare;
	///<summary>Called when the test is started</summary>
	public FFunctionalTestEventSignature OnTestStart;
	///<summary>Called when the test is finished. Use it to clean up</summary>
	public FFunctionalTestEventSignature OnTestFinished;
	///<summary>AutoDestroyActors</summary>
	public TArray<AActor> AutoDestroyActors;
	///<summary>RenderComp</summary>
	public UFuncTestRenderingComponent RenderComp;
	///<summary>TestName</summary>
	public UTextRenderComponent TestName;
	///<summary>Assert that a boolean value is true.</summary>
	public virtual bool AssertTrue(bool Condition,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that a boolean value is false.</summary>
	public virtual bool AssertFalse(bool Condition,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that a UObject is valid</summary>
	public virtual bool AssertIsValid(UObject Object,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert on a relationship between two integers.</summary>
	public virtual bool AssertValue_Int(int Actual,EComparisonMethod ShouldBe,int Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert on a relationship between two floats.</summary>
	public virtual bool AssertValue_Float(float Actual,EComparisonMethod ShouldBe,float Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert on a relationship between two doubles.</summary>
	public bool AssertValue_Double(double Actual,EComparisonMethod ShouldBe,double Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert on a relationship between two DateTimes.</summary>
	public virtual bool AssertValue_DateTime(FDateTime Actual,EComparisonMethod ShouldBe,FDateTime Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two transforms are (components memberwise - translation, rotation, scale) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Transform(FTransform Actual,FTransform Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two floats are equal within tolerance between two floats.</summary>
	public virtual bool AssertEqual_Float(float Actual,float Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two double are equal within tolerance between two doubles.</summary>
	public bool AssertEqual_Double(double Actual,double Expected,string What,double Tolerance/*=1.0e-4*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two bools are equal</summary>
	public virtual bool AssertEqual_Bool(bool Actual,bool Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two ints are equal</summary>
	public virtual bool AssertEqual_Int(int Actual,int Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two FNames are equal</summary>
	public virtual bool AssertEqual_Name(FName Actual,FName Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two Objects are equal</summary>
	public virtual bool AssertEqual_Object(UObject Actual,UObject Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two transforms are (components memberwise - translation, rotation, scale) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Transform(FTransform Actual,FTransform NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that the component angles of two rotators are all equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Rotator(FRotator Actual,FRotator Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that the component angles of two rotators are all not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Rotator(FRotator Actual,FRotator NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two vectors are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Vector(FVector Actual,FVector Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two vectors are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Vector(FVector Actual,FVector NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two two-component vectors are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Vector2D(FVector2D Actual,FVector2D Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two two-component vectors are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Vector2D(FVector2D Actual,FVector2D NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two two-component boxes are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Box2D(FBox2D Actual,FBox2D Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two two-component boxes are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Box2D(FBox2D Actual,FBox2D NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two four-component vectors are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Vector4(FVector4 Actual,FVector4 Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two four-component vectors are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Vector4(FVector4 Actual,FVector4 NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two planes are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Plane(FPlane Actual,FPlane Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two planes are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Plane(FPlane Actual,FPlane NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two quats are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Quat(FQuat Actual,FQuat Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two quats are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Quat(FQuat Actual,FQuat NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two 4x4 matrices are (memberwise) equal within a small tolerance.</summary>
	public virtual bool AssertEqual_Matrix(FMatrix Actual,FMatrix Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two 4x4 matrices are (memberwise) not equal within a small tolerance.</summary>
	public virtual bool AssertNotEqual_Matrix(FMatrix Actual,FMatrix NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two Strings are equal.</summary>
	public virtual bool AssertEqual_String(string Actual,string Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two Strings are not equal.</summary>
	public virtual bool AssertNotEqual_String(string Actual,string NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>Assert that two TraceQueryResults are equal.</summary>
	public virtual bool AssertEqual_TraceQueryResults(UTraceQueryTestResults Actual,UTraceQueryTestResults Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	///<summary>AddWarning</summary>
	public void AddWarning(string Message) {}
	///<summary>AddError</summary>
	public virtual void AddError(string Message) {}
	///<summary>FinishTest</summary>
	public virtual void FinishTest(EFunctionalTestResult TestResult,string Message) {}
	///<summary>LogMessage</summary>
	public virtual void LogMessage(string Message) {}
	///<summary>SetTimeLimit</summary>
	public virtual void SetTimeLimit(float NewTimeLimit,EFunctionalTestResult ResultWhenTimeRunsOut) {}
	///<summary>Used by debug drawing to gather actors this test is using and point at them on the level to better understand test&#39;s setup</summary>
	public TArray<AActor> DebugGatherRelevantActors() { return default; }
	///<summary>retrieves information whether test wants to have another run just after finishing</summary>
	public bool OnWantsReRunCheck() { return default; }
	///<summary>Causes the test to be rerun for a specific named reason.</summary>
	public void AddRerun(FName Reason) {}
	///<summary>Returns the current re-run reason if we&#39;re in a named re-run.</summary>
	public FName GetCurrentRerunReason() { return default; }
	///<summary>OnAdditionalTestFinishedMessageRequest</summary>
	public string OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult) { return default; }
	///<summary>Actors registered this way will be automatically destroyed (by limiting their lifespan)</summary>
	public virtual void RegisterAutoDestroyActor(AActor ActorToAutoDestroy) {}
	///<summary>AActor interface end</summary>
	public bool IsRunning() { return default; }
	///<summary>IsEnabled</summary>
	public bool IsEnabled() { return default; }
	///<summary>Prepare Test is fired once the test starts up, before the test IsReady() and thus before Start Test is called.</summary>
	public void ReceivePrepareTest() {}
	///<summary>Called once the IsReady() check for the test returns true.  After that happens the test has Officially started,</summary>
	public void ReceiveStartTest() {}
	///<summary>IsReady() is called once per frame after a test is run, until it returns true.  You should use this function to</summary>
	public bool IsReady() { return default; }
	///<summary>AG TEMP - solving a compile issue in a temp way to unblock the bui.d</summary>
	public bool bIsRunning;
	///<summary>TotalTime</summary>
	public float TotalTime;
}
