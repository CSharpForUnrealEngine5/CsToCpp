#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileParameterTable {
// LensFileParameterTable
	public string ParameterName;
	public TArray<string> Header;
	public TArray<FLensFileParameterTableRow> Data;
}
