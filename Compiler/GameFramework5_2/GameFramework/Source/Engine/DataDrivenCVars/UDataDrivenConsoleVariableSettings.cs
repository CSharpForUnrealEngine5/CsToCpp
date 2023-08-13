namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataDrivenCVars/DataDrivenCVars.h")]
public partial class UDataDrivenConsoleVariableSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>CVarsArray</summary>
	public TArray<FDataDrivenConsoleVariable> CVarsArray;
}
