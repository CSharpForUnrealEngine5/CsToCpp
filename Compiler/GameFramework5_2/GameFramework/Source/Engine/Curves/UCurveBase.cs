#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a curve of interpolated points to evaluate over a given range</summary>
[CppInclude("Curves/CurveBase.h")]
public partial class UCurveBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the time range across all curves</summary>
	public  void GetTimeRange(float MinTime,float MaxTime) {}
	///<summary>Get the value range across all curves</summary>
	public  void GetValueRange(float MinValue,float MaxValue) {}
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>The filename imported to create this object. Relative to this object&#39;s package, BaseDir() or absolute</summary>
	public string ImportPath_DEPRECATED;
}
