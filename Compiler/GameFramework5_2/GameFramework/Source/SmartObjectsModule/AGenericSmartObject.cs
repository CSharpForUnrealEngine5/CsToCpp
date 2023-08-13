namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenericSmartObject.h")]
public partial class AGenericSmartObject : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>SOComponent</summary>
	public USmartObjectComponent SOComponent;
	///<summary>RenderingComponent</summary>
	public USmartObjectRenderingComponent RenderingComponent;
}
