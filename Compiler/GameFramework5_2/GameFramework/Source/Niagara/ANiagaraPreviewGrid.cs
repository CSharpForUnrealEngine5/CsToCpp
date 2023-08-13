namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPreviewGrid.h")]
public partial class ANiagaraPreviewGrid : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>AActor Interface End</summary>
	public void ActivatePreviews(bool bReset) {}
	///<summary>DeactivatePreviews</summary>
	public void DeactivatePreviews() {}
	///<summary>SetPaused</summary>
	public void SetPaused(bool bPaused) {}
	///<summary>GetPreviews</summary>
	public void GetPreviews(TArray<UNiagaraComponent> OutPreviews) {}
	///<summary>System</summary>
	public UNiagaraSystem System;
	///<summary>ResetMode</summary>
	public ENiagaraPreviewGridResetMode ResetMode;
	///<summary>Object controlling behavior varying on the X axis.</summary>
	public UNiagaraPreviewAxis PreviewAxisX;
	///<summary>Object controlling behavior varying on the Y axis.</summary>
	public UNiagaraPreviewAxis PreviewAxisY;
	///<summary>Class used to for previews in this grid.</summary>
	public UClass PreviewClass;
	///<summary>The default spacing between previews in X if the axis does not override it.</summary>
	public float SpacingX;
	///<summary>The default spacing between previews if the axis does not override it.</summary>
	public float SpacingY;
	///<summary>NumX</summary>
	public int NumX;
	///<summary>NumY</summary>
	public int NumY;
	///<summary>PreviewComponents</summary>
	public TArray<UChildActorComponent> PreviewComponents;
	///<summary>Reference to sprite visualization component</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Reference to arrow visualization component</summary>
	public UArrowComponent ArrowComponent;
}
