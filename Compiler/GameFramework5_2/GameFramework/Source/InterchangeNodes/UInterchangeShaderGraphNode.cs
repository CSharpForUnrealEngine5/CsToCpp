#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A shader graph has its own set of inputs on which shader nodes can be connected to.</summary>
[CppInclude("InterchangeShaderGraphNode.h")]
public partial class UInterchangeShaderGraphNode : UInterchangeShaderNode {
	///<summary>GetCustomTwoSided</summary>
	public  bool GetCustomTwoSided(bool AttributeValue) { return default; }
	///<summary>Sets if this shader graph should be rendered two sided or not. Defaults to off.</summary>
	public  bool SetCustomTwoSided(bool AttributeValue) { return default; }
	///<summary>GetCustomOpacityMaskClipValue</summary>
	public  bool GetCustomOpacityMaskClipValue(float AttributeValue) { return default; }
	///<summary>Shader is transparent or opaque if it&#39;s alpha is lower or higher than the clip value.</summary>
	public  bool SetCustomOpacityMaskClipValue(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomIsAShaderFunction</summary>
	public  bool GetCustomIsAShaderFunction(bool AttributeValue) { return default; }
	///<summary>Sets if this shader graph should be considered as a material, false, or a material function, true.</summary>
	public  bool SetCustomIsAShaderFunction(bool AttributeValue) { return default; }
}
