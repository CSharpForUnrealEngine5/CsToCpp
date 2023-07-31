#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set max size (width or height) each input texture</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMaxTextureSizeOperation : UDataprepOperation {
	///<summary>MaxTextureSize</summary>
	public int MaxTextureSize;
	///<summary>If true, original texture size will be enforced to power of two before resizing (if it&#39;s a non-power of two size), else only POT textures will be affected.</summary>
	public bool bAllowPadding;
}
