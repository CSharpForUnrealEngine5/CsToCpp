namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Mesh Editor&#39;s settings.</summary>
[CppInclude("MeshPaintModeSettings.h")]
public partial class UMeshPaintModeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Color view mode used to display Vertex Colors</summary>
	public EMeshPaintDataColorViewMode ColorViewMode;
}
