namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FacialAnimationBulkImporterSettings.h")]
public partial class UFacialAnimationBulkImporterSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The path to import files from</summary>
	public FDirectoryPath SourceImportPath;
	///<summary>The path to import files to</summary>
	public FDirectoryPath TargetImportPath;
	///<summary>Node in the FBX scene that contains the curves we are interested in</summary>
	public string CurveNodeName;
}
