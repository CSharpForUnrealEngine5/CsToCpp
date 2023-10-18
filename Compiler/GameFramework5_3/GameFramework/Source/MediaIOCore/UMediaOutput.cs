namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for media output.</summary>
[CppInclude("MediaOutput.h")]
public partial class UMediaOutput : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Number of texture used to transfer the texture from the GPU to the system memory.</summary>
	public int NumberOfTextureBuffers;
	///<summary>Creates the specific implementation of the MediaCapture for the MediaOutput.</summary>
	public UMediaCapture CreateMediaCapture() { return default; }
	///<summary>Validate the media output settings (must be implemented in child classes).</summary>
	public virtual bool Validate(string OutFailureReason) { return default; }
}
