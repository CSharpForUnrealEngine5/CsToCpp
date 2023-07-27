#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/FbxAutomationCommon.h")]
///<summary>Container for detailing collision automated test data.</summary>
public partial class UFbxTestPlan : UObject {
// FbxTestPlan
	public string TestPlanName;
	public EFBXTestPlanActionType Action;
	public int LodIndex;
	public bool bDeleteFolderAssets;
	public TArray<FFbxTestPlanExpectedResult> ExpectedResult;
	public UFbxImportUI ImportUI;
}
