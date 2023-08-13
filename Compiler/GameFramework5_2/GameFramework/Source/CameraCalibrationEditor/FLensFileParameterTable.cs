namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileParameterTable {
	public string ParameterName;
	public TArray<string> Header;
	public TArray<FLensFileParameterTableRow> Data;
}
