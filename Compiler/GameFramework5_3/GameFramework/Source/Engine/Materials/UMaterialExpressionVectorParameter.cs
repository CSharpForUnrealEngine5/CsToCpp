namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionVectorParameter.h")]
public partial class UMaterialExpressionVectorParameter : UMaterialExpressionParameter {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public FLinearColor DefaultValue;
	///<summary>bUseCustomPrimitiveData</summary>
	public bool bUseCustomPrimitiveData;
	///<summary>PrimitiveDataIndex</summary>
	public byte PrimitiveDataIndex;
	///<summary>ChannelNames</summary>
	public FParameterChannelNames ChannelNames;
}
