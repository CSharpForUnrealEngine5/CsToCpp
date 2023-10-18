namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MemoryUsageQueriesConfig.h")]
public partial class UMemoryUsageQueriesConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collections</summary>
	public TArray<FCollectionInfo> Collections;
	///<summary>SavingsPresets</summary>
	public TMap<string,string> SavingsPresets;
}
