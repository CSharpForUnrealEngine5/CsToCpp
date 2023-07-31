#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileParameterTable {
	public string ParameterName;
	public TArray<string> Header;
	public TArray<FLensFileParameterTableRow> Data;
}
