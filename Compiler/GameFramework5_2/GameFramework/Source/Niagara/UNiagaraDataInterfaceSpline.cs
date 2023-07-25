#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceSpline.h")]
///<summary>Data Interface allowing sampling of in-world spline components. Note that this data interface is very experimental.</summary>
public partial class UNiagaraDataInterfaceSpline : UNiagaraDataInterface {
// NiagaraDataInterfaceSpline
	public AActor Source;
	public FNiagaraUserParameterBinding SplineUserParameter;
	public bool bUseLUT;
	public int NumLUTSteps;
}
