namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IPFMExporterBlueprintAPI.h")]
public partial class UPFMExporterBlueprintAPI : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Generate PFM file from static mesh.</summary>
	public virtual bool ExportPFM(UStaticMeshComponent SrcMesh,USceneComponent Origin,int Width,int Height,string FileName) { return default; }
}
