namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Image Center table associating CxCy values to focus and zoom</summary>
[CppInclude("Tables/ImageCenterTable.h")]
public partial struct FImageCenterTable {
	public TArray<FImageCenterFocusPoint> FocusPoints;
}
