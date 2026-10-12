using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.Documents.Languages;

/// <summary>TeX, LaTeX and BibTeX: their files, highlighting, comments and brackets.</summary>
public sealed class LatexLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Tex { get; } = new("tex", "TeX")
    {
        Extensions = [".sty", ".cls", ".bbx", ".cbx"],
        ScopeName = "text.tex",
        LineComment = "%",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')'), ('[', ')'), ('(', ']')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Latex { get; } = new("latex", "LaTeX")
    {
        Extensions = [".tex", ".ltx", ".ctx"],
        ScopeName = "text.tex.latex",
        LineComment = "%",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')'), ('[', ')'), ('(', ']')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Bibtex { get; } = new("bibtex", "BibTeX")
    {
        Extensions = [".bib"],
        ScopeName = "text.bibtex",
        Brackets = [('(', ')'), ('[', ']'), ('{', '}')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition TexGrammar { get; } = GrammarFiles.Find("text.tex", "latex/TeX.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition LatexGrammar { get; } = GrammarFiles.Find("text.tex.latex", "latex/LaTeX.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition BibtexGrammar { get; } = GrammarFiles.Find("text.bibtex", "latex/Bibtex.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition TextTexMarkdownLatexCombinedGrammar { get; } = GrammarFiles.Find("text.tex.markdown_latex_combined", "latex/markdown-latex-combined.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceCppEmbeddedLatexGrammar { get; } = GrammarFiles.Find("source.cpp.embedded.latex", "latex/cpp-grammar-bailout.tmLanguage.json");
}
