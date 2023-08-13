namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for all factories that import objects into a scene (e.g in a level)</summary>
[CppInclude("Factories/SceneImportFactory.h")]
public partial class USceneImportFactory : UFactory {
	public static UClass StaticClass() {return default;}
}
