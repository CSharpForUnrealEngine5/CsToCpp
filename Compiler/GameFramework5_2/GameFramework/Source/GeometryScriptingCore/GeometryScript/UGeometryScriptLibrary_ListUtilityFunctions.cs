#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ListUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_ListUtilityFunctions : UBlueprintFunctionLibrary {
	///<summary>GetIndexListLength</summary>
	public static int GetIndexListLength(FGeometryScriptIndexList IndexList) { return default; }
	///<summary>GetIndexListLastIndex</summary>
	public static int GetIndexListLastIndex(FGeometryScriptIndexList IndexList) { return default; }
	///<summary>GetIndexListItem</summary>
	public static int GetIndexListItem(FGeometryScriptIndexList IndexList,int Index,bool bIsValidIndex) { return default; }
	///<summary>SetIndexListItem</summary>
	public static void SetIndexListItem(FGeometryScriptIndexList IndexList,int Index,int NewValue,bool bIsValidIndex) {}
	///<summary>ConvertIndexListToArray</summary>
	public static void ConvertIndexListToArray(FGeometryScriptIndexList IndexList,TArray<int> IndexArray) {}
	///<summary>ConvertArrayToIndexList</summary>
	public static void ConvertArrayToIndexList(TArray<int> IndexArray,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType IndexType/*=EGeometryScriptIndexType.Any*/) {}
	///<summary>DuplicateIndexList</summary>
	public static void DuplicateIndexList(FGeometryScriptIndexList IndexList,FGeometryScriptIndexList DuplicateList) {}
	///<summary>ClearIndexList</summary>
	public static void ClearIndexList(FGeometryScriptIndexList IndexList,int ClearValue/*=0*/) {}
	///<summary>GetTriangleListLength</summary>
	public static int GetTriangleListLength(FGeometryScriptTriangleList TriangleList) { return default; }
	///<summary>GetTriangleListLastTriangle</summary>
	public static int GetTriangleListLastTriangle(FGeometryScriptTriangleList TriangleList) { return default; }
	///<summary>GetTriangleListItem</summary>
	public static FIntVector GetTriangleListItem(FGeometryScriptTriangleList TriangleList,int Triangle,bool bIsValidTriangle) { return default; }
	///<summary>ConvertTriangleListToArray</summary>
	public static void ConvertTriangleListToArray(FGeometryScriptTriangleList TriangleList,TArray<FIntVector> TriangleArray) {}
	///<summary>ConvertArrayToTriangleList</summary>
	public static void ConvertArrayToTriangleList(TArray<FIntVector> TriangleArray,FGeometryScriptTriangleList TriangleList) {}
	///<summary>GetScalarListLength</summary>
	public static int GetScalarListLength(FGeometryScriptScalarList ScalarList) { return default; }
	///<summary>GetScalarListLastIndex</summary>
	public static int GetScalarListLastIndex(FGeometryScriptScalarList ScalarList) { return default; }
	///<summary>GetScalarListItem</summary>
	public static double GetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,bool bIsValidIndex) { return default; }
	///<summary>SetScalarListItem</summary>
	public static void SetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,double NewValue,bool bIsValidIndex) {}
	///<summary>ConvertScalarListToArray</summary>
	public static void ConvertScalarListToArray(FGeometryScriptScalarList ScalarList,TArray<double> ScalarArray) {}
	///<summary>ConvertArrayToScalarList</summary>
	public static void ConvertArrayToScalarList(TArray<double> VectorArray,FGeometryScriptScalarList ScalarList) {}
	///<summary>DuplicateScalarList</summary>
	public static void DuplicateScalarList(FGeometryScriptScalarList ScalarList,FGeometryScriptScalarList DuplicateList) {}
	///<summary>ClearScalarList</summary>
	public static void ClearScalarList(FGeometryScriptScalarList ScalarList,double ClearValue/*=0.0*/) {}
	///<summary>GetVectorListLength</summary>
	public static int GetVectorListLength(FGeometryScriptVectorList VectorList) { return default; }
	///<summary>GetVectorListLastIndex</summary>
	public static int GetVectorListLastIndex(FGeometryScriptVectorList VectorList) { return default; }
	///<summary>GetVectorListItem</summary>
	public static FVector GetVectorListItem(FGeometryScriptVectorList VectorList,int Index,bool bIsValidIndex) { return default; }
	///<summary>SetVectorListItem</summary>
	public static void SetVectorListItem(FGeometryScriptVectorList VectorList,int Index,FVector NewValue,bool bIsValidIndex) {}
	///<summary>ConvertVectorListToArray</summary>
	public static void ConvertVectorListToArray(FGeometryScriptVectorList VectorList,TArray<FVector> VectorArray) {}
	///<summary>ConvertArrayToVectorList</summary>
	public static void ConvertArrayToVectorList(TArray<FVector> VectorArray,FGeometryScriptVectorList VectorList) {}
	///<summary>DuplicateVectorList</summary>
	public static void DuplicateVectorList(FGeometryScriptVectorList VectorList,FGeometryScriptVectorList DuplicateList) {}
	///<summary>ClearVectorList</summary>
	public static void ClearVectorList(FGeometryScriptVectorList VectorList,FVector ClearValue/*=FVector.ZeroVector*/) {}
	///<summary>GetUVListLength</summary>
	public static int GetUVListLength(FGeometryScriptUVList UVList) { return default; }
	///<summary>GetUVListLastIndex</summary>
	public static int GetUVListLastIndex(FGeometryScriptUVList UVList) { return default; }
	///<summary>GetUVListItem</summary>
	public static FVector2D GetUVListItem(FGeometryScriptUVList UVList,int Index,bool bIsValidIndex) { return default; }
	///<summary>SetUVListItem</summary>
	public static void SetUVListItem(FGeometryScriptUVList UVList,int Index,FVector2D NewUV,bool bIsValidIndex) {}
	///<summary>ConvertUVListToArray</summary>
	public static void ConvertUVListToArray(FGeometryScriptUVList UVList,TArray<FVector2D> UVArray) {}
	///<summary>ConvertArrayToUVList</summary>
	public static void ConvertArrayToUVList(TArray<FVector2D> UVArray,FGeometryScriptUVList UVList) {}
	///<summary>DuplicateUVList</summary>
	public static void DuplicateUVList(FGeometryScriptUVList UVList,FGeometryScriptUVList DuplicateList) {}
	///<summary>ClearUVList</summary>
	public static void ClearUVList(FGeometryScriptUVList UVList,FVector2D ClearUV) {}
	///<summary>GetColorListLength</summary>
	public static int GetColorListLength(FGeometryScriptColorList ColorList) { return default; }
	///<summary>GetColorListLastIndex</summary>
	public static int GetColorListLastIndex(FGeometryScriptColorList ColorList) { return default; }
	///<summary>GetColorListItem</summary>
	public static FLinearColor GetColorListItem(FGeometryScriptColorList ColorList,int Index,bool bIsValidIndex) { return default; }
	///<summary>SetColorListItem</summary>
	public static void SetColorListItem(FGeometryScriptColorList ColorList,int Index,FLinearColor NewColor,bool bIsValidIndex) {}
	///<summary>ConvertColorListToArray</summary>
	public static void ConvertColorListToArray(FGeometryScriptColorList ColorList,TArray<FLinearColor> ColorArray) {}
	///<summary>ConvertArrayToColorList</summary>
	public static void ConvertArrayToColorList(TArray<FLinearColor> ColorArray,FGeometryScriptColorList ColorList) {}
	///<summary>DuplicateColorList</summary>
	public static void DuplicateColorList(FGeometryScriptColorList ColorList,FGeometryScriptColorList DuplicateList) {}
	///<summary>ClearColorList</summary>
	public static void ClearColorList(FGeometryScriptColorList ColorList,FLinearColor ClearColor) {}
	///<summary>ExtractColorListChannel</summary>
	public static void ExtractColorListChannel(FGeometryScriptColorList ColorList,FGeometryScriptScalarList ScalarList,int ChannelIndex/*=0*/) {}
	///<summary>ExtractColorListChannels</summary>
	public static void ExtractColorListChannels(FGeometryScriptColorList ColorList,FGeometryScriptVectorList VectorList,int XChannelIndex/*=0*/,int YChannelIndex/*=1*/,int ZChannelIndex/*=2*/) {}
}
