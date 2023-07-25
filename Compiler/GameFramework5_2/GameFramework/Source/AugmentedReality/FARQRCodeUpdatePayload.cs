#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARQRCodeUpdatePayload {
// ARQRCodeUpdatePayload
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public FVector Extents;
	public string QRCode;
}
