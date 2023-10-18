namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USed to help the cloud system to fast skip empty space areas when ray marching.</summary>
[CppInclude("Materials/MaterialExpressionVolumetricAdvancedMaterialOutput.h")]
public partial class UMaterialExpressionVolumetricCloudEmptySpaceSkippingOutput : UMaterialExpressionCustomOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Specify 0 if no matter (cloud or participating media) can be found within the area, otherwise should be set &gt; 0.</summary>
	public FExpressionInput ContainsMatter;
}
