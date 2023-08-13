namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>How to handle how Niagara rendered effects should generate motion vectors by default (can still be overridden on a case-by-case basis)</summary>
public enum ENiagaraDefaultRendererMotionVectorSetting {
	Precise=0,
	Approximate=1,
}
