#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CSVtoSVGArguments.h")]
public partial class UCSVtoSVGArugments : UEditorConfigBase {
// CSVtoSVGArugments
	public FFilePath CSV;
	public FDirectoryPath OutputDirectory;
	public string OutputFilename;
	public int skipRows;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	public bool smooth;
	public int smoothKernelSize;
	public float smoothKernelPercent;
	public int width;
	public int height;
	public string title;
	public bool noMetadata;
	public bool graphOnly;
	public float budget;
	public float thickness;
	public ESVGTheme theme;
	public float threshold;
	public bool stacked;
	public string stacktotalstack;
	public bool interactive;
	public bool showaverages;
	public int colourOffset;
	public float averageThreshold;
}
