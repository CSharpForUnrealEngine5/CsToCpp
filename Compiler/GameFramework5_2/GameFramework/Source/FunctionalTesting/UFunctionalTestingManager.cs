#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTestingManager.h")]
public partial class UFunctionalTestingManager : UBlueprintFunctionLibrary {
// FunctionalTestingManager
	public TArray<AFunctionalTest> TestsLeft;
	public TArray<AFunctionalTest> AllTests;
	public FFunctionalTestEventSignature OnSetupTests;
	public FFunctionalTestEventSignature OnTestsComplete;
	public FFunctionalTestEventSignature OnTestsBegin;
	public bool RunAllFunctionalTests(UObject WorldContextObject,bool bNewLog/*=true*/,bool bRunLooped/*=false*/,string FailedTestsReproString/*=TEXT("")*/) { return default; }
}
