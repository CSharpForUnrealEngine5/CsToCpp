namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Synthesis Utilities Blueprint Function Library</summary>
[CppInclude("SynthesisBlueprintUtilities.h")]
public partial class USynthesisUtilitiesBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the log frequency of the input value. Maps linear domain and range values to log output (good for linear slider controlling frequency)</summary>
	public static float GetLogFrequency(float InLinearValue,float InDomainMin,float InDomainMax,float InRangeMin,float InRangeMax) { return default; }
	///<summary>Returns the log frequency of the input value. Maps linear domain and range values to log output (good for linear slider controlling frequency)</summary>
	public static float GetLinearFrequency(float InLogFrequencyValue,float InDomainMin,float InDomainMax,float InRangeMin,float InRangeMax) { return default; }
}
