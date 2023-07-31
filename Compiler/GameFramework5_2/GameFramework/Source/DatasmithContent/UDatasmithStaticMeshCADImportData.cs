#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithStaticMeshCADImportData : UDatasmithStaticMeshImportData {
	///<summary>TessellationOptions</summary>
	public FDatasmithTessellationOptions TessellationOptions;
	///<summary>ModelUnit</summary>
	public double ModelUnit;
	///<summary>ModelTolerance</summary>
	public double ModelTolerance;
	///<summary>ResourcePath</summary>
	public string ResourcePath;
	///<summary>ResourceFilename</summary>
	public string ResourceFilename;
	///<summary>AuxiliaryFilenames</summary>
	public TArray<string> AuxiliaryFilenames;
}
