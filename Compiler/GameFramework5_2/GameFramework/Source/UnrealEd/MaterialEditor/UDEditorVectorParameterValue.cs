namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/DEditorVectorParameterValue.h")]
public partial class UDEditorVectorParameterValue : UDEditorParameterValue {
	public static UClass StaticClass() {return default;}
	///<summary>ParameterValue</summary>
	public FLinearColor ParameterValue;
	///<summary>bIsUsedAsChannelMask</summary>
	public bool bIsUsedAsChannelMask;
	///<summary>ChannelNames</summary>
	public FParameterChannelNames ChannelNames;
}
