#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoComponentAxisSource is an IGizmoAxisSource implementation that provides one of the</summary>
[CppInclude("BaseGizmos/AxisSources.h")]
public partial class UGizmoComponentAxisSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Component</summary>
	public USceneComponent Component;
	///<summary>Clamped internally to 0,1,2</summary>
	public int AxisIndex;
	///<summary>If false, returns World axes</summary>
	public bool bLocalAxes;
}
