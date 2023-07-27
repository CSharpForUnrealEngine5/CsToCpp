#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTest.h")]
public partial class AFunctionalTest : AActor {
// FunctionalTest
	public string TestLabel;
	public string Author;
	public string Description;
	public UBillboardComponent SpriteComponent;
	public bool bIsEnabled;
	public EFunctionalTestLogHandling LogErrorHandling;
	public EFunctionalTestLogHandling LogWarningHandling;
	public AActor ObservationPoint;
	public FRandomStream RandomNumbersStream;
	public EFunctionalTestResult Result;
	public float PreparationTimeLimit;
	public float TimeLimit;
	public string TimesUpMessage;
	public EFunctionalTestResult TimesUpResult;
	public FFunctionalTestEventSignature OnTestPrepare;
	public FFunctionalTestEventSignature OnTestStart;
	public FFunctionalTestEventSignature OnTestFinished;
	public TArray<AActor> AutoDestroyActors;
	public UFuncTestRenderingComponent RenderComp;
	public UTextRenderComponent TestName;
	public  bool AssertTrue(bool Condition,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertFalse(bool Condition,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertIsValid(UObject Object,string Message,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertValue_Int(int Actual,EComparisonMethod ShouldBe,int Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertValue_Float(float Actual,EComparisonMethod ShouldBe,float Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertValue_Double(double Actual,EComparisonMethod ShouldBe,double Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertValue_DateTime(FDateTime Actual,EComparisonMethod ShouldBe,FDateTime Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Transform(FTransform Actual,FTransform Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Float(float Actual,float Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Double(double Actual,double Expected,string What,double Tolerance/*=1.0e-4*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Bool(bool Actual,bool Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Int(int Actual,int Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Name(string Actual,string Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Object(UObject Actual,UObject Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Transform(FTransform Actual,FTransform NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Rotator(FRotator Actual,FRotator Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Rotator(FRotator Actual,FRotator NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Vector(FVector Actual,FVector Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Vector(FVector Actual,FVector NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Vector2D(FVector2D Actual,FVector2D Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Vector2D(FVector2D Actual,FVector2D NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Box2D(FBox2D Actual,FBox2D Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Box2D(FBox2D Actual,FBox2D NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Vector4(FVector4 Actual,FVector4 Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Vector4(FVector4 Actual,FVector4 NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Plane(FPlane Actual,FPlane Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Plane(FPlane Actual,FPlane NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Quat(FQuat Actual,FQuat Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Quat(FQuat Actual,FQuat NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_Matrix(FMatrix Actual,FMatrix Expected,string What,float Tolerance/*=1.0e-4f*/,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_Matrix(FMatrix Actual,FMatrix NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_String(string Actual,string Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertNotEqual_String(string Actual,string NotExpected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  bool AssertEqual_TraceQueryResults(UTraceQueryTestResults Actual,UTraceQueryTestResults Expected,string What,UObject ContextObject/*=nullptr*/) { return default; }
	public  void AddWarning(string Message) {}
	public  void AddError(string Message) {}
	public  void FinishTest(EFunctionalTestResult TestResult,string Message) {}
	public  void LogMessage(string Message) {}
	public  void SetTimeLimit(float NewTimeLimit,EFunctionalTestResult ResultWhenTimeRunsOut) {}
	public  TArray<AActor> DebugGatherRelevantActors() { return default; }
	public  bool OnWantsReRunCheck() { return default; }
	public  void AddRerun(string Reason) {}
	public  string GetCurrentRerunReason() { return default; }
	public  string OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult) { return default; }
	public  void RegisterAutoDestroyActor(AActor ActorToAutoDestroy) {}
	public  bool IsRunning() { return default; }
	public  bool IsEnabled() { return default; }
	public  void ReceivePrepareTest() {}
	public  void ReceiveStartTest() {}
	public  bool IsReady() { return default; }
	public bool bIsRunning;
	public float TotalTime;
}
