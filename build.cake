// #addin Cake.Docker
// #load nuget:?package=ce.devops.scripts.build.cake&version=0.1.101
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Web;

Task("test")
    .Does(() => {
        var solution = ParseSolution(@"C:\Users\H156257.PACRIM1\Desktop\cakeScriptTrials\TestSolution\TestSolution.sln");
        var projects = solution.GetProjects();     
    });

RunTarget("test");
