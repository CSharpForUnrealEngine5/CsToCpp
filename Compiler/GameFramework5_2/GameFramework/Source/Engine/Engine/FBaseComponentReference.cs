namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the hard/soft component reference structs</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FBaseComponentReference {
	public FName ComponentProperty;
	public string PathToComponent;
}
