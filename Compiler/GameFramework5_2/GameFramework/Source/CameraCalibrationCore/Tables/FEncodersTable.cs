#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encoder table containing mapping from raw input value to nominal value</summary>
[CppInclude("Tables/EncodersTable.h")]
public partial struct FEncodersTable {
	public FRichCurve Focus;
	public FRichCurve Iris;
}
