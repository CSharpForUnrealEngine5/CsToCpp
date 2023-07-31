#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>“MemQuery Savings” command is supposed to list potential memory savings for assets based on predefined presets.</summary>
[CppInclude("MemoryUsageQueriesConfig.h")]
public partial class UMemoryUsageQueriesConfig : UObject {
	///<summary>SavingsPresets</summary>
	public TMap<string,string> SavingsPresets;
}
