namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPrecompileContainer.h")]
public partial class UNiagaraPrecompileContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Scripts</summary>
	public TArray<UNiagaraScript> Scripts;
	///<summary>System</summary>
	public UNiagaraSystem System;
}
