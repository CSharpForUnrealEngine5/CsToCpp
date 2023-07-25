#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPreviewGrid.h")]
public partial class ANiagaraPreviewGrid : AActor {
// NiagaraPreviewGrid
	public void ActivatePreviews(bool bReset) {}
	public void DeactivatePreviews() {}
	public void SetPaused(bool bPaused) {}
	public void GetPreviews(TArray<UObject> OutPreviews) {}
	public UNiagaraSystem System;
	public ENiagaraPreviewGridResetMode ResetMode;
	public UNiagaraPreviewAxis PreviewAxisX;
	public UNiagaraPreviewAxis PreviewAxisY;
	public UClass PreviewClass;
	public float SpacingX;
	public float SpacingY;
	public int NumX;
	public int NumY;
	public TArray<UChildActorComponent> PreviewComponents;
	public UBillboardComponent SpriteComponent;
	public UArrowComponent ArrowComponent;
}
