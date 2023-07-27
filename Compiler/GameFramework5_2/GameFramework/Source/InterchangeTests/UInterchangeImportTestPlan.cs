#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeImportTestPlan.h")]
///<summary>Define a test plan</summary>
public partial class UInterchangeImportTestPlan : UObject {
// InterchangeImportTestPlan
	public TArray<UInterchangeImportTestStepBase> Steps;
	public bool bIsEnabledInAutomationTests;
	public string DisabledTestReason;
	public  void RunThisTest() {}
}
