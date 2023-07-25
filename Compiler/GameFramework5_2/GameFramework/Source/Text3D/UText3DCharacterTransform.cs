#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Text3DCharacterTransform.h")]
public partial class UText3DCharacterTransform : USceneComponent {
// Text3DCharacterTransform
	public bool bLocationEnabled;
	public float LocationProgress;
	public EText3DCharacterEffectOrder LocationOrder;
	public float LocationRange;
	public FVector LocationDistance;
	public void SetLocationEnabled(bool bEnabled) {}
	public void SetLocationProgress(float Progress) {}
	public void SetLocationOrder(EText3DCharacterEffectOrder Order) {}
	public void SetLocationRange(float Range) {}
	public void SetLocationDistance(FVector Distance) {}
	public bool bScaleEnabled;
	public float ScaleProgress;
	public EText3DCharacterEffectOrder ScaleOrder;
	public float ScaleRange;
	public FVector ScaleBegin;
	public FVector ScaleEnd;
	public void SetScaleEnabled(bool bEnabled) {}
	public void SetScaleProgress(float Progress) {}
	public void SetScaleOrder(EText3DCharacterEffectOrder Order) {}
	public void SetScaleRange(float Range) {}
	public void SetScaleBegin(FVector Value) {}
	public void SetScaleEnd(FVector Value) {}
	public bool bRotateEnabled;
	public float RotateProgress;
	public EText3DCharacterEffectOrder RotateOrder;
	public float RotateRange;
	public FRotator RotateBegin;
	public FRotator RotateEnd;
	public void SetRotateEnabled(bool bEnabled) {}
	public void SetRotateProgress(float Progress) {}
	public void SetRotateOrder(EText3DCharacterEffectOrder Order) {}
	public void SetRotateRange(float Range) {}
	public void SetRotateBegin(FRotator Value) {}
	public void SetRotateEnd(FRotator Value) {}
}
