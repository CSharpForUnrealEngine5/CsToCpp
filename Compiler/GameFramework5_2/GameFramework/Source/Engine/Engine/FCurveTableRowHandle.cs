#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handle to a particular row in a table.</summary>
[CppInclude("Engine/CurveTable.h")]
public partial struct FCurveTableRowHandle {
	public UCurveTable CurveTable;
	public string RowName;
}
