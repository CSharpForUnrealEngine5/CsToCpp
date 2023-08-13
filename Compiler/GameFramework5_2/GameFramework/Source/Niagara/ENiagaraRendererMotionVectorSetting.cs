namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>How a given Niagara renderer should handle motion vector generation.</summary>
public enum ENiagaraRendererMotionVectorSetting {
	AutoDetect=0,
	Precise=1,
	Approximate=2,
	Disable=3,
}
