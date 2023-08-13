namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
[CppInclude("Materials/MaterialFunctionInterface.h")]
public partial class UMaterialFunctionInterface : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EditorOnlyData</summary>
	public UMaterialFunctionInterfaceEditorOnlyData EditorOnlyData;
	///<summary>Used by materials using this function to know when to recompile.</summary>
	public FGuid StateId;
	///<summary>The intended usage of this function, required for material layers.</summary>
	public EMaterialFunctionUsage MaterialFunctionUsage;
	///<summary>CombinedInputTypes</summary>
	public uint CombinedInputTypes;
	///<summary>CombinedOutputTypes</summary>
	public uint CombinedOutputTypes;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
}
