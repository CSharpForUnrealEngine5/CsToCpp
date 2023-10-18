namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSpriteRendererProperties.h")]
///<summary>This enum decides how a sprite particle will orient its &quot;facing&quot; axis. Must keep these in sync with NiagaraSpriteVertexFactory.ush</summary>
public enum ENiagaraSpriteFacingMode {
	FaceCamera=0,
	FaceCameraPlane=1,
	CustomFacingVector=2,
	FaceCameraPosition=3,
	FaceCameraDistanceBlend=4,
	Automatic=5,
}
