#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraRibbonRendererProperties.h")]
///<summary>Specifies options for distributing UV values across ribbon segments.</summary>
public enum ENiagaraRibbonUVDistributionMode {
	ScaledUniformly=0,
	ScaledUsingRibbonSegmentLength=1,
	TiledOverRibbonLength=2,
	TiledFromStartOverRibbonLength=3,
}
