#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementOutputs.h")]
public partial class UEXRFileCompositingOutput : UCompositingElementOutput {
	///<summary>OutputDirectiory</summary>
	public FDirectoryPath OutputDirectiory;
	///<summary>The format to use for the resulting filename. Extension will be added automatically. Any tokens of the form {token} will be replaced with the corresponding value:</summary>
	public string FilenameFormat;
	///<summary>OutputFrameRate</summary>
	public FFrameRate OutputFrameRate;
	///<summary>Compression</summary>
	public EExrCompressionOptions Compression;
}
