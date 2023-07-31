#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARQRCodeUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public FVector Extents;
	public string QRCode;
}
