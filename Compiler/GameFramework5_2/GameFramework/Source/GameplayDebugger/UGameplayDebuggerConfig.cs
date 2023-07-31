#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial class UGameplayDebuggerConfig : UObject {
	///<summary>key used to activate visual debugger tool</summary>
	public FKey ActivationKey;
	///<summary>select next category row</summary>
	public FKey CategoryRowNextKey;
	///<summary>select previous category row</summary>
	public FKey CategoryRowPrevKey;
	///<summary>select category slot 0</summary>
	public FKey CategorySlot0;
	///<summary>select category slot 1</summary>
	public FKey CategorySlot1;
	///<summary>select category slot 2</summary>
	public FKey CategorySlot2;
	///<summary>select category slot 3</summary>
	public FKey CategorySlot3;
	///<summary>select category slot 4</summary>
	public FKey CategorySlot4;
	///<summary>select category slot 5</summary>
	public FKey CategorySlot5;
	///<summary>select category slot 6</summary>
	public FKey CategorySlot6;
	///<summary>select category slot 7</summary>
	public FKey CategorySlot7;
	///<summary>select category slot 8</summary>
	public FKey CategorySlot8;
	///<summary>select category slot 9</summary>
	public FKey CategorySlot9;
	///<summary>additional canvas padding: left</summary>
	public float DebugCanvasPaddingLeft;
	///<summary>additional canvas padding: right</summary>
	public float DebugCanvasPaddingRight;
	///<summary>additional canvas padding: top</summary>
	public float DebugCanvasPaddingTop;
	///<summary>additional canvas padding: bottom</summary>
	public float DebugCanvasPaddingBottom;
	///<summary>enable text shadow by default</summary>
	public bool bDebugCanvasEnableTextShadow;
	///<summary>Categories</summary>
	public TArray<FGameplayDebuggerCategoryConfig> Categories;
	///<summary>Extensions</summary>
	public TArray<FGameplayDebuggerExtensionConfig> Extensions;
}
