// Copyright (c) Speykious
// This file is part of V4l2.AutoGen.
// V4l2.AutoGen is licensed under the MIT License. See LICENSE for details.

using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;

namespace V4l2.CppSharpGenerator;

public class V4l2Library : ILibrary
{
    private const string lib_name = "NativeFileDialogs";

    public void Setup(Driver driver)
    {
        DriverOptions options = driver.Options;
        options.GeneratorKind = GeneratorKind.CSharp;
        options.OutputDir = $"../{lib_name}.AutoGen";
        var module = options.AddModule("v4l2");
        module.IncludeDirs.Add(@"/usr/include/linux");
        module.Headers.Add("videodev2.h");
        module.OutputNamespace = $"{lib_name}.AutoGen";
    }

    public void SetupPasses(Driver driver)
    {
        driver.Context.TranslationUnitPasses.RenameDeclsUpperCase(RenameTargets.Any);
    }

    public void Preprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Postprocess(Driver driver, ASTContext ctx)
    {
    }
}
