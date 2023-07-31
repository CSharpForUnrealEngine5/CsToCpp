#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeFilePickerBase.h")]
public partial class UInterchangeFilePickerBase : UObject {
	///<summary>Non virtual helper to allow blueprint to implement event base function to implement the function FilePickerForTranslatorAssetType,</summary>
	public  bool ScriptedFilePickerForTranslatorAssetType(EInterchangeTranslatorAssetType TranslatorAssetType,FInterchangeFilePickerParameters Parameters,TArray<string> OutFilenames) { return default; }
	///<summary>Non virtual helper to allow blueprint to implement event base function to implement the function FilePickerForTranslatorType,</summary>
	public  bool ScriptedFilePickerForTranslatorType(EInterchangeTranslatorType TranslatorType,FInterchangeFilePickerParameters Parameters,TArray<string> OutFilenames) { return default; }
}
