namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionScalarParameter.h")]
public partial class UMaterialExpressionScalarParameter : UMaterialExpressionParameter {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public float DefaultValue;
	///<summary>bUseCustomPrimitiveData</summary>
	public bool bUseCustomPrimitiveData;
	///<summary>PrimitiveDataIndex</summary>
	public byte PrimitiveDataIndex;
	///<summary>Sets the lower bound for the slider on this parameter in the material instance editor.</summary>
	public float SliderMin;
	///<summary>Sets the upper bound for the slider on this parameter in the material instance editor.</summary>
	public float SliderMax;
}
