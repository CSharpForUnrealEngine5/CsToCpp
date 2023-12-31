namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshBudgetProjectSettings.h")]
public partial class UMeshBudgetProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Enable/disable the static mesh budget.</summary>
	public bool bEnableStaticMeshBudget;
	///<summary>The static mesh budgets array.</summary>
	public TArray<FStaticMeshBudgetInfo> StaticMeshBudgetInfos;
}
