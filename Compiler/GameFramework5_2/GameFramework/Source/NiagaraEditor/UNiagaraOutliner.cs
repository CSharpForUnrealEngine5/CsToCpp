#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraOutliner.h")]
public partial class UNiagaraOutliner : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CaptureSettings</summary>
	public FNiagaraOutlinerCaptureSettings CaptureSettings;
	///<summary>ViewSettings</summary>
	public FNiagaraOutlinerViewSettings ViewSettings;
	///<summary>Data</summary>
	public FNiagaraOutlinerData Data;
	///<summary>SystemSimCaches</summary>
	public TMap<string,UNiagaraSimCache> SystemSimCaches;
}
