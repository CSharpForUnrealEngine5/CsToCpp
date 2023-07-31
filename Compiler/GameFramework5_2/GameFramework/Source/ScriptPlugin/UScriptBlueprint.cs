#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Script blueprint generates script-defined classes</summary>
[CppInclude("ScriptBlueprint.h")]
public partial class UScriptBlueprint : UBlueprint {
	///<summary>SourceFilePath_DEPRECATED</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Generated script bytecode</summary>
	public TArray<byte> ByteCode;
	///<summary>Script source code. @todo: this should be editor-only</summary>
	public string SourceCode;
}
