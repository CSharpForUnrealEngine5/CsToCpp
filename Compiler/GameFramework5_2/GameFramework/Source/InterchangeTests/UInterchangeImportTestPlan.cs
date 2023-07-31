#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Define a test plan</summary>
[CppInclude("InterchangeImportTestPlan.h")]
public partial class UInterchangeImportTestPlan : UObject {
	///<summary>Set of steps to perform to carry out this test plan</summary>
	public TArray<UInterchangeImportTestStepBase> Steps;
	///<summary>Whether or not this test plan is currently enabled</summary>
	public bool bIsEnabledInAutomationTests;
	///<summary>Why is the test plan disabled.</summary>
	public string DisabledTestReason;
	///<summary>Click here to immediately run this single test through the automation framework</summary>
	public  void RunThisTest() {}
}
