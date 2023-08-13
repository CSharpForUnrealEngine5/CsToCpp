namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script Blueprint factory</summary>
[CppInclude("ScriptFactory.h")]
public partial class UScriptFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>ParentClass</summary>
	public UClass ParentClass;
}
