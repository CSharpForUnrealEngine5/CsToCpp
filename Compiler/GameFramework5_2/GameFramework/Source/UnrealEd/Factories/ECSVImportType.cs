#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/CSVImportFactory.h")]
///<summary>Enum to indicate what to import CSV as</summary>
public enum ECSVImportType {
	ECSV_DataTable=0,
	ECSV_CurveTable=1,
	ECSV_CurveFloat=2,
	ECSV_CurveVector=3,
	ECSV_CurveLinearColor=4,
}
