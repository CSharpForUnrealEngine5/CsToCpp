namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDensityRemapElement.h")]
public partial class UPCGDensityRemapSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If InRangeMin = InRangeMax, then that density value is mapped to the average of OutRangeMin and OutRangeMax</summary>
	public float InRangeMin;
	///<summary>If InRangeMin = InRangeMax, then that density value is mapped to the average of OutRangeMin and OutRangeMax</summary>
	public float InRangeMax;
	///<summary>OutRangeMin</summary>
	public float OutRangeMin;
	///<summary>OutRangeMax</summary>
	public float OutRangeMax;
	///<summary>Density values outside of the input range will be unaffected by the remapping</summary>
	public bool bExcludeValuesOutsideInputRange;
}
