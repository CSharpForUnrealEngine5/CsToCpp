namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
///<summary>Used by FPostProcessSettings Depth of Fields</summary>
public enum EDepthOfFieldMethod {
	DOFM_BokehDOF=0,
	DOFM_Gaussian=1,
	DOFM_CircleDOF=2,
	DOFM_MAX=3,
}
