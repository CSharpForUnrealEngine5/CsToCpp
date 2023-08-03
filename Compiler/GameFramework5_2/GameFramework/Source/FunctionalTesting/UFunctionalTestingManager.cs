#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTestingManager.h")]
public partial class UFunctionalTestingManager : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>TestsLeft</summary>
	public TArray<AFunctionalTest> TestsLeft;
	///<summary>AllTests</summary>
	public TArray<AFunctionalTest> AllTests;
	///<summary>OnSetupTests</summary>
	public FFunctionalTestEventSignature OnSetupTests;
	///<summary>OnTestsComplete</summary>
	public FFunctionalTestEventSignature OnTestsComplete;
	///<summary>OnTestsBegin</summary>
	public FFunctionalTestEventSignature OnTestsBegin;
	///<summary>Triggers in sequence all functional tests found on the level.</summary>
	public static bool RunAllFunctionalTests(UObject WorldContextObject,bool bNewLog/*=true*/,bool bRunLooped/*=false*/,string FailedTestsReproString/*=TEXT("")*/) { return default; }
}
