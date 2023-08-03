#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoConstantAxisSource is an IGizmoAxisSource implementation that</summary>
[CppInclude("BaseGizmos/AxisSources.h")]
public partial class UGizmoConstantAxisSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Origin</summary>
	public FVector Origin;
	///<summary>Direction</summary>
	public FVector Direction;
}
