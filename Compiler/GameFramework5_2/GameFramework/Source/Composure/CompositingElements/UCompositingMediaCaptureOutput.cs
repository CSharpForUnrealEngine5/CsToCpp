namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementOutputs.h")]
public partial class UCompositingMediaCaptureOutput : UColorConverterOutputPass {
	public static UClass StaticClass() {return default;}
	///<summary>CaptureOutput</summary>
	public UMediaOutput CaptureOutput;
	///<summary>ActiveCapture</summary>
	public UMediaCapture ActiveCapture;
}
