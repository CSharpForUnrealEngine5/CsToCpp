#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options specific to tessellated Datasmith scenes</summary>
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithCADImportSceneData : UDatasmithSceneImportData {
	public static UClass StaticClass() {return default;}
	///<summary>TessellationOptions</summary>
	public FDatasmithTessellationOptions TessellationOptions;
}
