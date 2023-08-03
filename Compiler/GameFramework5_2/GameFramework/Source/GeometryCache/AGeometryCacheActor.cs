#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCache actor, serves as a place-able actor for GeometryCache objects</summary>
[CppInclude("GeometryCacheActor.h")]
public partial class AGeometryCacheActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GeometryCacheComponent</summary>
	public UGeometryCacheComponent GeometryCacheComponent;
	///<summary>Returns GeometryCacheComponent subobject *</summary>
	public  UGeometryCacheComponent GetGeometryCacheComponent() { return default; }
}
