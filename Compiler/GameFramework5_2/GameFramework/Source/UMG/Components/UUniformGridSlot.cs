#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/UniformGridSlot.h")]
///<summary>A slot for UUniformGridPanel, these slots all share the same size as the largest slot</summary>
public partial class UUniformGridSlot : UPanelSlot {
// UniformGridSlot
	public byte HorizontalAlignment;
	public byte VerticalAlignment;
	public int Row;
	public int Column;
	public void SetRow(int InRow) {}
	public void SetColumn(int InColumn) {}
	public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment) {}
	public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment) {}
}
