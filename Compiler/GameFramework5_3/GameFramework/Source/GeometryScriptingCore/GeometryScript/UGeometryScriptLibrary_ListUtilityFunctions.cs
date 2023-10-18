namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ListUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_ListUtilityFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the number of Items in Index List.</summary>
	public static int GetIndexListLength(FGeometryScriptIndexList IndexList) { return default; }
	///<summary>Returns the index of the last element in the Index List.</summary>
	public static int GetIndexListLastIndex(FGeometryScriptIndexList IndexList) { return default; }
	///<summary>Returns the item associated with Index in the Index List.</summary>
	public static int GetIndexListItem(FGeometryScriptIndexList IndexList,int Index,bool bIsValidIndex) { return default; }
	///<summary>Updates the value associated with Index in the Index List.</summary>
	public static void SetIndexListItem(FGeometryScriptIndexList IndexList,int Index,int NewValue,bool bIsValidIndex) {}
	///<summary>Populates Index Array with the integer values stored in the Index List.</summary>
	public static void ConvertIndexListToArray(FGeometryScriptIndexList IndexList,TArray<int> IndexArray) {}
	///<summary>Populates Index List of the specified Index Type from the integer values stored in the Index Array.</summary>
	public static void ConvertArrayToIndexList(TArray<int> IndexArray,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType IndexType/*=EGeometryScriptIndexType.Any*/) {}
	///<summary>Updates Duplicate List to be identical to Index List.</summary>
	public static void DuplicateIndexList(FGeometryScriptIndexList IndexList,FGeometryScriptIndexList DuplicateList) {}
	///<summary>Set each value in Index List to the given Clear Value.</summary>
	public static void ClearIndexList(FGeometryScriptIndexList IndexList,int ClearValue/*=0*/) {}
	///<summary>Returns the number of Triangles in the  Triangle list.</summary>
	public static int GetTriangleListLength(FGeometryScriptTriangleList TriangleList) { return default; }
	///<summary>Returns the index of the last element in the Triangle List.</summary>
	public static int GetTriangleListLastTriangle(FGeometryScriptTriangleList TriangleList) { return default; }
	///<summary>Returns the integer triplet associated with the index Triangle in the Triangle  List.</summary>
	public static FIntVector GetTriangleListItem(FGeometryScriptTriangleList TriangleList,int Triangle,bool bIsValidTriangle) { return default; }
	///<summary>Converts Triangle List to Triangle Array by populating with the appropriate integer triplets.</summary>
	public static void ConvertTriangleListToArray(FGeometryScriptTriangleList TriangleList,TArray<FIntVector> TriangleArray) {}
	///<summary>Converts a Triangle Array of integer triplets to a Triangle List.</summary>
	public static void ConvertArrayToTriangleList(TArray<FIntVector> TriangleArray,FGeometryScriptTriangleList TriangleList) {}
	///<summary>Returns the number of items in the Scalar List.</summary>
	public static int GetScalarListLength(FGeometryScriptScalarList ScalarList) { return default; }
	///<summary>Returns the index of the last Scalar in Scalar List.</summary>
	public static int GetScalarListLastIndex(FGeometryScriptScalarList ScalarList) { return default; }
	///<summary>Returns the Scalar value associated with Index in Scalar List.</summary>
	public static double GetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,bool bIsValidIndex) { return default; }
	///<summary>Updates the value associated with Index in the Scalar List.</summary>
	public static void SetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,double NewValue,bool bIsValidIndex) {}
	///<summary>Converts a Scalar List to an Scalar Array (an array of doubles).</summary>
	public static void ConvertScalarListToArray(FGeometryScriptScalarList ScalarList,TArray<double> ScalarArray) {}
	///<summary>Converts an array of doubles (Scalar Array) to Scalar List.</summary>
	public static void ConvertArrayToScalarList(TArray<double> VectorArray,FGeometryScriptScalarList ScalarList) {}
	///<summary>Copies the contents of Scalar List into Duplicate List.</summary>
	public static void DuplicateScalarList(FGeometryScriptScalarList ScalarList,FGeometryScriptScalarList DuplicateList) {}
	///<summary>Resets all the items in the Scalar List to the Clear Value.</summary>
	public static void ClearScalarList(FGeometryScriptScalarList ScalarList,double ClearValue/*=0.0*/) {}
	///<summary>Returns the number of items in the Vector List.</summary>
	public static int GetVectorListLength(FGeometryScriptVectorList VectorList) { return default; }
	///<summary>Returns the index of the last item in the Vector List.</summary>
	public static int GetVectorListLastIndex(FGeometryScriptVectorList VectorList) { return default; }
	///<summary>Returns the FVector stored in the VectorList at the specified location.</summary>
	public static FVector GetVectorListItem(FGeometryScriptVectorList VectorList,int Index,bool bIsValidIndex) { return default; }
	///<summary>Updates the value of the FVector stored in the Vector List at the specified location.</summary>
	public static void SetVectorListItem(FGeometryScriptVectorList VectorList,int Index,FVector NewValue,bool bIsValidIndex) {}
	///<summary>Converts Vector List to an array of FVectors (Vector Array).</summary>
	public static void ConvertVectorListToArray(FGeometryScriptVectorList VectorList,TArray<FVector> VectorArray) {}
	///<summary>Converts an Array of FVectors (Vector Array) to Vector List.</summary>
	public static void ConvertArrayToVectorList(TArray<FVector> VectorArray,FGeometryScriptVectorList VectorList) {}
	///<summary>Copies the contents of Vector List into Duplicate Vector List.</summary>
	public static void DuplicateVectorList(FGeometryScriptVectorList VectorList,FGeometryScriptVectorList DuplicateList) {}
	///<summary>Resets all the items in the Vector List to the Clear Value.</summary>
	public static void ClearVectorList(FGeometryScriptVectorList VectorList,FVector ClearValue/*=FVector.ZeroVector*/) {}
	///<summary>Returns the number of items in the UV List.</summary>
	public static int GetUVListLength(FGeometryScriptUVList UVList) { return default; }
	///<summary>Returns the index of the last item in the UV List.</summary>
	public static int GetUVListLastIndex(FGeometryScriptUVList UVList) { return default; }
	///<summary>Returns the FVector2D stored in the UV List at the specified location.</summary>
	public static FVector2D GetUVListItem(FGeometryScriptUVList UVList,int Index,bool bIsValidIndex) { return default; }
	///<summary>Updates the value of the FVector2D stored in the UV List at the specified location.</summary>
	public static void SetUVListItem(FGeometryScriptUVList UVList,int Index,FVector2D NewUV,bool bIsValidIndex) {}
	///<summary>Converts a UV List to an array of FVector2Ds (UV Array).</summary>
	public static void ConvertUVListToArray(FGeometryScriptUVList UVList,TArray<FVector2D> UVArray) {}
	///<summary>Converts an array of FVector2D (UV Array) to UV List.</summary>
	public static void ConvertArrayToUVList(TArray<FVector2D> UVArray,FGeometryScriptUVList UVList) {}
	///<summary>Duplicates the contents of UV List into Duplicate List.</summary>
	public static void DuplicateUVList(FGeometryScriptUVList UVList,FGeometryScriptUVList DuplicateList) {}
	///<summary>Resets all the items in the Vector List to the given Clear UV value.</summary>
	public static void ClearUVList(FGeometryScriptUVList UVList,FVector2D ClearUV) {}
	///<summary>Returns the number of items in the Color List.</summary>
	public static int GetColorListLength(FGeometryScriptColorList ColorList) { return default; }
	///<summary>Returns the index of the last item in the Color List.</summary>
	public static int GetColorListLastIndex(FGeometryScriptColorList ColorList) { return default; }
	///<summary>Returns the FLinearColor stored in the Color List at the specified location.</summary>
	public static FLinearColor GetColorListItem(FGeometryScriptColorList ColorList,int Index,bool bIsValidIndex) { return default; }
	///<summary>Updates the value of the FLinearColor stored in the Color List at the specified location.</summary>
	public static void SetColorListItem(FGeometryScriptColorList ColorList,int Index,FLinearColor NewColor,bool bIsValidIndex) {}
	///<summary>Converts the Color List to an array of FLinearColor (Color Array).</summary>
	public static void ConvertColorListToArray(FGeometryScriptColorList ColorList,TArray<FLinearColor> ColorArray) {}
	///<summary>Converts an array of FLinearColor (Color Array) to a Color List.</summary>
	public static void ConvertArrayToColorList(TArray<FLinearColor> ColorArray,FGeometryScriptColorList ColorList) {}
	///<summary>Duplicates the contents of Color List into Duplicate List.</summary>
	public static void DuplicateColorList(FGeometryScriptColorList ColorList,FGeometryScriptColorList DuplicateList) {}
	///<summary>Resets all the items in the Color List to the specified Clear Color.</summary>
	public static void ClearColorList(FGeometryScriptColorList ColorList,FLinearColor ClearColor) {}
	///<summary>Populates a Scalar List with values that corresponds to the 0, 1, 2, or 3 channel of a Color List.</summary>
	public static void ExtractColorListChannel(FGeometryScriptColorList ColorList,FGeometryScriptScalarList ScalarList,int ChannelIndex/*=0*/) {}
	///<summary>Populates a Vector List from a Color List. The channels in the Color List are mapped to vector components by means of X Channel Index, Y Channel Index, and Z Channel Index.</summary>
	public static void ExtractColorListChannels(FGeometryScriptColorList ColorList,FGeometryScriptVectorList VectorList,int XChannelIndex/*=0*/,int YChannelIndex/*=1*/,int ZChannelIndex/*=2*/) {}
}
