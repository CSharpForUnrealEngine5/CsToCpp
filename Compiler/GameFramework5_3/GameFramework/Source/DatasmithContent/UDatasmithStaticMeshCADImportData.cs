namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithStaticMeshCADImportData : UDatasmithStaticMeshImportData {
	public static UClass StaticClass() {return default;}
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
