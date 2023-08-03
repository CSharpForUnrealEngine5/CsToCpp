#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of in-world spline components. Note that this data interface is very experimental.</summary>
[CppInclude("NiagaraDataInterfaceSpline.h")]
public partial class UNiagaraDataInterfaceSpline : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The source actor from which to sample.  Note that this can only be set when used as a user variable on a component in the world.</summary>
	public AActor Source;
	///<summary>Reference to a user parameter if we&#39;re reading one. This should  be an Object user parameter that is either a USplineComponent or an AActor containing a USplineComponent.</summary>
	public FNiagaraUserParameterBinding SplineUserParameter;
	///<summary>bUseLUT</summary>
	public bool bUseLUT;
	///<summary>NumLUTSteps</summary>
	public int NumLUTSteps;
}
