namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileParameterTable {
	public FName ParameterName;
	public TArray<FName> Header;
	public TArray<FLensFileParameterTableRow> Data;
}
