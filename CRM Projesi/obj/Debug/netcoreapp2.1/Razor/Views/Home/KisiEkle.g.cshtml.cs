#pragma checksum "C:\Users\Ertekin\source\repos\CRM Projesi\CRM Projesi\Views\Home\KisiEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d44d48c5baed3fcda148424335589877e0f6bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_KisiEkle), @"mvc.1.0.view", @"/Views/Home/KisiEkle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/KisiEkle.cshtml", typeof(AspNetCore.Views_Home_KisiEkle))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ertekin\source\repos\CRM Projesi\CRM Projesi\Views\_ViewImports.cshtml"
using CRM_Projesi;

#line default
#line hidden
#line 2 "C:\Users\Ertekin\source\repos\CRM Projesi\CRM Projesi\Views\_ViewImports.cshtml"
using CRM_Projesi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d44d48c5baed3fcda148424335589877e0f6bd4", @"/Views/Home/KisiEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f822b0f17273b936adba6178dabbdb0ae036a10b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_KisiEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mr.", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ms.", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 3481, true);
            WriteLiteral(@"
<!------ Include the above in your HEAD tag ---------->
<!--
    Realised by Thibault Leveau
    https://www.linkedin.com/in/thibault-leveau-a76923ba/
-->
<style>
    .card {
        margin-top: 1em;
    }

    /* IMG displaying */
    .person-card {
            margin-top: 5em;
            padding-top: 5em;
    }
    .person-card .card-title {
            text-align: center;
     }
   

        .person-card .person-img {
            width: 10em;
            position: absolute;
            top: -5em;
            left: 50%;
            margin-left: -5em;
            border-radius: 100%;
            overflow: hidden;
            background-color: white;
        }
</style>
<script>
    var female_img = ""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSo8PcCxh7tT6MDFhJi2UaAT9SeciHqvZuaWtGg0y0-yyP8rMDz"";
var male_img = ""https://visualpharm.com/assets/217/Life%20Cycle-595b40b75ba036ed117d9ef0.svg"";

// On page loaded
$( document ).ready(function() {
    // Set the sex image
 ");
            WriteLiteral(@"   set_sex_img();
    
    // Set the ""who"" message
    set_who_message();

    // On change sex input
    $(""#input_sex"").change(function() {
        // Set the sex image
        set_sex_img();
        set_who_message();
    });

    // On change fist name input
    $(""#first_name"").keyup(function() {
        // Set the ""who"" message
        set_who_message();
        
        if(validation_name($(""#first_name"").val()).code == 0) {
            $(""#first_name"").attr(""class"", ""form-control is-invalid"");
            $(""#first_name_feedback"").html(validation_name($(""#first_name"").val()).message);
        } else {
            $(""#first_name"").attr(""class"", ""form-control"");
        }
    });

    // On change last name input
    $(""#last_name"").keyup(function() {
        // Set the ""who"" message
        set_who_message();
        
        if(validation_name($(""#last_name"").val()).code == 0) {
            $(""#last_name"").attr(""class"", ""form-control is-invalid"");
            $(""#last_name_feedback"").html(validation_");
            WriteLiteral(@"name($(""#last_name"").val()).message);
        } else {
            $(""#last_name"").attr(""class"", ""form-control"");
        }
    });
});

/**
*   Set image path (Mr. or Ms.)
*/
function set_sex_img() {
    var sex = $(""#input_sex"").val();
    if (sex == ""Mr."") {
        // male
        $(""#img_sex"").attr(""src"", male_img);
    } else {
        // female
        $(""#img_sex"").attr(""src"", female_img);
    }
}

/**
*   Set ""who"" message
*/
function set_who_message() {
    var sex = $(""#input_sex"").val();
    var first_name = $(""#first_name"").val();
    var last_name = $(""#last_name"").val();
    
    if (validation_name(first_name).code == 0 || 
        validation_name(last_name).code == 0) {
        // Informations not completed
        $(""#who_message"").html(""Who are you ?"");
    } else {
        // Informations completed
        $(""#who_message"").html(sex+"" ""+first_name+"" ""+last_name);
    }
}

/**
*   Validation function for last name and first name
*/
function validation_name (val) {
    if (val.length < 2) {
");
            WriteLiteral(@"        // is not valid : name length
        return {""code"":0, ""message"":""The name is too short.""};
    }
    if (!val.match(""^[a-zA-Z\- ]+$"")) {
        // is not valid : bad character
        return {""code"":0, ""message"":""The name use non-alphabetics chars.""};
    }
    
    // is valid
    return {""code"": 1};
}
</script>
<div class=""container"" style=""margin-top: 1em;"">
    <!-- Sign up form -->
    ");
            EndContext();
            BeginContext(3601, 3825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edb513bfae3a477f85f5c04dc41b6865", async() => {
                BeginContext(3607, 625, true);
                WriteLiteral(@"
        <!-- Sign up card -->
        <div class=""card person-card"">
            <div class=""card-body"">
                <!-- Sex image -->
                <img id=""img_sex"" class=""person-img""
                     src=""https://visualpharm.com/assets/217/Life%20Cycle-595b40b75ba036ed117d9ef0.svg"">
                <h2 id=""who_message"" class=""card-title"">Who are you ?</h2>
                <!-- First row (on medium screen) -->
                <div class=""row"">
                    <div class=""form-group col-md-2"">
                        <select id=""input_sex"" class=""form-control"">
                            ");
                EndContext();
                BeginContext(4232, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c967535648141c283bac094e592e946", async() => {
                    BeginContext(4252, 3, true);
                    WriteLiteral("Mr.");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4264, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4294, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96442da23dfc4d68940d7308538af3b1", async() => {
                    BeginContext(4314, 3, true);
                    WriteLiteral("Ms.");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4326, 3093, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group col-md-5"">
                        <input id=""first_name"" type=""text"" class=""form-control"" placeholder=""First name"">
                        <div id=""first_name_feedback"" class=""invalid-feedback"">

                        </div>
                    </div>
                    <div class=""form-group col-md-5"">
                        <input id=""last_name"" type=""text"" class=""form-control"" placeholder=""Last name"">
                        <div id=""last_name_feedback"" class=""invalid-feedback"">

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-6"" style=""padding=0.5em;"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h2 class=""card-title"">How to contact you ?</h2>
                        <div class=""form-group"">");
                WriteLiteral(@"
                            <label for=""email"" class=""col-form-label"">Email</label>
                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""example@gmail.com"" required>
                            <div class=""email-feedback"">

                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""tel"" class=""col-form-label"">Phone number</label>
                            <input type=""text"" class=""form-control"" id=""tel"" placeholder=""+33 6 99 99 99 99"" required>
                            <div class=""phone-feedback"">

                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h2 class=""card-title"">Securize your account !</h2>
                        <div cl");
                WriteLiteral(@"ass=""form-group"">
                            <label for=""password"" class=""col-form-label"">Pasword</label>
                            <input type=""password"" class=""form-control"" id=""password"" placeholder=""Type your password"" required>
                            <div class=""password-feedback"">

                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""password_conf"" class=""col-form-label"">Pasword (confirm)</label>
                            <input type=""password"" class=""form-control"" id=""password_conf"" placeholder=""Type your password again"" required>
                            <div class=""password_conf-feedback"">

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style=""margin-top: 1em;"">
            <button type=""button"" class=""btn btn-primary btn-lg btn-block"">Sign up !</button>");
                WriteLiteral("\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7426, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
