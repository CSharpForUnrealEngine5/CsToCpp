#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementOutputs.h")]
public partial class UColorConverterOutputPass : UCompositingElementOutput {
	public static UClass StaticClass() {return default;}
	///<summary>ColorConverter</summary>
	public UCompositingElementTransform ColorConverter;
	///<summary>DefaultConverterClass</summary>
	public UClass DefaultConverterClass;
	///<summary>PreviewResult</summary>
	public UTexture PreviewResult;
}
