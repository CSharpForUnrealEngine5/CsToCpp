namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataDrivenCVars/DataDrivenCVars.h")]
public partial class UDataDrivenCVarEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>FOnDataDrivenCVarChanged</summary>
	public void FOnDataDrivenCVarChanged(string CVarName) {}
	///<summary>OnDataDrivenCVarDelegate</summary>
	public FOnDataDrivenCVarChanged OnDataDrivenCVarDelegate;
}
