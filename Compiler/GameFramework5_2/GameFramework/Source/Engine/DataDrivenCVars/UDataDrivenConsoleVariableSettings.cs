#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataDrivenCVars/DataDrivenCVars.h")]
public partial class UDataDrivenConsoleVariableSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>CVarsArray</summary>
	public TArray<FDataDrivenConsoleVariable> CVarsArray;
}
