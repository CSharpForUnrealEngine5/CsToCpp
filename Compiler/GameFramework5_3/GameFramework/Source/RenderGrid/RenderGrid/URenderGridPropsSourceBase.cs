namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class of the render grid properties source abstraction.</summary>
[CppInclude("RenderGrid/RenderGridPropsSource.h")]
public partial class URenderGridPropsSourceBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Guid</summary>
	public FGuid Guid;
}
