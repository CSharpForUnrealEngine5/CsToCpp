#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialFunctionInterface.h")]
///<summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
public partial class UMaterialFunctionInterface : UObject {
// MaterialFunctionInterface
	public UMaterialFunctionInterfaceEditorOnlyData EditorOnlyData;
	public FGuid StateId;
	public EMaterialFunctionUsage MaterialFunctionUsage;
	public uint CombinedInputTypes;
	public uint CombinedOutputTypes;
	public UThumbnailInfo ThumbnailInfo;
}
