#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for detailing collision automated test data.</summary>
[CppInclude("Tests/FbxAutomationCommon.h")]
public partial class UFbxTestPlan : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the Test Plan</summary>
	public string TestPlanName;
	///<summary>Tell the system what we want to do</summary>
	public EFBXTestPlanActionType Action;
	///<summary>The LOD index in case the user choose to add or reimport a LOD</summary>
	public int LodIndex;
	///<summary>If true the test will delete all assets create in the import folder</summary>
	public bool bDeleteFolderAssets;
	///<summary>Expected preset type</summary>
	public TArray<FFbxTestPlanExpectedResult> ExpectedResult;
	///<summary>Options use for this test plan, Transient because we manually serialize the options.</summary>
	public UFbxImportUI ImportUI;
}
