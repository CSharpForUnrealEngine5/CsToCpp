#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementPasses.h")]
public partial class UCompositingElementInput : UCompositingElementPass {
	public static UClass StaticClass() {return default;}
	///<summary>Marks this pass for &#39;internal use only&#39; - prevents it from being exposed to parent elements.</summary>
	public bool bIntermediate;
	///<summary>GenerateInput</summary>
	public  UTexture GenerateInput() { return default; }
}
