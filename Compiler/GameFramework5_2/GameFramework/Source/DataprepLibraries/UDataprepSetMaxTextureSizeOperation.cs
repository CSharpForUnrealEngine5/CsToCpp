namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set max size (width or height) each input texture</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMaxTextureSizeOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>MaxTextureSize</summary>
	public int MaxTextureSize;
	///<summary>If true, original texture size will be enforced to power of two before resizing (if it&#39;s a non-power of two size), else only POT textures will be affected.</summary>
	public bool bAllowPadding;
}
