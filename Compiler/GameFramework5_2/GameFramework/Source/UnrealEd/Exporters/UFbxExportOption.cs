#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/FbxExportOption.h")]
public partial class UFbxExportOption : UObject {
// FbxExportOption
	public EFbxExportCompatibility FbxExportCompatibility;
	public bool bASCII;
	public bool bForceFrontXAxis;
	public bool VertexColor;
	public bool LevelOfDetail;
	public bool Collision;
	public bool bExportMorphTargets;
	public bool bExportPreviewMesh;
	public bool MapSkeletalMotionToRoot;
	public bool bExportLocalTime;
}
