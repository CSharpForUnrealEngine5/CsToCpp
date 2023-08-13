namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithTextureElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithTextureElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Get texture filename</summary>
	public string GetFile() { return default; }
	///<summary>Set texture filename</summary>
	public void SetFile(string File) {}
	///<summary>Get texture usage</summary>
	public EDatasmithTextureMode GetTextureMode() { return default; }
	///<summary>Set texture usage</summary>
	public void SetTextureMode(EDatasmithTextureMode Mode) {}
	///<summary>Get allow texture resizing</summary>
	public bool GetAllowResize() { return default; }
	///<summary>Set allow texture resizing</summary>
	public void SetAllowResize(bool bAllowResize) {}
	///<summary>Get texture gamma &lt;= 0 for auto</summary>
	public float GetRGBCurve() { return default; }
	///<summary>Set texture gamma &lt;= 0 for auto</summary>
	public void SetRGBCurve(float InRGBCurve) {}
	///<summary>Gets the color space of the texture</summary>
	public EDatasmithColorSpace GetColorSpace() { return default; }
	///<summary>Sets the color space of the texture</summary>
	public void SetColorSpace(EDatasmithColorSpace Option) {}
}
