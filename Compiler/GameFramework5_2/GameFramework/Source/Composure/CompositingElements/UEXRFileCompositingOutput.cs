#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementOutputs.h")]
public partial class UEXRFileCompositingOutput : UCompositingElementOutput {
// EXRFileCompositingOutput
	public FDirectoryPath OutputDirectiory;
	public string FilenameFormat;
	public FFrameRate OutputFrameRate;
	public EExrCompressionOptions Compression;
}
