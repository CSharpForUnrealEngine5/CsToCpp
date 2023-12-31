namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCacheAbcFile actor serves as a placeable actor for GeometryCache loading from an Alembic file</summary>
[CppInclude("GeometryCacheAbcFileActor.h")]
public partial class AGeometryCacheAbcFileActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GeometryCacheAbcFileComponent</summary>
	public UGeometryCacheAbcFileComponent GeometryCacheAbcFileComponent;
}
