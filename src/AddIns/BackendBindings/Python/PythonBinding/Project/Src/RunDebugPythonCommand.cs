// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using ICSharpCode.Core;
using ICSharpCode.Scripting;
using ICSharpCode.SharpDevelop.Debugging;
using ICSharpCode.SharpDevelop.Gui;
using ICSharpCode.SharpDevelop.Util;

namespace ICSharpCode.PythonBinding
{
	public class RunDebugPythonCommand : RunPythonCommand
	{
		public RunDebugPythonCommand(IScriptingWorkbench workbench, PythonAddInOptions options, IDebugger debugger) 
			: base(workbench, options, debugger)
		{
			Debug = true;
		}
		
		public RunDebugPythonCommand()
			: this(new PythonWorkbench(), new PythonAddInOptions(), DebuggerService.CurrentDebugger)
		{
		}
	}
}
