#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeImportTestStepReimport.h")]
public partial class UInterchangeImportTestStepReimport : UInterchangeImportTestStepBase {
	public static UClass StaticClass() {return default;}
	///<summary>The source file to import (path relative to the json script)</summary>
	public FFilePath SourceFileToReimport;
	///<summary>The type of the asset to reimport. In the case that only one such asset were imported, this is unambiguous</summary>
	public UClass AssetTypeToReimport;
	///<summary>If there were multiple assets of the above type imported, specify the concrete name here</summary>
	public string AssetNameToReimport;
	///<summary>Whether imported assets should be saved and freshly reloaded after import</summary>
	public bool bSaveThenReloadImportedAssets;
}
