#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ListUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_ListUtilityFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_ListUtilityFunctions
	public static int GetIndexListLength(FGeometryScriptIndexList IndexList) { return default; }
	public static int GetIndexListLastIndex(FGeometryScriptIndexList IndexList) { return default; }
	public static int GetIndexListItem(FGeometryScriptIndexList IndexList,int Index,bool bIsValidIndex) { return default; }
	public static void SetIndexListItem(FGeometryScriptIndexList IndexList,int Index,int NewValue,bool bIsValidIndex) {}
	public static void ConvertIndexListToArray(FGeometryScriptIndexList IndexList,TArray<int> IndexArray) {}
	public static void ConvertArrayToIndexList(TArray<int> IndexArray,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType IndexType/*=EGeometryScriptIndexType.Any*/) {}
	public static void DuplicateIndexList(FGeometryScriptIndexList IndexList,FGeometryScriptIndexList DuplicateList) {}
	public static void ClearIndexList(FGeometryScriptIndexList IndexList,int ClearValue/*=0*/) {}
	public static int GetTriangleListLength(FGeometryScriptTriangleList TriangleList) { return default; }
	public static int GetTriangleListLastTriangle(FGeometryScriptTriangleList TriangleList) { return default; }
	public static FIntVector GetTriangleListItem(FGeometryScriptTriangleList TriangleList,int Triangle,bool bIsValidTriangle) { return default; }
	public static void ConvertTriangleListToArray(FGeometryScriptTriangleList TriangleList,TArray<FIntVector> TriangleArray) {}
	public static void ConvertArrayToTriangleList(TArray<FIntVector> TriangleArray,FGeometryScriptTriangleList TriangleList) {}
	public static int GetScalarListLength(FGeometryScriptScalarList ScalarList) { return default; }
	public static int GetScalarListLastIndex(FGeometryScriptScalarList ScalarList) { return default; }
	public static double GetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,bool bIsValidIndex) { return default; }
	public static void SetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,double NewValue,bool bIsValidIndex) {}
	public static void ConvertScalarListToArray(FGeometryScriptScalarList ScalarList,TArray<double> ScalarArray) {}
	public static void ConvertArrayToScalarList(TArray<double> VectorArray,FGeometryScriptScalarList ScalarList) {}
	public static void DuplicateScalarList(FGeometryScriptScalarList ScalarList,FGeometryScriptScalarList DuplicateList) {}
	public static void ClearScalarList(FGeometryScriptScalarList ScalarList,double ClearValue/*=0.0*/) {}
	public static int GetVectorListLength(FGeometryScriptVectorList VectorList) { return default; }
	public static int GetVectorListLastIndex(FGeometryScriptVectorList VectorList) { return default; }
	public static FVector GetVectorListItem(FGeometryScriptVectorList VectorList,int Index,bool bIsValidIndex) { return default; }
	public static void SetVectorListItem(FGeometryScriptVectorList VectorList,int Index,FVector NewValue,bool bIsValidIndex) {}
	public static void ConvertVectorListToArray(FGeometryScriptVectorList VectorList,TArray<FVector> VectorArray) {}
	public static void ConvertArrayToVectorList(TArray<FVector> VectorArray,FGeometryScriptVectorList VectorList) {}
	public static void DuplicateVectorList(FGeometryScriptVectorList VectorList,FGeometryScriptVectorList DuplicateList) {}
	public static void ClearVectorList(FGeometryScriptVectorList VectorList,FVector ClearValue/*=FVector.ZeroVector*/) {}
	public static int GetUVListLength(FGeometryScriptUVList UVList) { return default; }
	public static int GetUVListLastIndex(FGeometryScriptUVList UVList) { return default; }
	public static FVector2D GetUVListItem(FGeometryScriptUVList UVList,int Index,bool bIsValidIndex) { return default; }
	public static void SetUVListItem(FGeometryScriptUVList UVList,int Index,FVector2D NewUV,bool bIsValidIndex) {}
	public static void ConvertUVListToArray(FGeometryScriptUVList UVList,TArray<FVector2D> UVArray) {}
	public static void ConvertArrayToUVList(TArray<FVector2D> UVArray,FGeometryScriptUVList UVList) {}
	public static void DuplicateUVList(FGeometryScriptUVList UVList,FGeometryScriptUVList DuplicateList) {}
	public static void ClearUVList(FGeometryScriptUVList UVList,FVector2D ClearUV) {}
	public static int GetColorListLength(FGeometryScriptColorList ColorList) { return default; }
	public static int GetColorListLastIndex(FGeometryScriptColorList ColorList) { return default; }
	public static FLinearColor GetColorListItem(FGeometryScriptColorList ColorList,int Index,bool bIsValidIndex) { return default; }
	public static void SetColorListItem(FGeometryScriptColorList ColorList,int Index,FLinearColor NewColor,bool bIsValidIndex) {}
	public static void ConvertColorListToArray(FGeometryScriptColorList ColorList,TArray<FLinearColor> ColorArray) {}
	public static void ConvertArrayToColorList(TArray<FLinearColor> ColorArray,FGeometryScriptColorList ColorList) {}
	public static void DuplicateColorList(FGeometryScriptColorList ColorList,FGeometryScriptColorList DuplicateList) {}
	public static void ClearColorList(FGeometryScriptColorList ColorList,FLinearColor ClearColor) {}
	public static void ExtractColorListChannel(FGeometryScriptColorList ColorList,FGeometryScriptScalarList ScalarList,int ChannelIndex/*=0*/) {}
	public static void ExtractColorListChannels(FGeometryScriptColorList ColorList,FGeometryScriptVectorList VectorList,int XChannelIndex/*=0*/,int YChannelIndex/*=1*/,int ZChannelIndex/*=2*/) {}
}
