#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScriptBlueprint.h")]
///<summary>The Script blueprint generates script-defined classes</summary>
public partial class UScriptBlueprint : UBlueprint {
// ScriptBlueprint
	public string SourceFilePath_DEPRECATED;
	public UAssetImportData AssetImportData;
	public TArray<byte> ByteCode;
	public string SourceCode;
}
