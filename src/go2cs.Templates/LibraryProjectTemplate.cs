﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace go2cs.Templates
{
    using System.Collections.Generic;
    using go2cs;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LibraryProjectTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
 // This template creates a <AssemblyName>.csproj file 
            
            #line default
            #line hidden
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <OutputType>Library</" +
                    "OutputType>\r\n    <TargetFramework>netcoreapp3.1</TargetFramework>\r\n    <RootName" +
                    "space>go</RootNamespace>\r\n    <AssemblyName>");
            
            #line 15 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssemblyName));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <Product>go2cs</Product>\r\n    <Copyright>Copyright © ");
            
            #line 17 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now.ToString("yyyy")));
            
            #line default
            #line hidden
            this.Write(@"</Copyright>
    <PackageProjectUrl>https://github.com/GridProtectionAlliance/go2cs</PackageProjectUrl>
    <RepositoryUrl>https://github.com/GridProtectionAlliance/go2cs</RepositoryUrl>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <Nullable>enable</Nullable>
    <NoWarn>660;661;IDE1006</NoWarn>
    <Version>0.1.0</Version>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include=""golib"">
      <HintPath>$(GOPATH)\src\go2cs\golib\$(OutDir)golib.dll</HintPath>
    </Reference>");
            
            #line 29 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"


    if (!(Imports is null))
    {
        foreach (string value in Imports)
        {
            if (string.IsNullOrWhiteSpace(value))
                continue;

            importPath = value;
            string package;

            if (importPath.Contains('/'))
            {
                string[] parts = importPath.Split('/');
                package = parts[^1];
                parts[0] = $"go2cs.{parts[0]}";
                importPath = string.Join('/', parts);
            }
            else
            {
                package = importPath;
                importPath = $"go2cs/{importPath}";
            }

            importPath = $"$(GOPATH)\\src\\{importPath.Replace('/', '\\')}\\$(OutDir){package}_package.dll";
            
            #line default
            #line hidden
            this.Write("\r\n    <Reference Include=\"");
            
            #line 56 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(package));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <HintPath>");
            
            #line 57 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(importPath));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n    </Reference>");
            
            #line 58 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"

        }
    }

    
            
            #line default
            #line hidden
            this.Write("\r\n  </ItemGroup>\r\n\r\n</Project>\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 67 "D:\Projects\go2cs\src\go2cs.Templates\LibraryProjectTemplate.tt"

// Template Parameters
public string AssemblyName;  // File name without extension
public IEnumerable<string> Imports;

private string importPath;

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}