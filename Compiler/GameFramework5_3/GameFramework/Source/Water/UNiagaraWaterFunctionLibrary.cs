namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraWaterFunctionLibrary.h")]
public partial class UNiagaraWaterFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SetWaterBody</summary>
	public static void SetWaterBody(UNiagaraComponent NiagaraSystem,string OverrideName,AWaterBody WaterBody) {}
	///<summary>Sets the water body component on the Niagra water data interface on a Niagara particle system</summary>
	public static void SetWaterBodyComponent(UNiagaraComponent NiagaraSystem,string OverrideName,UWaterBodyComponent WaterBodyComponent) {}
}
