namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportData.h")]
public partial class UFbxSceneImportData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The path of the fbx file use for the last import</summary>
	public string SourceFbxFile;
}
