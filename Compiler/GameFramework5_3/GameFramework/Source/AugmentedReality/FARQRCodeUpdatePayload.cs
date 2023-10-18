namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARQRCodeUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public FVector Extents;
	public string QRCode;
}
