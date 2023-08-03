#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh paint Mode.  Extends editor viewports with the ability to paint data on meshes</summary>
[CppInclude("MeshPaintMode.h")]
public partial class UMeshPaintMode : UEdMode {
	public static UClass StaticClass() {return default;}
	///<summary>ModeSettings</summary>
	public UMeshPaintModeSettings ModeSettings;
}
