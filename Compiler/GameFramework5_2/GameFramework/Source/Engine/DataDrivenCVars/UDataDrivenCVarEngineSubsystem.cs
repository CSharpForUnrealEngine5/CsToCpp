#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataDrivenCVars/DataDrivenCVars.h")]
public partial class UDataDrivenCVarEngineSubsystem : UEngineSubsystem {
// DataDrivenCVarEngineSubsystem
	public  void FOnDataDrivenCVarChanged(string CVarName) {}
	public FOnDataDrivenCVarChanged OnDataDrivenCVarDelegate;
}
