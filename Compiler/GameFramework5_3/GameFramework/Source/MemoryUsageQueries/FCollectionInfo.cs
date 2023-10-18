namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>“MemQuery Collection” will list memory consumption based on assets discovered that have a path</summary>
[CppInclude("MemoryUsageQueriesConfig.h")]
public partial struct FCollectionInfo {
	public string Name;
	public TArray<string> Includes;
	public TArray<string> Excludes;
	public float BudgetMB;
}
