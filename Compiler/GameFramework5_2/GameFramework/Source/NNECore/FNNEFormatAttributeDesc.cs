#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Required by LoadModel() when loading operators in HLSL and DirectML runtime</summary>
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNEFormatAttributeDesc {
	public string Name;
	public FNNEAttributeValue Value;
}
