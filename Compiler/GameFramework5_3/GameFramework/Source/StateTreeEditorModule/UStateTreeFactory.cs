namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for UStateTree</summary>
[CppInclude("StateTreeFactory.h")]
public partial class UStateTreeFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>StateTreeSchemaClass</summary>
	public UClass StateTreeSchemaClass;
}
