using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClockiFyAMS.Database;


namespace ClockiFyAMS
{
    public class PythonBridge
    {
        ScriptEngine pyEngine;
        public void PrepareEngine()
        {
            pyEngine = Python.CreateEngine();
            ICollection<string> searchPath = pyEngine.GetSearchPaths();
            searchPath.Add(@".\QRScanner");
            searchPath.Add(@".");
            pyEngine.SetSearchPaths(searchPath);
        }

        public void runCreate()
        {
            pyEngine = Python.CreateEngine();
            ICollection<string> searchPath = pyEngine.GetSearchPaths();
            searchPath.Add(@".");
            pyEngine.SetSearchPaths(searchPath);

            ScriptSource pyScript = pyEngine.CreateScriptSourceFromFile(@"Adapter.py");
            ScriptScope pyScope = pyEngine.CreateScope();

            pyScript.Execute(pyScope);
            //var pyClass = pyScope.GetVariable("Bridge");
            //var pyInstance = pyEngine.Operations.CreateInstance(pyClass);

            ////pyScope.SetVariable("uid", config.WorkerObj.UID);
            ////pyScope.SetVariable("name", config.WorkerObj.FullName);
            ////pyInstance.CreateObject();

            //MessageBox.Show(pyInstance.test());
            
        }



    }
}
