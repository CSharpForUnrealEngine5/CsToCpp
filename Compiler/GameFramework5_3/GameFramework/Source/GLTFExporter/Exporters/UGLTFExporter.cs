namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/GLTFExporter.h")]
public partial class UGLTFExporter : UExporter {
	public static UClass StaticClass() {return default;}
	///<summary>Export the specified object to a glTF file (.gltf or .glb)</summary>
	public static bool ExportToGLTF(UObject Object,string FilePath,UGLTFExportOptions Options,TSet<AActor> SelectedActors,FGLTFExportMessages OutMessages) { return default; }
}
