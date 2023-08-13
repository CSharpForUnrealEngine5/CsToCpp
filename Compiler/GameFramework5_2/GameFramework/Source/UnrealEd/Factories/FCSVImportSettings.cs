namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/CSVImportFactory.h")]
public partial struct FCSVImportSettings {
	public UScriptStruct ImportRowStruct;
	public ECSVImportType ImportType;
	public ERichCurveInterpMode ImportCurveInterpMode;
}
