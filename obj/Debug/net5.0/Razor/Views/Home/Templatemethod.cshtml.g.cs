#pragma checksum "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Templatemethod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9a9f418df78e6923ff1897d4b6653659e409af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Templatemethod), @"mvc.1.0.view", @"/Views/Home/Templatemethod.cshtml")]
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
#nullable restore
#line 1 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9a9f418df78e6923ff1897d4b6653659e409af", @"/Views/Home/Templatemethod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Templatemethod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/code.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/templatemethod1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/templatemethod2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "K:\универ\program\Основы программирования на платформе .NET\экзамен\итоговый проект сайта\WebApplication1\WebApplication1\Views\Home\Templatemethod.cshtml"
  
    ViewBag.Title = " Шаблонный метод";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca9a9f418df78e6923ff1897d4b6653659e409af5022", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center"">
    <h1>
        Шаблонный метод (Template Method)
    </h1>
    <p class=""text-left"">Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.</p>
    <h2>Когда использовать шаблонный метод?</h2>

    <ul>
        <li class=""text-left"">Когда планируется, что в будущем подклассы должны будут переопределять различные этапы алгоритма без изменения его структуры</li>
        <li class=""text-left"">Когда в классах, реализующим схожий алгоритм, происходит дублирование кода. Вынесение общего кода в шаблонный метод уменьшит его дублирование в подклассах.</li>

    </ul>

    <p class=""text-left"">
        Схематично в UML алгоритм можно изобразить следующим образом:
    </p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca9a9f418df78e6923ff1897d4b6653659e409af6978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <p class=""text-left"">Формальная реализация паттерна на C#:</p>
    <div id=""hler_128284"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">AbstractClass</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">TemplateMethod()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Operation1();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Operation2();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Operat");
            WriteLiteral(@"ion1();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Operation2();</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">ConcreteClass : AbstractClass</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Operation1()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Operation2()</code><");
            WriteLiteral(@"/li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
    <h2>Участники</h2>
    <ul>
        <li class=""text-left"">AbstractClass: определяет шаблонный метод TemplateMethod(), который реализует алгоритм. Алгоритм может состоять из последовательности вызовов других методов, часть из которых может быть абстрактными и должны быть переопределены в классах-наследниках. При этом сам метод TemplateMethod(), представляющий структуру алгоритма, переопределяться не должен. </li>
        <li class=""text-left"">ConcreteClass: подкласс, который может переопределять различные методы родительского класса.</li>


    </ul>
    <p class=""text-left"">Рассмотрим применение на конкретном примере. Допустим, в нашей программе используются объекты, представляющие учебу в школе и в вузе:</p>
    <div id=""hler_521168"" class=""slgh""><ol class=""lines no-wrap""><li class=""al");
            WriteLiteral(@"t1""><code class=""keyword"">class</code> <code class=""plain"">School</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// идем в первый класс</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Enter() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// обучение</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Study() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// сдаем выпускные экзамены</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">PassExams() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// получение аттестата об окончании</code></li><li class=""alt2"">&nbsp;&nbsp;&nb");
            WriteLiteral(@"sp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">GetAttestat() { }</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">University</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// поступление в университет</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Enter() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// обучение</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Study() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// проходим практику</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</co");
            WriteLiteral(@"de> <code class=""keyword"">void</code> <code class=""plain"">Practice() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// сдаем выпускные экзамены</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">PassExams() { }</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">// получение диплома</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">GetDiploma() { }</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
    <p class=""text-left"">Как видно, эти классы очень похожи, и самое главное, реализуют примерно общий алгоритм. Да, где-то будет отличаться реализация методов, где-то чуть больше методов, но в целом мы имеем общий алгоритм, а функциональность обоих классов по большому счету дублируется. Поэтому для улучшения структуры классов мы могли бы применить шабл");
            WriteLiteral(@"онный метод:</p>
    <div id=""hler_242455"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">Program</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">static</code> <code class=""keyword"">void</code> <code class=""plain"">Main(</code><code class=""keyword"">string</code><code class=""plain"">[] args)</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">School school = </code><code class=""keyword"">new</code> <code class=""plain"">School();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">University university = </code><code class=""keyword"">new</code> <code class=""plain"">University();</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">school.Learn(");
            WriteLiteral(@");</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">university.Learn();</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Read();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1""><code class=""plain"">}</code></li><li class=""alt2""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">Education</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">void</code> <code class=""plain"">Learn()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Enter();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Study();</code></li><li class");
            WriteLiteral(@"=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">PassExams();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">GetDocument();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Enter();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Study();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">virtual</code> <code class=""keyword"">void</code> <code class=""plain"">PassExams()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.Wri");
            WriteLiteral(@"teLine(</code><code class=""string"">""Сдаем выпускные экзамены""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">GetDocument();</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">School : Education</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Enter()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">");
            WriteLiteral(@"""Идем в первый класс""</code><code class=""plain"">);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Study()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Посещаем уроки, делаем домашние задания""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">GetDocument()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li");
            WriteLiteral(@" class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Получаем аттестат о среднем образовании""</code><code class=""plain"">);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2""><code class=""keyword"">class</code> <code class=""plain"">University : Education</code></li><li class=""alt1""><code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Enter()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Сдаем вступительные экзамены и поступаем в ВУЗ""</code><code class=""plain"">);</code></li><li class=""alt1"">&");
            WriteLiteral(@"nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Study()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Посещаем лекции""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Проходим практику""</code><code class=""plain"">);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;</li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">PassExams()</co");
            WriteLiteral(@"de></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Сдаем экзамен по специальности""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;</li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">GetDocument()</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Получаем диплом о высшем образовании""</code><code class=""plain"">);</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <p class=""t");
            WriteLiteral(@"ext-left"">При этом в базовом классе необязательно определять все методы алгоритма как абстрактные. Можно определить реализацию методов по умолчанию, как в случае с методом PassExams().</p>
    <p class=""text-left"">И в результате работы программы консоль выведет:</p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca9a9f418df78e6923ff1897d4b6653659e409af23766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <p class=""text-left"">В данном случае надо отметить, что несмотря на то, что мы не можем в производном классе переопределить шаблонный метод Learn(), тем не менее мы можем скрыть реализацию этого метода в классе-наследнике:</p>
    <div id=""hler_801458"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">class</code> <code class=""plain"">School : Education</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">new</code> <code class=""keyword"">void</code> <code class=""plain"">Learn()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Console.WriteLine(</code><code class=""string"">""Не хочу учиться""</code><code class=""plain"">);</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">//...........");
            WriteLiteral(@"...............................</code></li><li class=""alt2""><code class=""plain"">}</code></li></ol></div>
    <p class=""text-left"">В итоге реализация шаблонного метода не будет иметь смысла.</p>
    <p class=""text-left"">Также надо отметить ситуацию с наследованием базового класса. Например, у нас может быть ситуация, когда базовый класс Education сам наследует метод Learn от другого класса:</p>
    <div id=""hler_321737"" class=""slgh""><ol class=""lines no-wrap""><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">Learning</code></li><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">abstract</code> <code class=""keyword"">void</code> <code class=""plain"">Learn();</code></li><li class=""alt2""><code class=""plain"">}</code></li><li class=""alt1""><code class=""keyword"">abstract</code> <code class=""keyword"">class</code> <code class=""plain"">Education :Learning</code></li");
            WriteLiteral(@"><li class=""alt2""><code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""keyword"">public</code> <code class=""keyword"">sealed</code> <code class=""keyword"">override</code> <code class=""keyword"">void</code> <code class=""plain"">Learn()</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">{</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Enter();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">Study();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">PassExams();</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">GetDocument();</code></li><li class=""alt1"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""plain"">}</code></li><li class=""alt2"">&nbsp;&nbsp;&nbsp;&nbsp;<code class=""comments"">//&nbsp; остальные методы класса</code></li><li class=""alt1""><code class=""plain"">}</code></li></ol></div>
");
            WriteLiteral("    <p class=\"text-left\">Чтобы сокрыть алгоритм от изменения в классах наследниках, метод Learn объявляется с ключевым словом sealed.</p>\r\n\r\n    \r\n\r\n</div>");
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