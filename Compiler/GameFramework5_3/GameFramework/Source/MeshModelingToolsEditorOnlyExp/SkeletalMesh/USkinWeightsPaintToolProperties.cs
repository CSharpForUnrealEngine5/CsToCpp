namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for properties displayed in Details panel while using USkinWeightsPaintTool</summary>
[CppInclude("SkeletalMesh/SkinWeightsPaintTool.h")]
public partial class USkinWeightsPaintToolProperties : UBrushBaseProperties {
	public static UClass StaticClass() {return default;}
	///<summary>brush vs selection modes</summary>
	public EWeightEditMode EditingMode;
	///<summary>custom brush modes and falloff types</summary>
	public EWeightEditOperation BrushMode;
	///<summary>weight color properties</summary>
	public EWeightColorMode ColorMode;
	///<summary>ColorRamp</summary>
	public TArray<FLinearColor> ColorRamp;
	///<summary>MinColor</summary>
	public FLinearColor MinColor;
	///<summary>MaxColor</summary>
	public FLinearColor MaxColor;
	///<summary>weight editing arguments</summary>
	public EAxis MirrorAxis;
	///<summary>MirrorDirection</summary>
	public EMirrorDirection MirrorDirection;
	///<summary>FloodValue</summary>
	public float FloodValue;
	///<summary>PruneValue</summary>
	public float PruneValue;
	///<summary>BrushConfigAdd</summary>
	public FSkinWeightBrushConfig BrushConfigAdd;
	///<summary>BrushConfigReplace</summary>
	public FSkinWeightBrushConfig BrushConfigReplace;
	///<summary>BrushConfigMultiply</summary>
	public FSkinWeightBrushConfig BrushConfigMultiply;
	///<summary>BrushConfigRelax</summary>
	public FSkinWeightBrushConfig BrushConfigRelax;
}
