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
