#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMeshRendererProperties.h")]
///<summary>This enum decides how a mesh particle will orient its &quot;facing&quot; axis relative to camera. Must keep these in sync with NiagaraMeshVertexFactory.ush</summary>
public enum ENiagaraMeshFacingMode {
	Default=0,
	Velocity=1,
	CameraPosition=2,
	CameraPlane=3,
}
