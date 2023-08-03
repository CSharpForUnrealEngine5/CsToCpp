#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoWorldAxisSource is an IGizmoAxisSource that provides one of the World axes</summary>
[CppInclude("BaseGizmos/AxisSources.h")]
public partial class UGizmoWorldAxisSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Origin</summary>
	public FVector Origin;
	///<summary>Clamped internally to 0,1,2</summary>
	public int AxisIndex;
}
