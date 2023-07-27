#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaOutput.h")]
///<summary>Abstract base class for media output.</summary>
public partial class UMediaOutput : UObject {
// MediaOutput
	public int NumberOfTextureBuffers;
	public  UMediaCapture CreateMediaCapture() { return default; }
	public  bool Validate(string OutFailureReason) { return default; }
}
