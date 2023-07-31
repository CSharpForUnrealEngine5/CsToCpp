#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USed to help the cloud system to fast skip empty space areas when ray marching.</summary>
[CppInclude("Materials/MaterialExpressionVolumetricAdvancedMaterialOutput.h")]
public partial class UMaterialExpressionVolumetricCloudEmptySpaceSkippingOutput : UMaterialExpressionCustomOutput {
	///<summary>Specify 0 if no matter (cloud or participating media) can be found within the area, otherwise should be set &gt; 0.</summary>
	public FExpressionInput ContainsMatter;
}
