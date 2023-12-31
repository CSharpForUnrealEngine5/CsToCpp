namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>“MemQuery Savings” command is supposed to list potential memory savings for assets based on predefined presets.</summary>
[CppInclude("MemoryUsageQueriesConfig.h")]
public partial class UMemoryUsageQueriesConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SavingsPresets</summary>
	public TMap<string,string> SavingsPresets;
}
